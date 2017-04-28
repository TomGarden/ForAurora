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
using ForAurora.View.Requirement;
using ForAurora.Presenter.ImplViewReq;
using static System.Windows.Forms.ListView;

namespace ForAurora
{
    //我们通过委托完成窗口间通信的动作。
    public delegate void RefreshUI(string whichUI);

    /// <summary>
    /// 有必要保证ListView中的数据顺序和List<>中的数据顺序相同。
    /// </summary>
    public partial class CourseForm : Form
    {
        private ICourseFormReq ICourseFormReq = null;
        private ITeacherFormReq ITeacherFormReq = null;
        private ITextbookFormReq ITextbookFormReq = null;
        private List<Course> CourseList = new List<Course>();
        private List<Teacher> TeacherList = new List<Teacher>();
        private List<Textbook> TextbookList = new List<Textbook>();
        private List<TeacherTeachCourse> TeacherTeachCourseList = new List<TeacherTeachCourse>();
        private List<TextbookBelongCourse> TextbookBelongCourseList = new List<TextbookBelongCourse>();
        //记录当前正处于选中状态的课程。
        private Course CurrentlCourse = null;

        private string pleaseOperateOneCourse = "请尝试对“1”堂课程进行操作";
        private string btnEditStr = "编辑";
        private string btnSubmitStr = "提交";
        private string btnCancelStr = "取消";
        private string btnOpenStr = "打开";

        //private bool IsAdd = false;
        private bool IsEdit = false;


        public CourseForm()
        {
            InitializeComponent();
            this.initView();
            this.initData();
        }

        private void initView()
        {
            //课程列表
            if (this.lvCourse.Columns.Count <= 0)
            {
                ColumnHeader chCourse = new ColumnHeader();
                chCourse.Text = "课程列表";   //设置列标题
                chCourse.Width = this.gbCourseList.Width - 35;    //设置列宽度
                //MessageBox.Show();
                chCourse.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvCourse.Columns.Add(chCourse);    //将列头添加到ListView控件。
                this.lvCourse.FullRowSelect = true;  //选中整行
                this.lvCourse.HeaderStyle = ColumnHeaderStyle.None;
                this.lvCourse.View = System.Windows.Forms.View.Details;
            }

            //课程名
            //this.tbCourseName.Width = this.gbCourseInfo.Width - 20;
            //this.tbCourseName.BorderStyle = BorderStyle.None;
            //this.tbCourseName.BackColor=System.ConsoleColor.Win

            //执教老师
            if (this.lvTeacher.Columns.Count <= 0)
            {
                ColumnHeader chTeacher = new ColumnHeader();
                chTeacher.Text = "执教老师";   //设置列标题
                chTeacher.Width = this.gbTeacher.Width - 35;    //设置列宽度
                chTeacher.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTeacher.Columns.Add(chTeacher);    //将列头添加到ListView控件。
                this.lvTeacher.FullRowSelect = true;  //选中整行
                this.lvTeacher.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTeacher.View = System.Windows.Forms.View.Details;
            }

            //相关教材
            if (this.lvTextbook.Columns.Count <= 0)
            {
                ColumnHeader chTextbook = new ColumnHeader();
                chTextbook.Text = "执教老师";   //设置列标题
                chTextbook.Width = this.gbTextbook.Width - 35;    //设置列宽度
                chTextbook.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
                this.lvTextbook.Columns.Add(chTextbook);    //将列头添加到ListView控件。
                this.lvTextbook.FullRowSelect = true;  //选中整行
                this.lvTextbook.HeaderStyle = ColumnHeaderStyle.None;
                this.lvTextbook.View = System.Windows.Forms.View.Details;
            }
            //未尽事项
        }

        /// <summary>
        /// 注意这个初始化的调用先后顺序是不能颠倒的
        /// </summary>
        private void initData()
        {
            if (this.ICourseFormReq == null)
                this.ICourseFormReq = ImplCourseFormReq.NewInstance();
            if (this.ITeacherFormReq == null)
                this.ITeacherFormReq = ImplTeacherFormReq.NewInstance();
            if (this.ITextbookFormReq == null)
                this.ITextbookFormReq = ImplTextbookFormReq.NewInstance();
            //课程列表
            this.LvCourseInitData();
            //选中首个课程
            this.lvCourse.Items[0].Selected = true;
            this.CurrentlCourse = this.CourseList[0];
        }

