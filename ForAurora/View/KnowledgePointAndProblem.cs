using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
using ForAurora.Presenter.ImplViewReq;
using ForAurora.View;
using ForAurora.View.Requirement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForAurora
{
    //添加知识点
    public delegate void AddKnowlPoint(KnowledgePoint knowlPoin, CourseSpreadKnowl courseSpreadKnowlt);
    public delegate void UpdateKnowlPoint(KnowledgePoint knowlPoint);
    //添加试题
    public delegate void AddProblem(Problem problem, List<string> checkIDs);
    //修改试题
    public delegate void EditProblem(Problem problem, List<string> oldKnowl, List<string> checkIDs);
    //试题焦点获取
    public delegate void SelProblem(OneProblemForm oneProblemForm, ProblemWithTypeName problemWithTN, bool IsBtn);
    //编辑试题答案
    public delegate void EditAnswer(ProblemAnswer pa);
    //试卷断后
    public delegate void ClosePaper(string closeStr,string exportPath);
    public partial class KnowledgePointAndProblem : Form
    {
        //从CourseFrom携带过来的课程ID
        private string courseID;
        private IKnowltAndProblemFormReq IKnowltAndProblemFormReq = ImplKnowltAndProblemFormReq.NewInstance();
        private KnowledgePoint CurSelKnol = null;//当前选中的知识点
        private ProblemWithTypeName CurSelProblemWithTN = null;//当前选中的题目
        private OneProblemForm CurSelProblemForm; //当前选中的试题窗口
        private ProblemAnswer CurAnswer = null;//当前正在现实的答案
        private SelProblem selProblem = null;//委托对象
        private string tipSelProblem = "需要先选中试题";
        private ClosePaper varClosePaper;

        public KnowledgePointAndProblem(string courseID)
        {
            InitializeComponent();

            this.courseID = courseID;
            this.initData();
        }

        private void initData()
        {
            //知识点树
            this.tvKnowlTree.Nodes.Clear();
            List<KnowledgePoint> KnowlList = this.IKnowltAndProblemFormReq.QueryConnectKnowlBySuperID("root", courseID);
            foreach (KnowledgePoint KnowledgePoint in KnowlList)
            {
                this.tvKnowlTree.Nodes.Add(KnowledgePoint.Name).Tag = KnowledgePoint;
            }
            //递归加载节点们。
            foreach (TreeNode treeNode in this.tvKnowlTree.Nodes)
            {
                this.RecursionNode(treeNode);
            }
            //试题类型
            List<Model.Entry.Single.ProblemType> typeList = this.IKnowltAndProblemFormReq.QueryAllType();
            this.cbProblemType.Items.Clear();
            foreach (Model.Entry.Single.ProblemType type in typeList)
            {
                this.cbProblemType.Items.Add(type);
            }
            this.cbProblemType.Items.Add("所有类型");
            this.cbProblemType.SelectedIndex = this.cbProblemType.Items.Count - 1;
        }

        /// <summary>
        ///  叶子节点深度递归,一直传参过来的都是叶子节点啊说
        /// </summary>
        private void RecursionNode(TreeNode treeNode)
        {
            //首先判断是否为叶子节点
            //if (treeNode.Nodes.Count > 0)//有叶子节点，就去遍历叶子节点
            //{
            //    foreach (TreeNode node in treeNode.Nodes)
            //    {
            //        this.RecursionNode(node);
            //    }
            //}
            //else//本身就是叶子节点，查看当前叶子节点是否存在孩子节点
            {
                KnowledgePoint KnowledgePointItem = (KnowledgePoint)treeNode.Tag;
                List<KnowledgePoint> KnowlListChild = this.IKnowltAndProblemFormReq.QuerySingleKnowlBySuperID(KnowledgePointItem.Id);

                if (KnowlListChild.Count > 0)
                {
                    foreach (KnowledgePoint KnowledgePoint in KnowlListChild)
                    {
                        treeNode.Nodes.Add(KnowledgePoint.Name).Tag = KnowledgePoint;
                    }
                    //为叶子节点添加孩子节点后，查看孩子节点是否有孙子节点
                    foreach (TreeNode node in treeNode.Nodes)
                    {
                        this.RecursionNode(node);
                    }
                }
            }
        }

        private void btnRefreshKnowl_Click(object sender, EventArgs e)
        {
            this.initData();
        }

        private void tvKnowlTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.CurSelKnol = (KnowledgePoint)this.tvKnowlTree.SelectedNode.Tag;
            //MessageBox.Show("AfterSelect" + this.CurrentSelKnol.Name);

            this.initProblem();
        }

        private void initProblem()
        {
            if (this.selProblem == null)
            {
                this.selProblem = new SelProblem(this.SelProblem);
            }


            if (this.CurSelKnol != null)
            {
                List<ProblemWithTypeName> ProblemList = this.IKnowltAndProblemFormReq.QueryAllProblems(this.CurSelKnol.Id);
                this.ShowProblem(ProblemList);
            }

        }

        private void KnowledgePointAndProblem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ViewGlobal.courseForm.Show();
        }

        private void btnAddKnowl_Click(object sender, EventArgs e)
        {
            AddKnowlPoint addKnowlPoint = new AddKnowlPoint(this.AddKnowlPoint);
            KnowledgePointForm knowledgePointForm = new KnowledgePointForm(this.courseID, addKnowlPoint, this.CurSelKnol);
            knowledgePointForm.ShowDialog();
        }

        private void btnDelKnowl_Click(object sender, EventArgs e)
        {
            if (this.CurSelKnol == null)
            {
                MessageBox.Show("请先选中要删除的知识点");
                return;
            }
            //MessageBox.Show("确定删除知识点“" + this.CurrentSelKnol.Name + "”和其子知识点", "确认删除？", new MessageBoxButtons());
            DialogResult dr = MessageBox.Show("确定删除知识点“" + this.CurSelKnol.Name + "”和其子知识点？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //用户选择确认的操作
                this.IKnowltAndProblemFormReq.DelKnowlByID(this.CurSelKnol.Id);
                this.initData();
            }
            else if (dr == DialogResult.Cancel)
            {
                //用户选择取消的操作
            }

        }

        private void btnEditKnowl_Click(object sender, EventArgs e)
        {
            if (this.CurSelKnol == null)
            {
                MessageBox.Show("请先选中要编辑的知识点");
                return;
            }
            UpdateKnowlPoint updateKnowlPoint = new UpdateKnowlPoint(this.UpdateKnowlPoint);
            KnowledgePointEidtForm knowledgePointEditForm = new KnowledgePointEidtForm(updateKnowlPoint, CurSelKnol);
            knowledgePointEditForm.ShowDialog();
        }

        //===============委托们
        private void AddKnowlPoint(KnowledgePoint knowlPoint, CourseSpreadKnowl courseSpreadKnowl)
        {
            this.IKnowltAndProblemFormReq.InsertOneKnowl(knowlPoint, courseSpreadKnowl);
            this.initData();
        }

        private void UpdateKnowlPoint(KnowledgePoint knowlPoint)
        {
            this.IKnowltAndProblemFormReq.UpdateOneKnowl(knowlPoint);
            this.initData();
        }

        private void AddProblem(Problem problem, List<string> checkIDs)
        {
            //MessageBox.Show("添加试题委托");
            this.IKnowltAndProblemFormReq.InsertOneProblem(problem, checkIDs);
            this.initProblem();
        }

        private void EditProblem(Problem problem, List<string> oldKnowl, List<string> checkIDs)
        {
            this.IKnowltAndProblemFormReq.EditOneProblem(problem, oldKnowl, checkIDs);
            this.initProblem();
        }

        private void SelProblem(OneProblemForm oneProblemForm, ProblemWithTypeName problemWithTN, bool IsBtn)
        {
            //if (this.CurSelProblemWithTN != problemWithTN)
            //{
            //    this.CurSelProblemWithTN = problemWithTN;
            //    this.tbProblemType.Text = this.CurSelProblemWithTN.TypeName;
            //    this.rtbProblemOther.Text = this.CurSelProblemWithTN.Other;
            //}

            if (CurSelProblemForm != oneProblemForm)
            {
                if (CurSelProblemForm != null) { CurSelProblemForm.CancelFocus(); }
                CurSelProblemForm = oneProblemForm;
                CurSelProblemForm.SetFocus();

                this.CurSelProblemWithTN = CurSelProblemForm.cuProblemWithTN;
                this.tbProblemType.Text = this.CurSelProblemWithTN.TypeName;
                this.rtbProblemOther.Text = this.CurSelProblemWithTN.Other;
            }

            if (IsBtn)
            {
                //MessageBox.Show("添加到试卷");
                if (this.IKnowltAndProblemFormReq.InsertOneProblem(this.CurSelProblemWithTN) == 1)
                {
                    if (this.varClosePaper == null)
                    {
                        this.varClosePaper = new ClosePaper(this.ClosePaper);
                    }
                    PaperForm.getInstance(this.varClosePaper).AddChild(new ProblemInPaper(this.CurSelProblemWithTN));
                }
            }
            this.ShowAnswer();
        }

        private void EditAnswer(ProblemAnswer pa)
        {
            if (this.CurSelProblemWithTN == null)
            {
                MessageBox.Show("没有先选中试题，本次操作无效");
                return;
            }

            pa.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            pa.ProblemId = this.CurSelProblemWithTN.Id;//试题ID很关键啊
            if (this.CurAnswer == null)
            {
                pa.Id = Guid.NewGuid().ToString("N");
                pa.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.IKnowltAndProblemFormReq.InsertOneAnswer(pa);
            }
            else
            {
                pa.Id = this.CurAnswer.Id;
                this.IKnowltAndProblemFormReq.UpdateOneAnswer(pa);
            }
            //刷新下
            this.ShowAnswer();
            //MessageBox.Show("暂时什么都没做呢" + pa.Content);
        }

        private void ClosePaper(string closeStr, string exportPath)
        {
            if (closeStr.Equals("btnExport"))
            {
                List<string> exportProblem = this.IKnowltAndProblemFormReq.QueryAllPaper();
                //如果真的要使用word那要求用户必须安装word
                //MessageBox.Show("导出"+exportPath);

                FileStream fs = new FileStream(exportPath+ "\\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".doc", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach(string str in exportProblem)
                {
                    //开始写入
                    sw.Write(str+"\n\n\n");
                    //清空缓冲区
                    sw.Flush();
                }
                //关闭流
                sw.Close();
                fs.Close();
            }
            this.IKnowltAndProblemFormReq.ClearPaper();
            //MessageBox.Show("清空");
            //打开文件夹
            if (closeStr.Equals("btnExport"))
            {
                System.Diagnostics.Process.Start("Explorer.exe", exportPath);
            }

        }
        //================试题操作相关
        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            if (this.CurSelKnol == null)
            {
                MessageBox.Show("需要先选中知识点");
                return;
            }
            AddProblem addProblem = new AddProblem(this.AddProblem);
            ProblemEidtForm problemEidtForm = new ProblemEidtForm(this.CurSelKnol.Id, this.IKnowltAndProblemFormReq, addProblem);
            problemEidtForm.ShowDialog();
        }

        private void btnRefreshProblem_Click(object sender, EventArgs e)
        {
            this.initProblem();
        }

        private void btnDelProblem_Click(object sender, EventArgs e)
        {
            if (CurSelProblemWithTN == null) { MessageBox.Show(this.tipSelProblem); return; }
            DialogResult dr;
            dr = MessageBox.Show(CurSelProblemWithTN.Content, "确认删除", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.IKnowltAndProblemFormReq.DelOneProblem(this.CurSelProblemWithTN.Id);
                this.initProblem();
            }
            //else if (dr == DialogResult.No)
            //    MessageBox.Show("你选择的为“否”按钮", "系统提示2");
            //else if (dr == DialogResult.Cancel)
            //    MessageBox.Show("你选择的为“取消”按钮", "系统提示3");
            //else
            //    MessageBox.Show("你没有进行任何的操作！", "系统提示4");
        }

        private void btnEditProblem_Click(object sender, EventArgs e)
        {
            if (CurSelProblemWithTN == null) { MessageBox.Show(this.tipSelProblem); return; }

            EditProblem editProblem = new EditProblem(this.EditProblem);
            ProblemEidtForm problemEidtForm = new ProblemEidtForm(this.CurSelProblemWithTN, this.IKnowltAndProblemFormReq, editProblem);
            problemEidtForm.ShowDialog();

        }

        private void ShowAnswer()
        {
            if (CurSelProblemWithTN == null) { return; }

            List<ProblemAnswer> paList = this.IKnowltAndProblemFormReq.QueryOneAnswerByProblemId(this.CurSelProblemWithTN.Id);

            if (paList.Count > 0)
            {
                this.CurAnswer = paList[0];
                this.rtbAnswer.Text = paList[0].Content;
                this.rtbAnswerOther.Text = paList[0].Other;
                this.tbAnswerSRC.Text = paList[0].Source;
            }
            else
            {
                this.CurAnswer = null;
                this.rtbAnswer.Text = "";
                this.rtbAnswerOther.Text = "";
                this.tbAnswerSRC.Text = "";
            }

            Console.WriteLine("设置完成答案");
        }

        //==========================答案编辑
        private void btnAnswerEdit_Click(object sender, EventArgs e)
        {
            if (this.CurSelProblemWithTN == null)
            {
                MessageBox.Show(this.tipSelProblem);
                return;
            }
            EditAnswer editeAnswer = new EditAnswer(this.EditAnswer);
            AnswerEditForm aef = new AnswerEditForm(editeAnswer);
            aef.ShowDialog();
        }

        private void btnAnswerRefresh_Click(object sender, EventArgs e)
        {
            this.ShowAnswer();
        }

        private void btnAnswerDel_Click(object sender, EventArgs e)
        {
            if (this.CurAnswer == null) { return; }

            this.IKnowltAndProblemFormReq.DelAnswerById(this.CurAnswer.Id);

            this.ShowAnswer();
        }

        //展示试题类型
        private void cbProblemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.CurSelKnol==null)
            {
                return;
            }

            ProblemType type;
            try
            {
                type = (ProblemType)this.cbProblemType.SelectedItem;
            }
            catch (Exception ex)
            {
                type = null;
            }

            if (type == null)
            {
                this.initProblem();
            }
            else
            {
                //MessageBox.Show("按类型筛选题目:"+type.Id);
                List<ProblemWithTypeName> ProblemList = this.IKnowltAndProblemFormReq.QueryAllProblems(this.CurSelKnol.Id, type.Id);
                this.ShowProblem(ProblemList);
            }

        }

        private void ShowProblem(List<ProblemWithTypeName> ProblemList)
        {
            this.panelProblemGroup.Controls.Clear();
            int hei = 0;
            foreach (ProblemWithTypeName problemWithTN in ProblemList)
            {
                OneProblemForm porblemForm = new OneProblemForm(problemWithTN, this.selProblem);
                porblemForm.TopLevel = false;
                porblemForm.Location = new Point(0, hei);
                this.panelProblemGroup.Controls.Add(porblemForm);
                porblemForm.Show();
                hei += porblemForm.Height + 5;
            }
            if (hei == 0)
            {
                //MessageBox.Show("无内容");
            }
        }
    }
}
