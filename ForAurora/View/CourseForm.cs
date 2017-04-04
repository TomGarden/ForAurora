using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ForAurora.Model.Entry;
using ForAurora.Model.Entry.Relation;
using ForAurora.Model;
using ForAurora.View;

namespace ForAurora
{
    public partial class CourseForm : Form
    {
        private List<Course> CourseList = new List<Course>();
        private List<Teacher> TeacherList = new List<Teacher>();
        private List<Textbook> TextbookList = new List<Textbook>();
        private List<TeacherTeachCourse> TeacherTeachCourseList = new List<TeacherTeachCourse>();
        private List<TextbookBelongCourse> TextbookBelongCourseList = new List<TextbookBelongCourse>();


        public CourseForm()
        {
            InitializeComponent();
            this.initView();
            this.initData();
        }

        private void initView() {
            //课程列表
            ColumnHeader chCourse = new ColumnHeader();
            chCourse.Text = "课程列表";   //设置列标题
            chCourse.Width = this.gbCourseList.Width-35;    //设置列宽度
            //MessageBox.Show();
            chCourse.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.lvCourse.Columns.Add(chCourse);    //将列头添加到ListView控件。
            this.lvCourse.FullRowSelect = true;  //选中整行
            //this.lvCourse.HeaderStyle = ColumnHeaderStyle.None;
            this.lvCourse.View = System.Windows.Forms.View.Details;

            //课程名
            //this.tbCourseName.Width = this.gbCourseInfo.Width - 20;
            //this.tbCourseName.BorderStyle = BorderStyle.None;
            //this.tbCourseName.BackColor=System.ConsoleColor.Win

            //执教老师
            ColumnHeader chTeacher = new ColumnHeader();
            chTeacher.Text = "执教老师";   //设置列标题
            chTeacher.Width = this.gbTeacher.Width - 35;    //设置列宽度
            chTeacher.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.lvTeacher.Columns.Add(chTeacher);    //将列头添加到ListView控件。
            this.lvTeacher.FullRowSelect = true;  //选中整行
            this.lvTeacher.HeaderStyle = ColumnHeaderStyle.None;
            this.lvTeacher.View = System.Windows.Forms.View.Details;

            //相关教材
            ColumnHeader chTextbook = new ColumnHeader();
            chTextbook.Text = "执教老师";   //设置列标题
            chTextbook.Width = this.gbTextbook.Width - 35;    //设置列宽度
            chTextbook.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.lvTextbook.Columns.Add(chTextbook);    //将列头添加到ListView控件。
            this.lvTextbook.FullRowSelect = true;  //选中整行
            this.lvTextbook.HeaderStyle = ColumnHeaderStyle.None;
            this.lvTextbook.View = System.Windows.Forms.View.Details;
            //未尽事项
        }

        /// <summary>
        /// 注意这个初始化的调用先后顺序是不能颠倒的
        /// </summary>
        private void initData()
        {
            //课程列表
            this.LvCourseInitData();
            //选中首个课程
            this.lvCourse.Items[0].Selected = true;
        }

        /// <summary>
        /// 刷新化课程列表数据
        /// </summary>
        private void LvCourseInitData()
        {
            string comText = "SELECT course.id, course.`name`, course.other FROM course";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, comText, null);
            if (!mySqlDataReader.HasRows)
            {
                return;
            }

            this.lvCourse.BeginUpdate();
            while (mySqlDataReader.Read())
            {
                Course course = new Course();
                course.Id = mySqlDataReader.GetString(0);
                course.Name = mySqlDataReader.GetString(1);
                course.Other = mySqlDataReader.GetString(2);
                lvCourse.Items.Add(course.Name);
                this.CourseList.Add(course);
            }
            mySqlDataReader.Close();
            this.lvCourse.EndUpdate();
        }

        /// <summary>
        /// 执教老师列表初始化
        /// </summary>
        /// <param name="courseId">当前选中的课程的ID</param>
        private void LvTeacherInitData(string courseId) {
            //连接查询
            String cmdText = "SELECT teacher.id,teacher.name FROM teacher_teach_course INNER JOIN course INNER JOIN teacher ON teacher_teach_course.uk_course_id = course.id AND teacher_teach_course.uk_teacher_id = teacher.id WHERE course.id = '"+courseId+"'";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, cmdText, null);
            if (!mySqlDataReader.HasRows)
            {
                return;
            }

