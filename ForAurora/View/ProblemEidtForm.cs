using ForAurora.Model.Entry.Single;
using ForAurora.Presenter.ImplViewReq;
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

        public ProblemEidtForm(string knowlID, IKnowltAndProblemFormReq IKnowltAndProblemFormReq)
        {
            InitializeComponent();

            this.IKnowltAndProblemFormReq = IKnowltAndProblemFormReq;
            this.currentSelKnowlID = knowlID;
            this.iProblemEditFormReq = ImplProblemEditFormReq.NewInstance();
            this.initData();
            this.initView();
        }

        private void initView()
        {
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
            List<KnowledgePoint> KnowlList = this.IKnowltAndProblemFormReq.QueryConnectKnowlBySuperID("root");
            foreach (KnowledgePoint KnowledgePoint in KnowlList)
            {
                TreeNode treeNode = this.tvKnowl.Nodes.Add(KnowledgePoint.Name);
                treeNode.Tag = KnowledgePoint;

                if (KnowledgePoint.Id.Equals(this.currentSelKnowlID))
                {
                    treeNode.Checked = true;
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
                this.cbProblemType.Items.Add(type.Name);
            }

            this.cbProblemType.Items.Add(TipEditType);
            this.cbProblemType.Tag = typeList;
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

                        if (KnowledgePoint.Id.Equals(this.currentSelKnowlID))
                        {
                            treeNodeChild.Checked = true;
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
            problem.Id = Guid.NewGuid().ToString("N");
            problem.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            problem.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            problem.Content = this.rtxContent.Text;
            problem.Other = this.rtxOther.Text;

            //

            this.iProblemEditFormReq.InsertOneProblem(problem, this.checkIDs);
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
            if (this.cbProblemType.SelectedItem.ToString().Equals(TipEditType))
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
