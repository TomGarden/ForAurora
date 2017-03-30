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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.gbCourseList = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbCroupInfo = new System.Windows.Forms.GroupBox();
            this.tvCourseName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOthrer = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbTextbook = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCourseList.SuspendLayout();
            this.gbCroupInfo.SuspendLayout();
            this.gbOthrer.SuspendLayout();
            this.gbTextbook.SuspendLayout();
            this.gbTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCourseList
            // 
            this.gbCourseList.Controls.Add(this.listView1);
            this.gbCourseList.Location = new System.Drawing.Point(12, 12);
            this.gbCourseList.Name = "gbCourseList";
            this.gbCourseList.Size = new System.Drawing.Size(225, 538);
            this.gbCourseList.TabIndex = 0;
            this.gbCourseList.TabStop = false;
            this.gbCourseList.Text = "课程列表";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(213, 498);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbCroupInfo
            // 
            this.gbCroupInfo.Controls.Add(this.tvCourseName);
            this.gbCroupInfo.Controls.Add(this.button2);
            this.gbCroupInfo.Controls.Add(this.button1);
            this.gbCroupInfo.Controls.Add(this.gbOthrer);
            this.gbCroupInfo.Controls.Add(this.gbTextbook);
            this.gbCroupInfo.Controls.Add(this.gbTeacher);
            this.gbCroupInfo.Controls.Add(this.label2);
            this.gbCroupInfo.Location = new System.Drawing.Point(263, 12);
            this.gbCroupInfo.Name = "gbCroupInfo";
            this.gbCroupInfo.Size = new System.Drawing.Size(509, 538);
            this.gbCroupInfo.TabIndex = 2;
            this.gbCroupInfo.TabStop = false;
            this.gbCroupInfo.Text = "课程详情";
            // 
            // tvCourseName
            // 
            this.tvCourseName.BackColor = System.Drawing.SystemColors.Control;
            this.tvCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCourseName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvCourseName.Location = new System.Drawing.Point(113, 57);
            this.tvCourseName.Name = "tvCourseName";
            this.tvCourseName.Size = new System.Drawing.Size(300, 22);
            this.tvCourseName.TabIndex = 9;
            this.tvCourseName.Text = "课程名";
            this.tvCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "编辑";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbOthrer
            // 
            this.gbOthrer.Controls.Add(this.richTextBox1);
            this.gbOthrer.Location = new System.Drawing.Point(50, 361);
            this.gbOthrer.Name = "gbOthrer";
            this.gbOthrer.Size = new System.Drawing.Size(408, 123);
            this.gbOthrer.TabIndex = 6;
            this.gbOthrer.TabStop = false;
            this.gbOthrer.Text = "未尽事项";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(396, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gbTextbook
            // 
            this.gbTextbook.Controls.Add(this.listView3);
            this.gbTextbook.Location = new System.Drawing.Point(288, 150);
            this.gbTextbook.Name = "gbTextbook";
            this.gbTextbook.Size = new System.Drawing.Size(170, 180);
            this.gbTextbook.TabIndex = 5;
            this.gbTextbook.TabStop = false;
            this.gbTextbook.Text = "相关教材";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(6, 24);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(158, 150);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.listView2);
            this.gbTeacher.Location = new System.Drawing.Point(50, 150);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(170, 180);
            this.gbTeacher.TabIndex = 3;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "执教老师";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 24);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(158, 150);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 1);
            this.label2.TabIndex = 2;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbCroupInfo);
            this.Controls.Add(this.gbCourseList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程";
            this.Shown += new System.EventHandler(this.CourseForm_Shown);
            this.gbCourseList.ResumeLayout(false);
            this.gbCroupInfo.ResumeLayout(false);
            this.gbCroupInfo.PerformLayout();
            this.gbOthrer.ResumeLayout(false);
            this.gbTextbook.ResumeLayout(false);
            this.gbTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCourseList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbCroupInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.GroupBox gbTextbook;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbOthrer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tvCourseName;
    }
}