            this.TeacherList.Clear();
            this.lvTeacher.BeginUpdate();
            this.lvTeacher.Items.Clear();
            while (mySqlDataReader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Name = mySqlDataReader.GetString(1);
                teacher.Id = mySqlDataReader.GetString(0);
                this.lvTeacher.Items.Add(teacher.Name);
                this.TeacherList.Add(teacher);
            }
            mySqlDataReader.Close();
            this.lvTeacher.EndUpdate();
        }

        /// <summary>
        /// 相关教材列表的初始化。
        /// </summary>
        /// <param name="courseId">课程ID</param>
        private void LvTextbookInitData(string courseId) {
            string cmdText = "SELECT textbook.id,textbook.`name` FROM textbook_belong_course INNER JOIN course INNER JOIN textbook ON textbook_belong_course.uk_course_id = course.id AND textbook_belong_course.uk_textbook_id = textbook.id WHERE course.id = @courseID";
            MySqlParameter mSqlPara = new MySqlParameter("@courseID",courseId);
            MySqlDataReader mSqlReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, cmdText, mSqlPara);
            if (!mSqlReader.HasRows)
            {
                return;
            }

            this.TextbookList.Clear();
            this.lvTextbook.BeginUpdate();
            this.lvTextbook.Items.Clear();
            while (mSqlReader.Read()) {
                Textbook textbook = new Textbook();
                textbook.Id = mSqlReader.GetString(0);
                textbook.Name = mSqlReader.GetString(1);
                TextbookList.Add(textbook);
                lvTextbook.Items.Add(textbook.Name);
            }
            mSqlReader.Close();
            this.lvTextbook.EndUpdate();

        }

        private void CourseForm_Shown(object sender, EventArgs e)
        {
            //我们先去做核心功能。
            /*
            string sql = "SELECT * FROM account";
            MySqlDataReader mySqlDataReader = OperateDB.QueryAll(sql);
            if (!mySqlDataReader.HasRows)
            {
                return;
            }
            while (mySqlDataReader.Read())
            {
                string id = mySqlDataReader.GetString(0);
                Console.WriteLine(id);
            }


            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.Show();
            */
        }

        private void btnRefreshCourse_Click(object sender, EventArgs e)
        {
            this.lvCourse.Items.Clear();
            this.LvCourseInitData();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (!this.btnLeft.Text.Equals("编辑")) {
                MessageBox.Show("正处于编辑状态");
                return;
            }

            this.lvCourse.BeginUpdate();
            this.lvCourse.Items.Add("课程名");
            this.lvCourse.EndUpdate();


            this.tbCourseName.Text = "";
            this.tbCourseName.ReadOnly = false;
            this.lvTeacher.Items.Clear();
            this.lvTextbook.Items.Clear();
            this.rtbOther.Text = "";
            this.rtbOther.ReadOnly = false;
            this.changeEditPanel();
            this.tbCourseName.Focus();
        }

        private void lvCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvCourse.SelectedItems.Count == 0)
            {
                return;
            }
            else if (this.lvCourse.SelectedItems.Count > 1)
            {
                MessageBox.Show("选中了多堂课程");
                return;
            }
            //以下就是选中项为1项的情况了

            //获取选中课程的数据
            int selIndex = lvCourse.SelectedItems.IndexOf(lvCourse.SelectedItems[0]);
            Course course = this.CourseList[selIndex];

            this.LvTeacherInitData(course.Id);
            this.LvTextbookInitData(course.Id);

            this.tbCourseName.Text = course.Name;
            this.rtbOther.Text = course.Other;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.changeEditPanel();
        }

        /// <summary>
        /// 修改编辑面板
        /// </summary>
        private void changeEditPanel() {
            switch (this.btnLeft.Text)
            {
                case "编辑":
                    this.tbCourseName.ReadOnly = false;
                    this.lvTeacher.Height -= ViewGlobal.smallBtnHeight;
                    this.lvTextbook.Height -= ViewGlobal.smallBtnHeight;
                    this.rtbOther.ReadOnly = false;
                    this.btnRight.Enabled = false;
                    this.btnLeft.Text = "提交";
                    break;
                case "提交":
                    this.tbCourseName.ReadOnly = true;
                    this.lvTeacher.Height += ViewGlobal.smallBtnHeight;
                    this.lvTextbook.Height += ViewGlobal.smallBtnHeight;
                    this.rtbOther.ReadOnly = true;
                    this.btnRight.Enabled = true;
                    this.btnLeft.Text = "编辑";
                    break;
                default:
                    break;
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm(this.TeacherList);
            addTeacherForm.ShowDialog();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ProblemForm problemForm = new ProblemForm();
            problemForm.Show();
            this.Hide();
        }
    }
}
