namespace ForAurora.View
{
    partial class TextbookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextbookForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEdition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lableBookName = new System.Windows.Forms.Label();
            this.btnDelTextbook = new System.Windows.Forms.Button();
            this.btnAddTextbook = new System.Windows.Forms.Button();
            this.lvTextbook = new System.Windows.Forms.ListView();
            this.btnRefreshTextbook = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnEditTextbook = new System.Windows.Forms.Button();
            this.lvTextbookSel = new System.Windows.Forms.ListView();
            this.gbSelList = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.gbList.SuspendLayout();
            this.gbSelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(575, 303);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "完成";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEdition);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCancelSubmit);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.rtbOther);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbPress);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbISBN);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.lableBookName);
            this.groupBox3.Location = new System.Drawing.Point(336, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 287);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "教材详情";
            // 
            // tbEdition
            // 
            this.tbEdition.Location = new System.Drawing.Point(100, 115);
            this.tbEdition.Name = "tbEdition";
            this.tbEdition.Size = new System.Drawing.Size(172, 21);
            this.tbEdition.TabIndex = 14;
            this.tbEdition.Text = "版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "版  本";
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
            this.rtbOther.Location = new System.Drawing.Point(55, 178);
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(217, 74);
            this.rtbOther.TabIndex = 8;
            this.rtbOther.Text = "其他内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "其他内容";
            // 
            // tbPress
            // 
            this.tbPress.Location = new System.Drawing.Point(100, 86);
            this.tbPress.Name = "tbPress";
            this.tbPress.Size = new System.Drawing.Size(172, 21);
            this.tbPress.TabIndex = 6;
            this.tbPress.Text = "出版社";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "出版社";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(100, 57);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(172, 21);
            this.tbISBN.TabIndex = 3;
            this.tbISBN.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = " ISBN";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 21);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "书名";
            // 
            // lableBookName
            // 
            this.lableBookName.AutoSize = true;
            this.lableBookName.Location = new System.Drawing.Point(41, 31);
            this.lableBookName.Name = "lableBookName";
            this.lableBookName.Size = new System.Drawing.Size(41, 12);
            this.lableBookName.TabIndex = 0;
            this.lableBookName.Text = "书  名";
            // 
            // btnDelTextbook
            // 
            this.btnDelTextbook.AutoSize = true;
            this.btnDelTextbook.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTextbook.Location = new System.Drawing.Point(140, 178);
            this.btnDelTextbook.Name = "btnDelTextbook";
            this.btnDelTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnDelTextbook.TabIndex = 7;
            this.btnDelTextbook.UseVisualStyleBackColor = true;
            this.btnDelTextbook.Click += new System.EventHandler(this.btnDelTextbook_Click);
            // 
            // btnAddTextbook
            // 
            this.btnAddTextbook.AutoSize = true;
            this.btnAddTextbook.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTextbook.Location = new System.Drawing.Point(140, 139);
            this.btnAddTextbook.Name = "btnAddTextbook";
            this.btnAddTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnAddTextbook.TabIndex = 6;
            this.btnAddTextbook.UseVisualStyleBackColor = true;
            this.btnAddTextbook.Click += new System.EventHandler(this.btnAddTextbook_Click);
            // 
            // lvTextbook
            // 
            this.lvTextbook.BackColor = System.Drawing.SystemColors.Window;
            this.lvTextbook.Location = new System.Drawing.Point(6, 20);
            this.lvTextbook.Name = "lvTextbook";
            this.lvTextbook.Size = new System.Drawing.Size(128, 261);
            this.lvTextbook.TabIndex = 0;
            this.lvTextbook.UseCompatibleStateImageBehavior = false;
            this.lvTextbook.SelectedIndexChanged += new System.EventHandler(this.lvTextbook_SelectedIndexChanged);
            this.lvTextbook.DoubleClick += new System.EventHandler(this.lvTextbook_DoubleClick);
            // 
            // btnRefreshTextbook
            // 
            this.btnRefreshTextbook.AutoSize = true;
            this.btnRefreshTextbook.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTextbook.Location = new System.Drawing.Point(140, 256);
            this.btnRefreshTextbook.Name = "btnRefreshTextbook";
            this.btnRefreshTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshTextbook.TabIndex = 10;
            this.btnRefreshTextbook.UseVisualStyleBackColor = true;
            this.btnRefreshTextbook.Click += new System.EventHandler(this.btnRefreshTextbook_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnRefreshTextbook);
            this.gbList.Controls.Add(this.btnEditTextbook);
            this.gbList.Controls.Add(this.btnDelTextbook);
            this.gbList.Controls.Add(this.btnAddTextbook);
            this.gbList.Controls.Add(this.lvTextbook);
            this.gbList.Location = new System.Drawing.Point(159, 10);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(171, 287);
            this.gbList.TabIndex = 11;
            this.gbList.TabStop = false;
            this.gbList.Text = "教材列表";
            // 
            // btnEditTextbook
            // 
            this.btnEditTextbook.AutoSize = true;
            this.btnEditTextbook.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditTextbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditTextbook.Location = new System.Drawing.Point(140, 217);
            this.btnEditTextbook.Name = "btnEditTextbook";
            this.btnEditTextbook.Size = new System.Drawing.Size(23, 23);
            this.btnEditTextbook.TabIndex = 8;
            this.btnEditTextbook.UseVisualStyleBackColor = true;
            this.btnEditTextbook.Click += new System.EventHandler(this.btnEditTextbook_Click);
            // 
            // lvTextbookSel
            // 
            this.lvTextbookSel.BackColor = System.Drawing.SystemColors.Window;
            this.lvTextbookSel.Location = new System.Drawing.Point(6, 20);
            this.lvTextbookSel.Name = "lvTextbookSel";
            this.lvTextbookSel.Size = new System.Drawing.Size(128, 261);
            this.lvTextbookSel.TabIndex = 0;
            this.lvTextbookSel.UseCompatibleStateImageBehavior = false;
            this.lvTextbookSel.SelectedIndexChanged += new System.EventHandler(this.lvTextbookSel_SelectedIndexChanged);
            this.lvTextbookSel.DoubleClick += new System.EventHandler(this.lvTextbookSel_DoubleClick);
            // 
            // gbSelList
            // 
            this.gbSelList.Controls.Add(this.lvTextbookSel);
            this.gbSelList.Location = new System.Drawing.Point(13, 10);
            this.gbSelList.Name = "gbSelList";
            this.gbSelList.Size = new System.Drawing.Size(140, 287);
            this.gbSelList.TabIndex = 10;
            this.gbSelList.TabStop = false;
            this.gbSelList.Text = "已选择";
            // 
            // TextbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 336);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbSelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教材管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextbookForm_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.gbSelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelSubmit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lableBookName;
        private System.Windows.Forms.Button btnDelTextbook;
        private System.Windows.Forms.Button btnAddTextbook;
        private System.Windows.Forms.ListView lvTextbook;
        private System.Windows.Forms.Button btnRefreshTextbook;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnEditTextbook;
        private System.Windows.Forms.ListView lvTextbookSel;
        private System.Windows.Forms.GroupBox gbSelList;
        private System.Windows.Forms.TextBox tbEdition;
        private System.Windows.Forms.Label label1;
    }
}