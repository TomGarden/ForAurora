using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
using ForAurora.Presenter.ImplViewReq;
using ForAurora.View.Requirement;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ForAurora.View
{
    //刷新试题类型
    public delegate void RefreshType();
    public partial class ProblemEidtForm : Form
    {
        private IKnowltAndProblemFormReq IKnowltAndProblemFormReq;
        private string currentSelKnowlID;
        private List<string> checkIDs = new List<string>();
        private IProblemEditFormReq iProblemEditFormReq;
        private string TipEditType = "编辑试题类型";
        private AddProblem addProblem;
        //
        private ProblemWithTypeName CurSelProblemWithTN;
        private EditProblem editProblem;
        private List<string> oldKnowl;


        public ProblemEidtForm(string knowlID, IKnowltAndProblemFormReq IKnowltAndProblemFormReq, AddProblem addProblem)
        {
            InitializeComponent();

            this.IKnowltAndProblemFormReq = IKnowltAndProblemFormReq;
            this.currentSelKnowlID = knowlID;
            this.addProblem = addProblem;
            this.iProblemEditFormReq = ImplProblemEditFormReq.NewInstance();

            this.initData();
            this.initView();
        }

        public ProblemEidtForm(ProblemWithTypeName CurSelProblemWithTN, IKnowltAndProblemFormReq IKnowltAndProblemFormReq, EditProblem editProblem)
        {
            InitializeComponent();
            this.IKnowltAndProblemFormReq = IKnowltAndProblemFormReq;
            this.CurSelProblemWithTN = CurSelProblemWithTN;
            this.editProblem = editProblem;
            this.iProblemEditFormReq = ImplProblemEditFormReq.NewInstance();

            this.initData();
            this.initView();
        }

        private void initView()
        {
            if (CurSelProblemWithTN!=null) {
                this.rtxContent.Text = this.CurSelProblemWithTN.Content;
                this.rtxOther.Text = this.CurSelProblemWithTN.Other;
            }


            this.rtxContent.Focus();

            //this.tvKnowl.Nodes.AddRange((TreeNode[])this.treeNodeArray);
        }

        private void initData()
        {
            this.initTree();
            this.initType();
        }

        private void initTree()
        {
            this.tvKnowl.Nodes.Clear();


            if (CurSelProblemWithTN != null)
            {
                this.checkIDs = this.IKnowltAndProblemFormReq.QueryKnowlByProblemId(this.CurSelProblemWithTN.Id);
                this.oldKnowl = new List<string>(this.checkIDs.ToArray());//克隆列表
                Console.WriteLine("adfg");
            }

            List<KnowledgePoint> KnowlList = this.IKnowltAndProblemFormReq.QueryConnectKnowlBySuperID("root",ViewGlobal.courseForm.getCurrentCourse().Id);
            foreach (KnowledgePoint KnowledgePoint in KnowlList)
            {
                TreeNode treeNode = this.tvKnowl.Nodes.Add(KnowledgePoint.Name);
                treeNode.Tag = KnowledgePoint;

                if (this.currentSelKnowlID != null)//这是添加试题
                {
                    if (KnowledgePoint.Id.Equals(this.currentSelKnowlID))
                    {
                        treeNode.Checked = true;
                        this.currentSelKnowlID = null;
                    }
                }
                if(this.checkIDs.Count>0)//这是编辑试题
                {
                    foreach(string id in this.checkIDs){
                        if (KnowledgePoint.Id.Equals(id)) {
                            treeNode.Checked = true;
                            this.checkIDs.Remove(id);
                            break;
                        }
                    }
                }

            }
            //递归加载节点们。
            foreach (TreeNode treeNode in this.tvKnowl.Nodes)
            {
                this.RecursionNode(treeNode);
            }
        }

        private void initType()
        {
            List<Model.Entry.Single.ProblemType> typeList = this.iProblemEditFormReq.QueryAllType();
            this.cbProblemType.Items.Clear();
            foreach (Model.Entry.Single.ProblemType type in typeList)
            {
                this.cbProblemType.Items.Add(type);
            }

            this.cbProblemType.Items.Add(TipEditType);

            if (this.CurSelProblemWithTN != null)
            {
                this.cbProblemType.Text = this.CurSelProblemWithTN.TypeName == null ? "" : this.CurSelProblemWithTN.TypeName;
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
                        TreeNode treeNodeChild = treeNode.Nodes.Add(KnowledgePoint.Name);
                        treeNodeChild.Tag = KnowledgePoint;

                        if (this.currentSelKnowlID != null)
                        {
                            if (KnowledgePoint.Id.Equals(this.currentSelKnowlID))
                            {
                                treeNode.Checked = true;
                                this.currentSelKnowlID = null;
                            }
                        }
                        if (this.checkIDs.Count > 0)
                        {
                            foreach (string id in this.checkIDs)
                            {
                                if (KnowledgePoint.Id.Equals(id))
                                {
                                    treeNodeChild.Checked = true;
                                    this.checkIDs.Remove(id);
                                    break;
                                }
                            }
                        }
                    }
                    //为叶子节点添加孩子节点后，查看孩子节点是否有孙子节点
                    foreach (TreeNode node in treeNode.Nodes)
                    {
                        this.RecursionNode(node);
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            problem.Content = this.rtxContent.Text;
            problem.Other = this.rtxOther.Text;
            ProblemType type = (ProblemType)this.cbProblemType.SelectedItem;
            if (type != null)
            {
                problem.TypeId = type.Id;
            }
            //this.iProblemEditFormReq.InsertOneProblem(problem, this.checkIDs);

            if (this.addProblem != null)
            {
                problem.Id = Guid.NewGuid().ToString("N");
                problem.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.addProblem(problem, this.checkIDs);
            }
            if(this.editProblem!=null)
            {
                problem.Id = this.CurSelProblemWithTN.Id;
                this.editProblem(problem,this.oldKnowl, this.checkIDs);
            }
            this.Close();

        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvKnowl_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            KnowledgePoint KnowledgePointItem = (KnowledgePoint)node.Tag;
            if (node.Checked == false)
            {
                this.checkIDs.Remove(KnowledgePointItem.Id);
            }
            else
            {
                this.checkIDs.Add(KnowledgePointItem.Id);
            }
            //MessageBox.Show("" + this.checkIDs.Count);
        }

        private void cbProblemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProblemType type = (ProblemType)this.cbProblemType.SelectedItem;
            if (type.Name.Equals(TipEditType))
            {
                RefreshType RefreshType = new RefreshType(this.RefreshType);
                ProblemTypeForm problemTypeForm = new ProblemTypeForm(this.iProblemEditFormReq, RefreshType);
                problemTypeForm.ShowDialog();
            }
        }

        //委托们
        private void RefreshType()
        {
            this.initType();
        }
    }
}
