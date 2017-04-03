namespace ForAurora.View
{
    partial class AddTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOffice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.btnRefreshTeacher = new System.Windows.Forms.Button();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnDelTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 287);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选择";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(128, 261);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshTeacher);
            this.groupBox2.Controls.Add(this.btnSearchTeacher);
            this.groupBox2.Controls.Add(this.btnEditTeacher);
            this.groupBox2.Controls.Add(this.btnDelTeacher);
            this.groupBox2.Controls.Add(this.btnAddTeacher);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 287);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "教师列表";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.Location = new System.Drawing.Point(6, 20);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(128, 261);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓    名";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 21);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "曹操";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "其他内容";
            // 
            // rtbOther
            // 
            this.rtbOther.Location = new System.Drawing.Point(55, 155);
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(217, 97);
            this.rtbOther.TabIndex = 8;
            this.rtbOther.Text = "";
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
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.AutoSize = true;
            this.btnSearchTeacher.BackgroundImage = global::ForAurora.Properties.Resources.search;
            this.btnSearchTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchTeacher.Location = new System.Drawing.Point(140, 216);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnSearchTeacher.TabIndex = 9;
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.AutoSize = true;
            this.btnEditTeacher.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditTeacher.Location = new System.Drawing.Point(140, 176);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnEditTeacher.TabIndex = 8;
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            // 
            // btnDelTeacher
            // 
            this.btnDelTeacher.AutoSize = true;
            this.btnDelTeacher.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTeacher.Location = new System.Drawing.Point(140, 136);
            this.btnDelTeacher.Name = "btnDelTeacher";
            this.btnDelTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnDelTeacher.TabIndex = 7;
            this.btnDelTeacher.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.AutoSize = true;
            this.btnAddTeacher.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTeacher.Location = new System.Drawing.Point(140, 96);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(23, 23);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.UseVisualStyleBackColor = true;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 336);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
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
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDelTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}