        /// <summary>
        /// 刷新化课程列表数据
        /// </summary>
        private void LvCourseInitData()
        {
            this.CourseList = this.ICourseFormReq.QueryAllCourse();
            this.lvCourse.BeginUpdate();
            this.lvCourse.Items.Clear();
            foreach (Course course in this.CourseList)
            {
                lvCourse.Items.Add(course.Name);
            }
            this.lvCourse.EndUpdate();
        }

        /// <summary>
        /// 执教老师列表初始化
        /// </summary>
        /// <param name="courseId">当前选中的课程的ID</param>
        private void LvTeacherInitData(string courseId)
        {
            this.TeacherList = this.ICourseFormReq.QueryTeacherByCourse(courseId);
            this.lvTeacher.BeginUpdate();
            this.lvTeacher.Items.Clear();
            foreach (Teacher teacher in this.TeacherList)
            {
                this.lvTeacher.Items.Add(teacher.Name);
            }
            this.lvTeacher.EndUpdate();
        }

        /// <summary>
        /// 相关教材列表的初始化。
        /// </summary>
        /// <param name="courseId">课程ID</param>
        private void LvTextbookInitData(string courseId)
        {
            this.TextbookList = this.ICourseFormReq.QueryTextbookByCourse(courseId);
            this.lvTextbook.BeginUpdate();
            this.lvTextbook.Items.Clear();
            foreach (Textbook textbook in this.TextbookList)
            {
                this.lvTextbook.Items.Add(textbook.Name);
            }
            this.lvTextbook.EndUpdate();
        }

        private void btnRefreshCourse_Click(object sender, EventArgs e)
        {
            /*if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else*/ if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }
            this.initData();
        }

        //我们的添加也要走编辑的路线，所以取消走删除路线
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //if (this.IsAdd)
            //{
            //    MessageBox.Show("尚未添加完成");
            //    return;
            //}
             if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            //this.IsAdd = true;

            this.tbCourseName.Text = "课程名";
            this.tbCourseName.ReadOnly = false;
            this.lvTeacher.Items.Clear();
            this.lvTextbook.Items.Clear();
            this.rtbOther.Text = "";
            this.rtbOther.ReadOnly = false;
            this.tbCourseName.Focus();
            //this.changeEditPanel();
            this.tbCourseName.ReadOnly = false;
            this.lvTeacher.Height -= ViewGlobal.smallBtnHeight;
            this.lvTextbook.Height -= ViewGlobal.smallBtnHeight;
            this.rtbOther.ReadOnly = false;
            this.btnRight.Text = this.btnCancelStr;
            this.btnLeft.Text = this.btnSubmitStr;

            Course course = new Course();
            course.Id = Guid.NewGuid().ToString("N");
            course.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            course.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            course.Name = "有待完善";

            this.ICourseFormReq.AddOneCourse(course);

            this.CurrentlCourse = course;

