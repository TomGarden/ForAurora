using ForAurora.Model;
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
    public partial class TeacherForm : Form
    {
        //操作Teacher的工具
        private ITeacherFormReq ITeacherFormReq;
        //已选择的Teacher
        private List<Teacher> TeacherSelList;
        //未选择的Teacher
        private List<Teacher> TeacherList = new List<Teacher>();
        //当前选中的课程ID
        private string currentCourseID;
        //委托对象用于和父UI通信
        private RefreshUI RefreshUI;
        //当前UI上处于选中状态的Teacher（分为有值和无值两种状态，如果有值说明选中的是单项，如果无值说明选中的是多项或者未选中。）
        private Teacher CurrentSelTeacher;

        //以下两个Boolean变量用来标记当前的操作状态
        private Boolean IsAdd = false;
        private Boolean IsEdit = false;


        public TeacherForm(List<Teacher> teacherSelList, ITeacherFormReq ITeacherFormReq ,string currentCourseID,RefreshUI RefreshUI)
        {
            this.RefreshUI = RefreshUI;
            this.currentCourseID = currentCourseID;
            this.ITeacherFormReq = ITeacherFormReq;
            this.TeacherSelList = teacherSelList;
            InitializeComponent();

            this.initData();
            this.initView();
        }

        /// <summary>
        /// 主要是吧待选择教师列表内容刷新下。
        /// </summary>
        private void initData()
        {
            this.initTeacherListData();
            this.initTeacherSelData();
        }

        private void initTeacherListData() {
            string querySql = "SELECT teacher.id,teacher.other,teacher.`name`,teacher.office,teacher.contact FROM teacher ";// WHERE teacher.id <> @teacherID
            //拼接查询SQL和参数数组
            MySqlParameter[] mySqlParamArray = null;
            if (this.TeacherSelList.Count > 0)
            {
                mySqlParamArray = new MySqlParameter[this.TeacherSelList.Count];
                for (int i = 0; i < this.TeacherSelList.Count; i++)
                {
                    if (i != 0)
                    {
                        querySql += " AND teacher.id <> @teacherID" + i + " ";
                    }
                    else
                    {
                        querySql += " WHERE teacher.id <> @teacherID" + i + " ";
                        //mySqlParamArray[i] = new MySqlParameter("@teacherID", TeacherSelList[i].Id);
                    }
                    mySqlParamArray[i] = new MySqlParameter("@teacherID" + i, TeacherSelList[i].Id);
                }
            }

            Console.WriteLine(querySql);
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, mySqlParamArray);
            this.TeacherList.Clear();
            while (mySqlDataReader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                teacher.Other = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                teacher.Name = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                teacher.Office = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                teacher.Contact = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(4);
                TeacherList.Add(teacher);
            }
            mySqlDataReader.Close();
        }
        private void initTeacherSelData()
        {
            string querySql = "SELECT teacher.id,teacher.other,teacher.`name`,teacher.office,teacher.contact FROM teacher ";// WHERE teacher.id = @teacherID
            //拼接查询SQL和参数数组
            MySqlParameter[] mySqlParamArray = null;
            if (this.TeacherSelList.Count > 0)
            {
                mySqlParamArray = new MySqlParameter[this.TeacherSelList.Count];
                for (int i = 0; i < this.TeacherSelList.Count; i++)
                {
                    if (i != 0)
                    {
                        querySql += " OR teacher.id = @teacherID" + i + " ";
                    }
                    else
                    {
                        querySql += " WHERE teacher.id = @teacherID" + i + " ";
                    }
                    mySqlParamArray[i] = new MySqlParameter("@teacherID" + i, TeacherSelList[i].Id);
                }
            }
            else {
                return;
            }

            Console.WriteLine(querySql);
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, mySqlParamArray);
            this.TeacherSelList.Clear();
            while (mySqlDataReader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                teacher.Other = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                teacher.Name = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                teacher.Office = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                teacher.Contact = mySqlDataReader.IsDBNull(4) ? "" : mySqlDataReader.GetString(4);
                this.TeacherSelList.Add(teacher);
            }
            mySqlDataReader.Close();
        }

        private void initView()
        {
            if (this.lvTeacherSel.Columns.Count == 0)
            {
                ColumnHeader chTeacherSel = new ColumnHeader();
                chTeacherSel.Text = "已选择教师";   //设置列标题
                chTeacherSel.Width = this.gbSelList.Width - 35;    //设置列宽度
                chTeacherSel.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTeacherSel.Columns.Add(chTeacherSel);    //将列头添加到ListView控件。
                this.lvTeacherSel.FullRowSelect = true;  //选中整行
                this.lvTeacherSel.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTeacherSel.View = System.Windows.Forms.View.Details;
            }
            if (this.lvTeacher.Columns.Count == 0)
            {
                ColumnHeader chTeacher = new ColumnHeader();
                chTeacher.Text = "带选择教师";   //设置列标题
                chTeacher.Width = this.gbSelList.Width - 35;    //设置列宽度
                chTeacher.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTeacher.Columns.Add(chTeacher);    //将列头添加到ListView控件。
                this.lvTeacher.FullRowSelect = true;  //选中整行
                this.lvTeacher.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTeacher.View = System.Windows.Forms.View.Details;
            }

            //初始化选中和未选中的列表
            this.lvTeacher.BeginUpdate();
            this.lvTeacher.Items.Clear();
            foreach (Teacher teacher in TeacherList)
            {
                this.lvTeacher.Items.Add(teacher.Name);
            }
            this.lvTeacher.EndUpdate();
            this.lvTeacherSel.BeginUpdate();
            this.lvTeacherSel.Items.Clear();
            foreach (Teacher teacher in this.TeacherSelList)
            {
                this.lvTeacherSel.Items.Add(teacher.Name);
            }
            this.lvTeacherSel.EndUpdate();
            //初始换当前选中的Item的数据项
            if (this.TeacherSelList.Count != 0)
            {
                this.CurrentSelTeacher = this.TeacherSelList[0];
                this.lvTeacherSel.Items[0].Selected = true;
            }
            else if (this.TeacherList.Count != 0)
            {
                this.CurrentSelTeacher = this.TeacherList[0];
                this.lvTeacher.Items[0].Selected = true;
            }
            else
            {
                this.CurrentSelTeacher = null;
            }


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

        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefreshUI("Teacher");
        }

        private void lvTeacherSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvTeacherSel.SelectedItems.Count == 0)
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


            if (this.lvTeacherSel.SelectedItems.Count > 1)
            {
                //MessageBox.Show("选中了多项");
                this.CurrentSelTeacher = null;
                this.refreshRightUI();
                return;
            }
            int selIndex = this.lvTeacherSel.SelectedIndices[0];
            this.CurrentSelTeacher = this.TeacherSelList[selIndex];
            this.refreshRightUI();
        }

        private void lvTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvTeacher.SelectedItems.Count == 0)
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


            if (this.lvTeacher.SelectedItems.Count > 1)
            {
                //MessageBox.Show("选中了多项");
                this.CurrentSelTeacher = null;
                this.refreshRightUI();
                return;
            }
            int selIndex = this.lvTeacher.SelectedIndices[0];
            this.CurrentSelTeacher = this.TeacherList[selIndex];
            this.refreshRightUI();
        }

        private void refreshRightUI()
        {
            if (this.CurrentSelTeacher == null)
            {
                this.tbName.Text = "";
                this.tbOffice.Text = "";
                this.tbContact.Text = "";
                this.rtbOther.Text = "";
            }
            else
            {
                this.tbName.Text = this.CurrentSelTeacher.Name;
                this.tbOffice.Text = this.CurrentSelTeacher.Office;
                this.tbContact.Text = this.CurrentSelTeacher.Contact;
                this.rtbOther.Text = this.CurrentSelTeacher.Other;
            }
        }

        private void lvTeacherSel_DoubleClick(object sender, EventArgs e)
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
            int selIndex = this.lvTeacherSel.SelectedIndices[0];
            string teacherID = this.TeacherSelList[selIndex].Id;
            this.ITeacherFormReq.DelById(this.currentCourseID, teacherID);
            //UI设定
            this.TeacherList.Add(this.TeacherSelList[selIndex]);
            this.TeacherSelList.RemoveAt(selIndex);
            //刷新数据
            //this.initData();
            this.initView();
        }

        private void lvTeacher_DoubleClick(object sender, EventArgs e)
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

            int clickTeacherIndex = this.lvTeacher.SelectedIndices[0];
            string clickTeacherID=this.TeacherList[clickTeacherIndex].Id;
            TeacherTeachCourse teacherTeachCourse = new TeacherTeachCourse();
            teacherTeachCourse.Id = Guid.NewGuid().ToString("N");
            teacherTeachCourse.Create= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            teacherTeachCourse.Modify= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            teacherTeachCourse.UkTeacherId = clickTeacherID;
            teacherTeachCourse.UkCourseId = this.currentCourseID;
            this.ITeacherFormReq.AddOneTeacherForCourse(teacherTeachCourse);

            this.TeacherSelList.Add(this.TeacherList[clickTeacherIndex]);
            this.lvTeacherSel.Items.Add(this.TeacherSelList.Last().Name);
            this.TeacherList.RemoveAt(clickTeacherIndex);
            this.lvTeacher.Items.RemoveAt(clickTeacherIndex);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
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

            this.btnSubmit.Visible = true;
            this.btnCancelSubmit.Visible = true;
        }
        private void btnEditTeacher_Click(object sender, EventArgs e)
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.IsAdd)
            {
                Teacher teacher = new Model.Entry.Teacher();
                teacher.Id = Guid.NewGuid().ToString("N");
                teacher.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                teacher.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                teacher.Name = this.tbName.Text.Trim();
                teacher.Contact = this.tbContact.Text.Trim();
                teacher.Office = this.tbOffice.Text.Trim();
                teacher.Other = this.rtbOther.Text;
                this.ITeacherFormReq.AddOneTeacher(teacher);
                this.IsAdd = false;
            }
            else if (this.IsEdit)
            {
                this.CurrentSelTeacher.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.CurrentSelTeacher.Name = this.tbName.Text.Trim();
                this.CurrentSelTeacher.Contact = this.tbContact.Text.Trim();
                this.CurrentSelTeacher.Office = this.tbOffice.Text.Trim();
                this.CurrentSelTeacher.Other = this.rtbOther.Text;
                this.ITeacherFormReq.UpdateOneTeacher(this.CurrentSelTeacher);
                this.IsEdit = false;
            }

            this.btnCancelSubmit.Visible = false;
            this.btnSubmit.Visible = false;
            this.initData();
            this.initView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        }

        private void btnDelTeacher_Click(object sender, EventArgs e)
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

            
            if (this.lvTeacher.SelectedItems.Count <= 0 && this.lvTeacherSel.SelectedItems.Count <= 0)
            {
                MessageBox.Show("需要先选中教师才能删除。");
                return;
            }

            SelectedIndexCollection selectedItems = null;
            List<Teacher> teacherList = null;
            if (this.lvTeacher.SelectedIndices.Count > 0)
            {
                selectedItems = this.lvTeacher.SelectedIndices;
                teacherList = this.TeacherList;
            }
            else if (this.lvTeacherSel.SelectedIndices.Count > 0) {
                selectedItems = this.lvTeacherSel.SelectedIndices;
                teacherList = this.TeacherSelList;
            }

            string[] teacherIDs = new string[selectedItems.Count];
            for (int i = 0; i < selectedItems.Count; i++) {
                teacherIDs[i] = teacherList[selectedItems[i]].Id;
            }
            this.ITeacherFormReq.DelTeachersByIds(teacherIDs);

            this.initData();
            this.initView();
        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            if (this.CurrentSelTeacher == null)
            {
                this.tbContact.Text = "";
                this.tbName.Text = "";
                this.tbOffice.Text = "";
            }
            else
            {
                this.tbContact.Text = this.CurrentSelTeacher.Contact == null ? "" : this.CurrentSelTeacher.Contact;
                this.tbName.Text = this.CurrentSelTeacher.Name == null ? "" : this.CurrentSelTeacher.Name;
                this.tbOffice.Text = this.CurrentSelTeacher.Office == null ? "" : this.CurrentSelTeacher.Office;
            }

            this.btnSubmit.Visible = false;
            this.btnCancelSubmit.Visible = false;
            this.IsEdit = false;
            this.IsAdd = false;
        }

        private void btnRefreshTeacher_Click(object sender, EventArgs e)
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


    }
}
