using ForAurora.Model.Entry.Single;
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
    public partial class ProblemEidtForm : Form
    {
        private AddProblem addProblem;
        private IKnowltAndProblemFormReq IKnowltAndProblemFormReq;

        public ProblemEidtForm(AddProblem addProblem, IKnowltAndProblemFormReq IKnowltAndProblemFormReq)
        {
            InitializeComponent();

            this.addProblem = addProblem;
            this.IKnowltAndProblemFormReq = IKnowltAndProblemFormReq;
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
            this.tvKnowl.Nodes.Clear();
            List<KnowledgePoint> KnowlList = this.IKnowltAndProblemFormReq.QueryConnectKnowlBySuperID("root");
            foreach (KnowledgePoint KnowledgePoint in KnowlList)
            {
                this.tvKnowl.Nodes.Add(KnowledgePoint.Name).Tag = KnowledgePoint;
            }
            //递归加载节点们。
            foreach (TreeNode treeNode in this.tvKnowl.Nodes)
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Id = Guid.NewGuid().ToString("N");
            problem.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            problem.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            problem.Content = this.rtxContent.Text;
            problem.Other = this.rtxOther.Text;

            //

            
            this.addProblem(problem);
        }
    }
}
