namespace ForAurora.View
{
    partial class ProblemTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemTypeForm));
            this.lvType = new System.Windows.Forms.ListView();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnRefreshType = new System.Windows.Forms.Button();
            this.btnDelType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.gbEidtPanel = new System.Windows.Forms.GroupBox();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbTypeOther = new System.Windows.Forms.RichTextBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.gbType.SuspendLayout();
            this.gbEidtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvType
            // 
            this.lvType.Location = new System.Drawing.Point(6, 20);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(188, 242);
            this.lvType.TabIndex = 0;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.SelectedIndexChanged += new System.EventHandler(this.lvType_SelectedIndexChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.btnEditType);
            this.gbType.Controls.Add(this.btnRefreshType);
            this.gbType.Controls.Add(this.btnDelType);
            this.gbType.Controls.Add(this.btnAddType);
            this.gbType.Controls.Add(this.lvType);
            this.gbType.Location = new System.Drawing.Point(12, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(200, 297);
            this.gbType.TabIndex = 1;
            this.gbType.TabStop = false;
            this.gbType.Text = "类型列表";
            // 
            // btnEditType
            // 
            this.btnEditType.AutoSize = true;
            this.btnEditType.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditType.Location = new System.Drawing.Point(116, 268);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(23, 23);
            this.btnEditType.TabIndex = 17;
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // btnRefreshType
            // 
            this.btnRefreshType.AutoSize = true;
            this.btnRefreshType.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshType.Location = new System.Drawing.Point(171, 268);
            this.btnRefreshType.Name = "btnRefreshType";
            this.btnRefreshType.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshType.TabIndex = 16;
            this.btnRefreshType.UseVisualStyleBackColor = true;
            this.btnRefreshType.Click += new System.EventHandler(this.btnRefreshType_Click);
            // 
            // btnDelType
            // 
            this.btnDelType.AutoSize = true;
            this.btnDelType.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelType.Location = new System.Drawing.Point(61, 268);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Size = new System.Drawing.Size(23, 23);
            this.btnDelType.TabIndex = 15;
            this.btnDelType.UseVisualStyleBackColor = true;
            this.btnDelType.Click += new System.EventHandler(this.btnDelType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.AutoSize = true;
            this.btnAddType.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddType.Location = new System.Drawing.Point(6, 268);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(23, 23);
            this.btnAddType.TabIndex = 14;
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // gbEidtPanel
            // 
            this.gbEidtPanel.Controls.Add(this.btnCancelSubmit);
            this.gbEidtPanel.Controls.Add(this.btnSubmit);
            this.gbEidtPanel.Controls.Add(this.rtbTypeOther);
            this.gbEidtPanel.Controls.Add(this.labelOther);
            this.gbEidtPanel.Controls.Add(this.tbTypeName);
            this.gbEidtPanel.Controls.Add(this.labelName);
            this.gbEidtPanel.Location = new System.Drawing.Point(218, 12);
            this.gbEidtPanel.Name = "gbEidtPanel";
            this.gbEidtPanel.Size = new System.Drawing.Size(261, 297);
            this.gbEidtPanel.TabIndex = 2;
            this.gbEidtPanel.TabStop = false;
            this.gbEidtPanel.Text = "编辑面板";
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Location = new System.Drawing.Point(125, 268);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(61, 23);
            this.btnCancelSubmit.TabIndex = 5;
            this.btnCancelSubmit.Text = "取消";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Visible = false;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(192, 268);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(61, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbTypeOther
            // 
            this.rtbTypeOther.Location = new System.Drawing.Point(53, 62);
            this.rtbTypeOther.Name = "rtbTypeOther";
            this.rtbTypeOther.Size = new System.Drawing.Size(202, 200);
            this.rtbTypeOther.TabIndex = 3;
            this.rtbTypeOther.Text = "";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(6, 62);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(41, 12);
            this.labelOther.TabIndex = 2;
            this.labelOther.Text = "其  他";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(53, 20);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(202, 21);
            this.tbTypeName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "名  称";
            // 
            // ProblemTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 321);
            this.Controls.Add(this.gbEidtPanel);
            this.Controls.Add(this.gbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProblemTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题类型编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProblemTypeForm_FormClosing);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbEidtPanel.ResumeLayout(false);
            this.gbEidtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbEidtPanel;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox rtbTypeOther;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnRefreshType;
        private System.Windows.Forms.Button btnDelType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancelSubmit;
    }
}