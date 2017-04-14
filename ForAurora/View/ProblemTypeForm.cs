using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForAurora.Model.Entry.Single;
using ForAurora.View.Requirement;
using ForAurora.Presenter.ImplViewReq;

namespace ForAurora.View
{
    public partial class ProblemTypeForm : Form
    {
        private bool IsAdd = false;
        private bool IsEdit = false;
        private ProblemType CurrentSelType = null;
        private IProblemTypeFormReq iProblemTypeFormReq;
        private IProblemEditFormReq iProblemEditFormReq;
        private RefreshType RefreshType;//委托方法

        public ProblemTypeForm(IProblemEditFormReq iProblemEditFormReq, RefreshType RefreshType)
        {
            InitializeComponent();

            this.iProblemEditFormReq = iProblemEditFormReq;
            this.iProblemTypeFormReq = ImplProblemTypeFormReq.NewInstance();
            this.RefreshType = RefreshType;
            this.initView();
            this.initData();
        }

        private void initData()
        {
            //throw new NotImplementedException();
            List<ProblemType> typeList = this.iProblemEditFormReq.QueryAllType();

            this.lvType.Items.Clear();
            foreach (ProblemType type in typeList)
            {
                this.lvType.Items.Add(type.Name).Tag = type;
            }
            this.lvType.Items[0].Selected = true;
        }

        private void initView()
        {
            //throw new NotImplementedException();
            if (this.lvType.Columns.Count <= 0)
            {
                ColumnHeader chCourse = new ColumnHeader();
                chCourse.Text = "试题类型";   //设置列标题
                chCourse.Width = this.gbType.Width - 35;    //设置列宽度
                //MessageBox.Show();
                chCourse.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvType.Columns.Add(chCourse);    //将列头添加到ListView控件。
                this.lvType.FullRowSelect = true;  //选中整行
                this.lvType.HeaderStyle = ColumnHeaderStyle.None;
                this.lvType.View = System.Windows.Forms.View.Details;
            }
            
        }

        private void lvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvType.SelectedItems.Count == 0)
            {
                return;
            }

            if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            if (this.lvType.SelectedItems.Count > 1)
            {
                //选中多项目，就是一项都没有选中，先把右边的按钮设置为不可点击状态。
                //MessageBox.Show("选中了多堂课程");
                this.CurrentSelType = null;
                this.tbTypeName.Text = "";
                this.rtbTypeOther.Text = "";
                return;
            }
            //以下就是选中项为1项的情况了

            //获取选中课程的数据
            this.CurrentSelType = (ProblemType)lvType.SelectedItems[0].Tag;

            this.tbTypeName.Text = this.CurrentSelType.Name;
            this.rtbTypeOther.Text = this.CurrentSelType.Other;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            this.IsAdd = true;
            this.btnCancelSubmit.Visible = true;
            this.btnSubmit.Visible = true;
            this.tbTypeName.Focus();
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            if (this.lvType.SelectedItems.Count <= 0)
            {
                MessageBox.Show("需要先选中教材才能删除。");
                return;
            }

            List<string> typeIDS = new List<string>();
            foreach (ListViewItem lvItem in this.lvType.SelectedItems) {
                ProblemType type = (ProblemType)lvItem.Tag;
                typeIDS.Add(type.Id);
            }
            this.iProblemTypeFormReq.DelTypeByIds(typeIDS);

            this.initData();
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }
            this.IsEdit = true;
            this.btnCancelSubmit.Visible = true;
            this.btnSubmit.Visible = true;
            this.tbTypeName.Focus();
        }

        private void btnRefreshType_Click(object sender, EventArgs e)
        {
            if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            this.initData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProblemType type = new ProblemType();
            
            type.Modify= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            type.Name = this.tbTypeName.Text.Trim();
            type.Other = this.rtbTypeOther.Text;
            
            if (IsAdd)
            {
                type.Id = Guid.NewGuid().ToString("N");
                type.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.iProblemTypeFormReq.InsertOneType(type);
                this.IsAdd = false;
            }
            if (IsEdit)
            {
                type.Id = this.CurrentSelType.Id;
                this.iProblemTypeFormReq.UpdateOneType(type);
                this.IsEdit = false;
            }
            this.btnSubmit.Visible = false;
            this.btnCancelSubmit.Visible = false;
            this.initData();
            this.initView();

        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.IsAdd = false;
            this.IsEdit = false;
            this.btnSubmit.Visible = false;
            this.btnCancelSubmit.Visible = false;

            if (CurrentSelType != null)
            {
                this.CurrentSelType = (ProblemType)lvType.SelectedItems[0].Tag;
                this.tbTypeName.Text = this.CurrentSelType.Name;
                this.rtbTypeOther.Text = this.CurrentSelType.Other;
            }
        }

        private void ProblemTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefreshType();
        }
    }
}