            this.IsEdit = true;
        }

        private void lvCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvCourse.SelectedItems.Count == 0)
            {
                return;
            }

            /*if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else*/ if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            if (this.lvCourse.SelectedItems.Count > 1)
            {
                //选中多项目，就是一项都没有选中，先把右边的按钮设置为不可点击状态。
                //MessageBox.Show("选中了多堂课程");
                this.CurrentlCourse = null;
                this.tbCourseName.Text = "";
                this.rtbOther.Text = "";
                this.lvTeacher.Items.Clear();
                this.lvTextbook.Items.Clear();
                return;
            }
            //以下就是选中项为1项的情况了

            //获取选中课程的数据
            int selIndex = lvCourse.SelectedIndices[0];
            this.CurrentlCourse = this.CourseList[selIndex];

            this.LvTeacherInitData(this.CurrentlCourse.Id);
            this.LvTextbookInitData(this.CurrentlCourse.Id);

            this.tbCourseName.Text = this.CurrentlCourse.Name;
            this.rtbOther.Text = this.CurrentlCourse.Other;
            Console.WriteLine("当前选中的课程为：" + this.CurrentlCourse.Name);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (this.CurrentlCourse == null)
            {
                MessageBox.Show(pleaseOperateOneCourse);
                return;
            }

            switch (this.btnLeft.Text)
            {
                case "编辑":
                    this.tbCourseName.ReadOnly = false;
                    this.lvTeacher.Height -= ViewGlobal.smallBtnHeight;
                    this.lvTextbook.Height -= ViewGlobal.smallBtnHeight;
                    this.rtbOther.ReadOnly = false;
                    this.btnRight.Text = this.btnCancelStr;
                    this.btnLeft.Text = this.btnSubmitStr;
                    this.IsEdit = true;
                    break;
                case "提交":
                    Course course = new Course();
                    course.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    course.Name = tbCourseName.Text.Trim();
                    course.Other = rtbOther.Text.Trim();
                    //if (IsAdd)
                    //{
                    //    course.Id = Guid.NewGuid().ToString("N");
                    //    course.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    //    //MessageBox.Show("添加新客户才能");
                    //    this.ICourseFormReq.AddOneCourse(course);
                        
                    //    this.IsAdd = false;
                    //}
                    if (IsEdit)
                    {
                        course.Id = this.CurrentlCourse.Id;
                        //MessageBox.Show("修改课程");
                        this.ICourseFormReq.UpdateOneCourse(course);
                        this.IsEdit = false;
                    }
                    this.CourseInfo2OpenState();
                    //this.initView();
                    this.initData();
                    break;
            }
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            RefreshUI RefreshUI = new RefreshUI(this.RefreshUI);
            TeacherForm addTeacherForm = new TeacherForm(this.TeacherList, this.ITeacherFormReq, this.CurrentlCourse.Id, RefreshUI);
            addTeacherForm.ShowDialog();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this.CurrentlCourse == null)
            {
                MessageBox.Show(this.pleaseOperateOneCourse);
                return;
            }
            switch (this.btnRight.Text)
            {
                case "打开":
                    /*if (this.IsAdd)
                    {
                        MessageBox.Show("尚未添加完成");
                        return;
                    }
                    else*/ if (this.IsEdit)
                    {
                        MessageBox.Show("尚未编辑完成");
                        return;
                    }
                    KnowledgePointAndProblem knowlAndProblem = new KnowledgePointAndProblem(this.CurrentlCourse.Id);
                    knowlAndProblem.Show();
                    this.Hide();
                    break;
                case "取消":
                    //this.CourseInfo2OpenState();

                    this.tbCourseName.ReadOnly = true;
                    this.lvTeacher.Height += ViewGlobal.smallBtnHeight;
                    this.lvTextbook.Height += ViewGlobal.smallBtnHeight;
                    this.rtbOther.ReadOnly = true;
                    this.btnRight.Text = this.btnOpenStr;
                    this.btnLeft.Text = this.btnEditStr;

                    int currentIndex = this.CourseList.IndexOf(this.CurrentlCourse);
                    //this.IsAdd = false;
                    this.IsEdit = false;
                    this.lvCourse.Items[currentIndex].Selected = false;
                    this.lvCourse.Items[currentIndex].Selected = true;
                    break;
            }
        }

        /// <summary>
        /// 删除指定教师和当前课程的关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelTeacher_Click(object sender, EventArgs e)
        {

            if (this.lvTeacher.SelectedItems.Count <= 0)
            {
                MessageBox.Show("需要先选中教师才能删除。");
                return;
            }
            if (this.CurrentlCourse == null)
            {
                MessageBox.Show(ViewGlobal.ERROR);
            }

            string[] teacherIDs = new string[this.lvTeacher.SelectedItems.Count];
            for (int i = 0; i < teacherIDs.Length; i++)
            {
                teacherIDs[i] = this.TeacherList[this.lvTeacher.SelectedIndices[i]].Id;
            }
            this.ITeacherFormReq.DelById(this.CurrentlCourse.Id, teacherIDs);
            this.LvTeacherInitData(this.CurrentlCourse.Id);

        }

        private void btnRefreshTecher_Click(object sender, EventArgs e)
        {
            if (this.CurrentlCourse != null)
            {
                this.LvTeacherInitData(this.CurrentlCourse.Id);
            }
            else
            {
                MessageBox.Show(ViewGlobal.ERROR);
            }
        }

        /// <summary>
        /// 右侧课程详情UI转换为可以编辑的状态
        /// </summary>
        private void CourseInfo2EditState()
        {
            this.tbCourseName.ReadOnly = false;
            this.lvTeacher.Height -= ViewGlobal.smallBtnHeight;
            this.lvTextbook.Height -= ViewGlobal.smallBtnHeight;
            this.rtbOther.ReadOnly = false;
            this.btnRight.Text = this.btnCancelStr;
            this.btnLeft.Text = this.btnSubmitStr;
        }

        /// <summary>
        /// 右侧课程详情页UI转换为可以打开课程的状态
        /// </summary>
        private void CourseInfo2OpenState()
        {
            this.tbCourseName.ReadOnly = true;
            this.lvTeacher.Height += ViewGlobal.smallBtnHeight;
            this.lvTextbook.Height += ViewGlobal.smallBtnHeight;
            this.rtbOther.ReadOnly = true;
            this.btnRight.Text = this.btnOpenStr;
            this.btnLeft.Text = this.btnEditStr;
        }

        private void RefreshUI(string whichUI)
        {
            switch (whichUI)
            {
                case "Teacher":
                    if (this.CurrentlCourse != null)
                    {
                        this.LvTeacherInitData(this.CurrentlCourse.Id);
                    }
                    else
                    {
                        MessageBox.Show(ViewGlobal.ERROR);
                    }
                    break;
                case "Textbook":
                    if (this.CurrentlCourse != null)
                    {
                        this.LvTextbookInitData(this.CurrentlCourse.Id);
                    }
                    else
                    {
                        MessageBox.Show(ViewGlobal.ERROR);
                    }
                    break;
            }
            // MessageBox.Show("MessageBox");
        }

        private void btnAddTextbook_Click(object sender, EventArgs e)
        {
            RefreshUI RefreshUI = new RefreshUI(this.RefreshUI);
            TextbookForm addTextbookForm = new TextbookForm(this.TextbookList, this.ITextbookFormReq, this.CurrentlCourse.Id, RefreshUI);
            addTextbookForm.ShowDialog();
        }

        private void btnDelTextbook_Click(object sender, EventArgs e)
        {
            if (this.lvTextbook.SelectedItems.Count <= 0)
            {
                MessageBox.Show("需要先选中教材才能删除。");
                return;
            }
            if (this.CurrentlCourse == null)
            {
                MessageBox.Show(ViewGlobal.ERROR);
            }

            string[] textbookIDs = new string[this.lvTextbook.SelectedItems.Count];
            for (int i = 0; i < textbookIDs.Length; i++)
            {
                textbookIDs[i] = this.TextbookList[this.lvTextbook.SelectedIndices[i]].Id;
            }
            this.ITextbookFormReq.DelById(this.CurrentlCourse.Id, textbookIDs);
            this.LvTextbookInitData(this.CurrentlCourse.Id);
        }

        private void btnRefreshTextbook_Click(object sender, EventArgs e)
        {
            if (this.CurrentlCourse != null)
            {
                this.LvTextbookInitData(this.CurrentlCourse.Id);
            }
            else
            {
                MessageBox.Show(ViewGlobal.ERROR);
            }
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            /*if (this.IsAdd)
            {
                MessageBox.Show("尚未添加完成");
                return;
            }
            else*/ if (this.IsEdit)
            {
                MessageBox.Show("尚未编辑完成");
                return;
            }

            SelectedIndexCollection selectedItems = this.lvCourse.SelectedIndices;

            string[] courseIDs = new string[selectedItems.Count];
            for (int i = 0; i < selectedItems.Count; i++)
            {
                courseIDs[i] = this.CourseList[selectedItems[i]].Id;
            }
            this.ICourseFormReq.DelCourseByIds(courseIDs);

            this.initData();
        }

        public Course getCurrentCourse() {
            return CurrentlCourse;
        }
    }
}
