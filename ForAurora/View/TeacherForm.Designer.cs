namespace ForAurora.View
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.gbSelList = new System.Windows.Forms.GroupBox();
            this.lvTeacherSel = new System.Windows.Forms.ListView();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnRefreshTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnDelTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lvTeacher = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOffice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbSelList.SuspendLayout();
            this.gbList.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelList
            // 
            this.gbSelList.Controls.Add(this.lvTeacherSel);
            this.gbSelList.Location = new System.Drawing.Point(12, 12);
            this.gbSelList.Name = "gbSelList";
            this.gbSelList.Size = new System.Drawing.Size(140, 287);
            this.gbSelList.TabIndex = 2;
            this.gbSelList.TabStop = false;
            this.gbSelList.Text = "已选择";
            // 
            // lvTeacherSel
            // 
            this.lvTeacherSel.BackColor = System.Drawing.SystemColors.Window;
            this.lvTeacherSel.Location = new System.Drawing.Point(6, 20);
            this.lvTeacherSel.Name = "lvTeacherSel";
            this.lvTeacherSel.Size = new System.Drawing.Size(128, 261);
            this.lvTeacherSel.TabIndex = 0;
            this.lvTeacherSel.UseCompatibleStateImageBehavior = false;
            this.lvTeacherSel.SelectedIndexChanged += new System.EventHandler(this.lvTeacherSel_SelectedIndexChanged);
            this.lvTeacherSel.DoubleClick += new System.EventHandler(this.lvTeacherSel_DoubleClick);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnRefreshTeacher);
            this.gbList.Controls.Add(this.btnEditTeacher);
            this.gbList.Controls.Add(this.btnDelTeacher);
            this.gbList.Controls.Add(this.btnAddTeacher);
            this.gbList.Controls.Add(this.lvTeacher);
            this.gbList.Location = new System.Drawing.Point(158, 12);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(171, 287);
            this.gbList.TabIndex = 3;
            this.gbList.TabStop = false;
            this.gbList.Text = "教师列表";
            // 
            // btnRefreshTeacher
            // 
            this.btnRefreshTeacher.AutoSize = true;
            this.btnRefreshTeacher.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTeacher.Location = new System.Drawing.Point(140, 256);
            this.btnRefreshTeacher.Name = "btnRefreshTeacher";
            this.btnRefreshTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshTeacher.TabIndex = 10;
            this.btnRefreshTeacher.UseVisualStyleBackColor = true;
            this.btnRefreshTeacher.Click += new System.EventHandler(this.btnRefreshTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.AutoSize = true;
            this.btnEditTeacher.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditTeacher.Location = new System.Drawing.Point(140, 217);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnEditTeacher.TabIndex = 8;
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // btnDelTeacher
            // 
            this.btnDelTeacher.AutoSize = true;
            this.btnDelTeacher.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTeacher.Location = new System.Drawing.Point(140, 178);
            this.btnDelTeacher.Name = "btnDelTeacher";
            this.btnDelTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnDelTeacher.TabIndex = 7;
            this.btnDelTeacher.UseVisualStyleBackColor = true;
            this.btnDelTeacher.Click += new System.EventHandler(this.btnDelTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.AutoSize = true;
            this.btnAddTeacher.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTeacher.Location = new System.Drawing.Point(140, 139);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // lvTeacher
            // 
            this.lvTeacher.BackColor = System.Drawing.SystemColors.Window;
            this.lvTeacher.Location = new System.Drawing.Point(6, 20);
            this.lvTeacher.Name = "lvTeacher";
            this.lvTeacher.Size = new System.Drawing.Size(128, 261);
            this.lvTeacher.TabIndex = 0;
            this.lvTeacher.UseCompatibleStateImageBehavior = false;
            this.lvTeacher.SelectedIndexChanged += new System.EventHandler(this.lvTeacher_SelectedIndexChanged);
            this.lvTeacher.DoubleClick += new System.EventHandler(this.lvTeacher_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelSubmit);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.rtbOther);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbOffice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbContact);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(335, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 287);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "教师详情";
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Location = new System.Drawing.Point(164, 256);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(69, 23);
            this.btnCancelSubmit.TabIndex = 12;
            this.btnCancelSubmit.Text = "取消";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Visible = false;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(239, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbOther
            // 
            this.rtbOther.Location = new System.Drawing.Point(55, 155);
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(217, 97);
            this.rtbOther.TabIndex = 8;
            this.rtbOther.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "其他内容";
            // 
            // tbOffice
            // 
            this.tbOffice.Location = new System.Drawing.Point(100, 103);
            this.tbOffice.Name = "tbOffice";
            this.tbOffice.Size = new System.Drawing.Size(172, 21);
            this.tbOffice.TabIndex = 6;
            this.tbOffice.Text = "办公室";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "办 公 室";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(100, 65);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(172, 21);
            this.tbContact.TabIndex = 3;
            this.tbContact.Text = "曹操";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系方式";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 21);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "曹操";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓    名";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(574, 305);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "完成";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 336);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbSelList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherForm_FormClosing);
            this.gbSelList.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelList;
        private System.Windows.Forms.ListView lvTeacherSel;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.ListView lvTeacher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOffice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.Button btnRefreshTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDelTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancelSubmit;
    }
}