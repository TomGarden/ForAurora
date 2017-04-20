namespace ForAurora
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.gbCourseList = new System.Windows.Forms.GroupBox();
            this.lvCourse = new System.Windows.Forms.ListView();
            this.contextMenuStrip_Course = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCourseInfo = new System.Windows.Forms.GroupBox();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.gbOthrer = new System.Windows.Forms.GroupBox();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.gbTextbook = new System.Windows.Forms.GroupBox();
            this.lvTextbook = new System.Windows.Forms.ListView();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.lvTeacher = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshTextbook = new System.Windows.Forms.Button();
            this.btnAddTextbook = new System.Windows.Forms.Button();
            this.btnDelTextbook = new System.Windows.Forms.Button();
            this.btnRefreshTecher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDelTeacher = new System.Windows.Forms.Button();
            this.btnRefreshCourse = new System.Windows.Forms.Button();
            this.btnDelCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.gbCourseList.SuspendLayout();
            this.contextMenuStrip_Course.SuspendLayout();
            this.gbCourseInfo.SuspendLayout();
            this.gbOthrer.SuspendLayout();
            this.gbTextbook.SuspendLayout();
            this.gbTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCourseList
            // 
            this.gbCourseList.Controls.Add(this.btnRefreshCourse);
            this.gbCourseList.Controls.Add(this.btnDelCourse);
            this.gbCourseList.Controls.Add(this.btnAddCourse);
            this.gbCourseList.Controls.Add(this.lvCourse);
            this.gbCourseList.Location = new System.Drawing.Point(12, 12);
            this.gbCourseList.Name = "gbCourseList";
            this.gbCourseList.Size = new System.Drawing.Size(225, 538);
            this.gbCourseList.TabIndex = 0;
            this.gbCourseList.TabStop = false;
            this.gbCourseList.Text = "课程列表";
            // 
            // lvCourse
            // 
            this.lvCourse.BackColor = System.Drawing.SystemColors.Window;
            this.lvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCourse.ContextMenuStrip = this.contextMenuStrip_Course;
            this.lvCourse.Location = new System.Drawing.Point(6, 34);
            this.lvCourse.Name = "lvCourse";
            this.lvCourse.Size = new System.Drawing.Size(213, 469);
            this.lvCourse.TabIndex = 0;
            this.lvCourse.UseCompatibleStateImageBehavior = false;
            this.lvCourse.SelectedIndexChanged += new System.EventHandler(this.lvCourse_SelectedIndexChanged);
            // 
            // contextMenuStrip_Course
            // 
            this.contextMenuStrip_Course.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程ToolStripMenuItem,
            this.修改课程ToolStripMenuItem,
            this.删除课程ToolStripMenuItem});
            this.contextMenuStrip_Course.Name = "contextMenuStrip_Course";
            this.contextMenuStrip_Course.Size = new System.Drawing.Size(125, 70);
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            // 
            // 修改课程ToolStripMenuItem
            // 
            this.修改课程ToolStripMenuItem.Name = "修改课程ToolStripMenuItem";
            this.修改课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改课程ToolStripMenuItem.Text = "修改课程";
            // 
            // 删除课程ToolStripMenuItem
            // 
            this.删除课程ToolStripMenuItem.Name = "删除课程ToolStripMenuItem";
            this.删除课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除课程ToolStripMenuItem.Text = "删除课程";
            // 
            // gbCourseInfo
            // 
            this.gbCourseInfo.Controls.Add(this.tbCourseName);
            this.gbCourseInfo.Controls.Add(this.btnLeft);
            this.gbCourseInfo.Controls.Add(this.btnRight);
            this.gbCourseInfo.Controls.Add(this.gbOthrer);
            this.gbCourseInfo.Controls.Add(this.gbTextbook);
            this.gbCourseInfo.Controls.Add(this.gbTeacher);
            this.gbCourseInfo.Controls.Add(this.label2);
            this.gbCourseInfo.Location = new System.Drawing.Point(263, 12);
            this.gbCourseInfo.Name = "gbCourseInfo";
            this.gbCourseInfo.Size = new System.Drawing.Size(509, 538);
            this.gbCourseInfo.TabIndex = 2;
            this.gbCourseInfo.TabStop = false;
            this.gbCourseInfo.Text = "课程详情";
            // 
            // tbCourseName
            // 
            this.tbCourseName.BackColor = System.Drawing.SystemColors.Control;
            this.tbCourseName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCourseName.Location = new System.Drawing.Point(113, 57);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.ReadOnly = true;
            this.tbCourseName.Size = new System.Drawing.Size(300, 29);
            this.tbCourseName.TabIndex = 9;
            this.tbCourseName.Text = "课程名";
            this.tbCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(347, 509);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "编辑";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(428, 509);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "打开";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // gbOthrer
            // 
            this.gbOthrer.Controls.Add(this.rtbOther);
            this.gbOthrer.Location = new System.Drawing.Point(50, 361);
            this.gbOthrer.Name = "gbOthrer";
            this.gbOthrer.Size = new System.Drawing.Size(408, 123);
            this.gbOthrer.TabIndex = 6;
            this.gbOthrer.TabStop = false;
            this.gbOthrer.Text = "未尽事项";
            // 
            // rtbOther
            // 
            this.rtbOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOther.Location = new System.Drawing.Point(6, 21);
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.ReadOnly = true;
            this.rtbOther.Size = new System.Drawing.Size(396, 96);
            this.rtbOther.TabIndex = 0;
            this.rtbOther.Text = "";
            // 
            // gbTextbook
            // 
            this.gbTextbook.Controls.Add(this.lvTextbook);
            this.gbTextbook.Controls.Add(this.btnRefreshTextbook);
            this.gbTextbook.Controls.Add(this.btnAddTextbook);
            this.gbTextbook.Controls.Add(this.btnDelTextbook);
            this.gbTextbook.Location = new System.Drawing.Point(288, 150);
            this.gbTextbook.Name = "gbTextbook";
            this.gbTextbook.Size = new System.Drawing.Size(170, 180);
            this.gbTextbook.TabIndex = 5;
            this.gbTextbook.TabStop = false;
            this.gbTextbook.Text = "相关教材";
            // 
            // lvTextbook
            // 
            this.lvTextbook.BackColor = System.Drawing.SystemColors.Control;
            this.lvTextbook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTextbook.Location = new System.Drawing.Point(6, 24);
            this.lvTextbook.Name = "lvTextbook";
            this.lvTextbook.Size = new System.Drawing.Size(158, 150);
            this.lvTextbook.TabIndex = 4;
            this.lvTextbook.UseCompatibleStateImageBehavior = false;
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.lvTeacher);
            this.gbTeacher.Controls.Add(this.btnRefreshTecher);
            this.gbTeacher.Controls.Add(this.btnAddTeacher);
            this.gbTeacher.Controls.Add(this.btnDelTeacher);
            this.gbTeacher.Location = new System.Drawing.Point(50, 150);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(170, 180);
            this.gbTeacher.TabIndex = 3;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "执教老师";
            // 
            // lvTeacher
            // 
            this.lvTeacher.BackColor = System.Drawing.SystemColors.Control;
            this.lvTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTeacher.Location = new System.Drawing.Point(6, 24);
            this.lvTeacher.Name = "lvTeacher";
            this.lvTeacher.Size = new System.Drawing.Size(158, 150);
            this.lvTeacher.TabIndex = 4;
            this.lvTeacher.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 1);
            this.label2.TabIndex = 2;
            // 
            // btnRefreshTextbook
            // 
            this.btnRefreshTextbook.AutoSize = true;
            this.btnRefreshTextbook.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTextbook.Location = new System.Drawing.Point(140, 151);
            this.btnRefreshTextbook.Name = "btnRefreshTextbook";
            this.btnRefreshTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshTextbook.TabIndex = 13;
            this.btnRefreshTextbook.UseVisualStyleBackColor = true;
            this.btnRefreshTextbook.Click += new System.EventHandler(this.btnRefreshTextbook_Click);
            // 
            // btnAddTextbook
            // 
            this.btnAddTextbook.AutoSize = true;
            this.btnAddTextbook.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTextbook.Location = new System.Drawing.Point(6, 151);
            this.btnAddTextbook.Name = "btnAddTextbook";
            this.btnAddTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnAddTextbook.TabIndex = 11;
            this.btnAddTextbook.UseVisualStyleBackColor = true;
            this.btnAddTextbook.Click += new System.EventHandler(this.btnAddTextbook_Click);
            // 
            // btnDelTextbook
            // 
            this.btnDelTextbook.AutoSize = true;
            this.btnDelTextbook.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTextbook.Location = new System.Drawing.Point(73, 151);
            this.btnDelTextbook.Name = "btnDelTextbook";
            this.btnDelTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnDelTextbook.TabIndex = 12;
            this.btnDelTextbook.UseVisualStyleBackColor = true;
            this.btnDelTextbook.Click += new System.EventHandler(this.btnDelTextbook_Click);
            // 
            // btnRefreshTecher
            // 
            this.btnRefreshTecher.AutoSize = true;
            this.btnRefreshTecher.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshTecher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTecher.Location = new System.Drawing.Point(140, 151);
            this.btnRefreshTecher.Name = "btnRefreshTecher";
            this.btnRefreshTecher.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshTecher.TabIndex = 10;
            this.btnRefreshTecher.UseVisualStyleBackColor = true;
            this.btnRefreshTecher.Click += new System.EventHandler(this.btnRefreshTecher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.AutoSize = true;
            this.btnAddTeacher.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTeacher.Location = new System.Drawing.Point(6, 151);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnDelTeacher
            // 
            this.btnDelTeacher.AutoSize = true;
            this.btnDelTeacher.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTeacher.Location = new System.Drawing.Point(73, 151);
            this.btnDelTeacher.Name = "btnDelTeacher";
            this.btnDelTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnDelTeacher.TabIndex = 7;
            this.btnDelTeacher.UseVisualStyleBackColor = true;
            this.btnDelTeacher.Click += new System.EventHandler(this.btnDelTeacher_Click);
            // 
            // btnRefreshCourse
            // 
            this.btnRefreshCourse.AutoSize = true;
            this.btnRefreshCourse.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshCourse.Location = new System.Drawing.Point(194, 509);
            this.btnRefreshCourse.Name = "btnRefreshCourse";
            this.btnRefreshCourse.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshCourse.TabIndex = 5;
            this.btnRefreshCourse.UseVisualStyleBackColor = true;
            this.btnRefreshCourse.Click += new System.EventHandler(this.btnRefreshCourse_Click);
            // 
            // btnDelCourse
            // 
            this.btnDelCourse.AutoSize = true;
            this.btnDelCourse.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelCourse.Location = new System.Drawing.Point(100, 509);
            this.btnDelCourse.Name = "btnDelCourse";
            this.btnDelCourse.Size = new System.Drawing.Size(23, 23);
            this.btnDelCourse.TabIndex = 2;
            this.btnDelCourse.UseVisualStyleBackColor = true;
            this.btnDelCourse.Click += new System.EventHandler(this.btnDelCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.AutoSize = true;
            this.btnAddCourse.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCourse.Location = new System.Drawing.Point(6, 509);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(23, 23);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbCourseInfo);
            this.Controls.Add(this.gbCourseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程";
            this.gbCourseList.ResumeLayout(false);
            this.gbCourseList.PerformLayout();
            this.contextMenuStrip_Course.ResumeLayout(false);
            this.gbCourseInfo.ResumeLayout(false);
            this.gbCourseInfo.PerformLayout();
            this.gbOthrer.ResumeLayout(false);
            this.gbTextbook.ResumeLayout(false);
            this.gbTextbook.PerformLayout();
            this.gbTeacher.ResumeLayout(false);
            this.gbTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCourseList;
        private System.Windows.Forms.ListView lvCourse;
        private System.Windows.Forms.GroupBox gbCourseInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.GroupBox gbTextbook;
        private System.Windows.Forms.ListView lvTextbook;
        private System.Windows.Forms.ListView lvTeacher;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox gbOthrer;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Course;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除课程ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDelCourse;
        private System.Windows.Forms.Button btnRefreshCourse;
        private System.Windows.Forms.Button btnRefreshTecher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDelTeacher;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRefreshTextbook;
        private System.Windows.Forms.Button btnAddTextbook;
        private System.Windows.Forms.Button btnDelTextbook;
    }
}