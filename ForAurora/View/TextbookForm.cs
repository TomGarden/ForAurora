using ForAurora.Model.Entry;
using ForAurora.Model.Entry.Relation;
using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace ForAurora.View
{
    public partial class TextbookForm : Form
    {
        //所有Textbook
        private List<Textbook> TextbookList = new List<Textbook>();
        //已选中的Textbook
        private List<Textbook> TextbookSelList;
        //当前选中的课程ID
        private string currentCourseID;
        //委托对象用于和父UI通信
        private RefreshUI RefreshUI;
        //操作Textbook的工具
        private ITextbookFormReq ITextbookFormReq;
        //当前选中的Textbook
        private Textbook CurrentSelTextbook;

        private bool IsAdd = false;
        private bool IsEdit = false;

        public TextbookForm(List<Textbook> TextbookSelList, ITextbookFormReq ITextbookFormReq, string currentCourseID, RefreshUI RefreshUI)
        {
            this.TextbookSelList = TextbookSelList;
            this.ITextbookFormReq = ITextbookFormReq;
            this.currentCourseID = currentCourseID;
            this.RefreshUI = RefreshUI;
            InitializeComponent();

            this.initData();
            this.initView();
        }

        private void btnOk_Click(object sender, EventArgs e)
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

            this.Close();
        }

        private void TextbookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefreshUI("Textbook");
        }

        private void initData()
        {
            this.initTextbookList();
            this.initTextbookSelList();
        }

        private void initView()
        {
            if (this.lvTextbookSel.Columns.Count == 0)
            {
                ColumnHeader chTextbookSel = new ColumnHeader();
                chTextbookSel.Text = "已选择教材";   //设置列标题
                chTextbookSel.Width = this.gbSelList.Width - 35;    //设置列宽度
                chTextbookSel.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTextbookSel.Columns.Add(chTextbookSel);    //将列头添加到ListView控件。
                this.lvTextbookSel.FullRowSelect = true;  //选中整行
                this.lvTextbookSel.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTextbookSel.View = System.Windows.Forms.View.Details;
            }
            if (this.lvTextbook.Columns.Count == 0)
            {
                ColumnHeader chTextbook = new ColumnHeader();
                chTextbook.Text = "带选择教师";   //设置列标题
                chTextbook.Width = this.gbSelList.Width - 35;    //设置列宽度
                chTextbook.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTextbook.Columns.Add(chTextbook);    //将列头添加到ListView控件。
                this.lvTextbook.FullRowSelect = true;  //选中整行
                this.lvTextbook.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTextbook.View = System.Windows.Forms.View.Details;
            }

            //初始化选中和未选中的列表
            this.lvTextbook.BeginUpdate();
            this.lvTextbook.Items.Clear();
            foreach (Textbook textbook in TextbookList)
            {
                this.lvTextbook.Items.Add(textbook.Name);
            }
            this.lvTextbook.EndUpdate();
            this.lvTextbookSel.BeginUpdate();
            this.lvTextbookSel.Items.Clear();
            foreach (Textbook textbook in this.TextbookSelList)
            {
                this.lvTextbookSel.Items.Add(textbook.Name);
            }
            this.lvTextbookSel.EndUpdate();
            //初始换当前选中的Item的数据项
            if (this.TextbookSelList.Count != 0)
            {
                this.CurrentSelTextbook = this.TextbookSelList[0];
                this.lvTextbookSel.Items[0].Selected = true;
            }
            else if (this.TextbookList.Count != 0)
            {
                this.CurrentSelTextbook = this.TextbookList[0];
                this.lvTextbook.Items[0].Selected = true;
            }
            else
            {
                this.CurrentSelTextbook = null;
            }
        }

        private void initTextbookSelList()
        {
            string querySql = "SELECT textbook.id,textbook.uk_isbn,textbook.`name`,textbook.press,textbook.edition,textbook.other FROM textbook ";// WHERE teacher.id = @teacherID
            //拼接查询SQL和参数数组
            MySqlParameter[] mySqlParamArray = null;
            if (this.TextbookSelList.Count > 0)
            {
                mySqlParamArray = new MySqlParameter[this.TextbookSelList.Count];
                for (int i = 0; i < this.TextbookSelList.Count; i++)
                {
                    if (i != 0)
                    {
                        querySql += " OR textbook.id = @teacherID" + i + " ";
                    }
                    else
                    {
                        querySql += " WHERE textbook.id = @teacherID" + i + " ";
                    }
                    mySqlParamArray[i] = new MySqlParameter("@teacherID" + i, TextbookSelList[i].Id);
                }
            }
            else
            {
                return;
            }

            Console.WriteLine(querySql);
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, mySqlParamArray);
            this.TextbookSelList.Clear();
            while (mySqlDataReader.Read())
            {
                Textbook textbook = new Textbook();
                textbook.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                textbook.Uk_isbn = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                textbook.Name = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                textbook.Press = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                textbook.Edition = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(4);
                textbook.Other = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(5);
                this.TextbookSelList.Add(textbook);
            }
            mySqlDataReader.Close();
        }

        private void initTextbookList()
        {
            string querySql = "SELECT textbook.id,textbook.uk_isbn,textbook.`name`,textbook.press,textbook.edition,textbook.other FROM textbook ";// WHERE teacher.id <> @teacherID
            //拼接查询SQL和参数数组
            MySqlParameter[] mySqlParamArray = null;
            if (this.TextbookSelList.Count > 0)
            {
                mySqlParamArray = new MySqlParameter[this.TextbookSelList.Count];
                for (int i = 0; i < this.TextbookSelList.Count; i++)
                {
                    if (i != 0)
                    {
                        querySql += " AND textbook.id <> @textbookID" + i + " ";
                    }
                    else
                    {
                        querySql += " WHERE textbook.id <> @textbookID" + i + " ";
                    }
                    mySqlParamArray[i] = new MySqlParameter("@textbookID" + i, TextbookSelList[i].Id);
                }
            }

            Console.WriteLine(querySql);
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, mySqlParamArray);
            this.TextbookList.Clear();
            while (mySqlDataReader.Read())
            {
                Textbook textbook = new Textbook();
                textbook.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                textbook.Uk_isbn = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                textbook.Name = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                textbook.Press = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                textbook.Edition = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(4);
                textbook.Other = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(5);
                this.TextbookList.Add(textbook);
            }
            mySqlDataReader.Close();
        }

        private void lvTextbookSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvTextbookSel.SelectedItems.Count == 0)
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


            if (this.lvTextbookSel.SelectedItems.Count > 1)
            {
                //MessageBox.Show("选中了多项");
                this.CurrentSelTextbook = null;
            }
            else
            {
                int selIndex = this.lvTextbookSel.SelectedIndices[0];
                this.CurrentSelTextbook = this.TextbookSelList[selIndex];
            }
            this.refreshRightUI();
        }

        private void lvTextbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvTextbook.SelectedItems.Count == 0)
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


            if (this.lvTextbook.SelectedItems.Count > 1)
            {
                // MessageBox.Show("选中了多项");
                this.CurrentSelTextbook = null;
            }
            else
            {
                int selIndex = this.lvTextbook.SelectedIndices[0];
                this.CurrentSelTextbook = this.TextbookList[selIndex];
            }
            this.refreshRightUI();
        }
        private void refreshRightUI()
        {
            if (this.CurrentSelTextbook == null)
            {
                this.tbName.Text = "";
                this.tbISBN.Text = "";
                this.tbPress.Text = "";
                this.tbEdition.Text = "";
                this.rtbOther.Text = "";
            }
            else
            {
                this.tbName.Text = this.CurrentSelTextbook.Name;
                this.tbISBN.Text = this.CurrentSelTextbook.Uk_isbn;
                this.tbPress.Text = this.CurrentSelTextbook.Press;
                this.tbEdition.Text = this.CurrentSelTextbook.Edition;
                this.rtbOther.Text = this.CurrentSelTextbook.Other;
            }
        }

        private void btnAddTextbook_Click(object sender, EventArgs e)
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

            this.btnCancelSubmit.Visible = true;
            this.btnSubmit.Visible = true;
            this.IsAdd = true;
        }
        private void btnEditTextbook_Click(object sender, EventArgs e)
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

            this.btnCancelSubmit.Visible = true;
            this.btnSubmit.Visible = true;
            this.IsEdit = true;
        }
        private void btnDelTextbook_Click(object sender, EventArgs e)
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

            if (this.lvTextbook.SelectedItems.Count <= 0 && this.lvTextbookSel.SelectedItems.Count <= 0)
            {
                MessageBox.Show("需要先选中教材才能删除。");
                return;
            }

            SelectedIndexCollection selectedItems = null;
            List<Textbook> textbookList = null;
            if (this.lvTextbook.SelectedIndices.Count > 0)
            {
                selectedItems = this.lvTextbook.SelectedIndices;
                textbookList = this.TextbookList;
            }
            else if (this.lvTextbookSel.SelectedIndices.Count > 0)
            {
                selectedItems = this.lvTextbookSel.SelectedIndices;
                textbookList = this.TextbookSelList;
            }

            string[] textbookIDs = new string[selectedItems.Count];
            for (int i = 0; i < selectedItems.Count; i++)
            {
                textbookIDs[i] = textbookList[selectedItems[i]].Id;
            }
            this.ITextbookFormReq.DelTextbookByIds(textbookIDs);

            this.initData();
            this.initView();
        }

        private void btnRefreshTextbook_Click(object sender, EventArgs e)
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
            this.initView();
        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.btnSubmit.Visible = false;
            this.btnCancelSubmit.Visible = false;
            this.IsEdit = false;
            this.IsAdd = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Textbook textbook = new Textbook();
            textbook.Modify= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textbook.Name = this.tbName.Text.Trim();
            textbook.Uk_isbn = this.tbISBN.Text.Trim();
            textbook.Press = this.tbPress.Text.Trim();
            textbook.Edition = this.tbEdition.Text.Trim();
            textbook.Other = this.rtbOther.Text.Trim();
            if (IsAdd)
            {
                textbook.Id = Guid.NewGuid().ToString("N");
                textbook.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.ITextbookFormReq.AddOneTextbook(textbook);
            this.IsAdd = false;
            }
            if (IsEdit){
                textbook.Id = this.CurrentSelTextbook.Id;
                this.ITextbookFormReq.UpdateOneTextbook(textbook);
            this.IsEdit = false;
            }
            this.btnSubmit.Visible = false;
            this.btnCancelSubmit.Visible = false;
            this.initData();
            this.initView();
        }

        private void lvTextbookSel_DoubleClick(object sender, EventArgs e)
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

            //MessageBox.Show(this.lvTeacherSel.SelectedItems[0].Text);
            //数据设定
            int selIndex = this.lvTextbookSel.SelectedIndices[0];
            string textbookID = this.TextbookSelList[selIndex].Id;
            this.ITextbookFormReq.DelById(this.currentCourseID, textbookID);
            //UI设定
            this.TextbookList.Add(this.TextbookSelList[selIndex]);
            this.TextbookSelList.RemoveAt(selIndex);
            //刷新数据
            //this.initData();
            this.initView();
        }

        private void lvTextbook_DoubleClick(object sender, EventArgs e)
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
            //MessageBox.Show(this.lvTeacher.SelectedItems[0].Text);

            int clickTeacherIndex = this.lvTextbook.SelectedIndices[0];
            string clickTextbookID = this.TextbookList[clickTeacherIndex].Id;
            TextbookBelongCourse textbookBelongCourse = new TextbookBelongCourse();
            textbookBelongCourse.Id = Guid.NewGuid().ToString("N");
            textbookBelongCourse.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textbookBelongCourse.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textbookBelongCourse.UkTextbookId = clickTextbookID;
            textbookBelongCourse.UkCourseId = this.currentCourseID;
            this.ITextbookFormReq.AddOneTextbookForCourse(textbookBelongCourse);

            this.TextbookSelList.Add(this.TextbookList[clickTeacherIndex]);
            this.lvTextbookSel.Items.Add(this.TextbookSelList.Last().Name);
            this.TextbookList.RemoveAt(clickTeacherIndex);
            this.lvTextbook.Items.RemoveAt(clickTeacherIndex);
        }
    }
}
