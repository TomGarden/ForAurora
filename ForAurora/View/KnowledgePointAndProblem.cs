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
    public delegate void RefreshProblem();
    //试题焦点获取
    public delegate void SelProblem(ProblemWithTypeName problemWithTN, bool IsBtn);
    public partial class KnowledgePointAndProblem : Form
    {
        //从CourseFrom携带过来的课程ID
        private string courseID;
        private IKnowltAndProblemFormReq IKnowltAndProblemFormReq = ImplKnowltAndProblemFormReq.NewInstance();
        private KnowledgePoint CurSelKnol = null;//当前选中的知识点
        private ProblemWithTypeName SelProblemWithTN = null;//当前选中的题目
        private SelProblem selProblem = null;

        public KnowledgePointAndProblem(string courseID)
        {
            InitializeComponent();

            this.courseID = courseID;
            this.initData();
            this.initView();
        }

        private void initView()
        {
            //throw new NotImplementedException();
        }

        private void initData()
        {
            this.tvKnowlTree.Nodes.Clear();

            List<KnowledgePoint> KnowlList = this.IKnowltAndProblemFormReq.QueryConnectKnowlBySuperID("root");
            foreach (KnowledgePoint KnowledgePoint in KnowlList)
            {
                this.tvKnowlTree.Nodes.Add(KnowledgePoint.Name).Tag = KnowledgePoint;
            }
            //递归加载节点们。
            foreach (TreeNode treeNode in this.tvKnowlTree.Nodes)
            {
                this.RecursionNode(treeNode);
            }
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

            this.panelProblemGroup.Controls.Clear();
            if (this.CurSelKnol != null)
            {
                List<ProblemWithTypeName> ProblemList = this.IKnowltAndProblemFormReq.QueryAllProblems(this.CurSelKnol.Id);

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
                    MessageBox.Show("无内容");
                }
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

        private void RefreshProblem()
        {
            MessageBox.Show("刷新试题");
        }

        private void SelProblem(ProblemWithTypeName problemWithTN, bool IsBtn)
        {
            if (this.SelProblemWithTN != problemWithTN)
            {
                this.SelProblemWithTN = problemWithTN;
                
            }

            if (IsBtn)
            {
                MessageBox.Show("添加到试卷");
            }
        }

        //================试题操作相关
        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            RefreshProblem RefreshProblem = new RefreshProblem(this.RefreshProblem);
            ProblemEidtForm problemEidtForm = new ProblemEidtForm(this.CurSelKnol.Id, this.IKnowltAndProblemFormReq, RefreshProblem);
            problemEidtForm.ShowDialog();
        }

        private void btnRefreshProblem_Click(object sender, EventArgs e)
        {
            this.initProblem();
        }
    }
}
