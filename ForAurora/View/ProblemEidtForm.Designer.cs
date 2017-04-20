namespace ForAurora.View
{
    partial class ProblemEidtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemEidtForm));
            this.gbProblemContent = new System.Windows.Forms.GroupBox();
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.rtxOther = new System.Windows.Forms.RichTextBox();
            this.cbProblemType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.gbKnowl = new System.Windows.Forms.GroupBox();
            this.tvKnowl = new System.Windows.Forms.TreeView();
            this.gbProblemContent.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gbKnowl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProblemContent
            // 
            this.gbProblemContent.Controls.Add(this.rtxContent);
            this.gbProblemContent.Location = new System.Drawing.Point(176, 12);
            this.gbProblemContent.Name = "gbProblemContent";
            this.gbProblemContent.Size = new System.Drawing.Size(492, 347);
            this.gbProblemContent.TabIndex = 0;
            this.gbProblemContent.TabStop = false;
            this.gbProblemContent.Text = "试题内容";
            // 
            // rtxContent
            // 
            this.rtxContent.Location = new System.Drawing.Point(6, 24);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(480, 317);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "";
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.rtxOther);
            this.gbOther.Location = new System.Drawing.Point(176, 365);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(492, 99);
            this.gbOther.TabIndex = 1;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "未尽事项";
            // 
            // rtxOther
            // 
            this.rtxOther.Location = new System.Drawing.Point(6, 20);
            this.rtxOther.Name = "rtxOther";
            this.rtxOther.Size = new System.Drawing.Size(480, 73);
            this.rtxOther.TabIndex = 2;
            this.rtxOther.Text = "";
            // 
            // cbProblemType
            // 
            this.cbProblemType.FormattingEnabled = true;
            this.cbProblemType.Location = new System.Drawing.Point(18, 444);
            this.cbProblemType.Name = "cbProblemType";
            this.cbProblemType.Size = new System.Drawing.Size(146, 20);
            this.cbProblemType.TabIndex = 0;
            this.cbProblemType.SelectedIndexChanged += new System.EventHandler(this.cbProblemType_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(593, 480);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Location = new System.Drawing.Point(512, 480);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSubmit.TabIndex = 3;
            this.btnCancelSubmit.Text = "取消";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // gbKnowl
            // 
            this.gbKnowl.Controls.Add(this.tvKnowl);
            this.gbKnowl.Location = new System.Drawing.Point(12, 12);
            this.gbKnowl.Name = "gbKnowl";
            this.gbKnowl.Size = new System.Drawing.Size(158, 426);
            this.gbKnowl.TabIndex = 4;
            this.gbKnowl.TabStop = false;
            this.gbKnowl.Text = "包含知识点";
            // 
            // tvKnowl
            // 
            this.tvKnowl.CheckBoxes = true;
            this.tvKnowl.Location = new System.Drawing.Point(6, 24);
            this.tvKnowl.Name = "tvKnowl";
            this.tvKnowl.Size = new System.Drawing.Size(146, 396);
            this.tvKnowl.TabIndex = 0;
            this.tvKnowl.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvKnowl_AfterCheck);
            // 
            // ProblemEidtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 515);
            this.Controls.Add(this.gbKnowl);
            this.Controls.Add(this.btnCancelSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.cbProblemType);
            this.Controls.Add(this.gbProblemContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProblemEidtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProblemEidtForm_FormClosing);
            this.gbProblemContent.ResumeLayout(false);
            this.gbOther.ResumeLayout(false);
            this.gbKnowl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbProblemContent;
        private System.Windows.Forms.RichTextBox rtxContent;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.ComboBox cbProblemType;
        private System.Windows.Forms.RichTextBox rtxOther;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancelSubmit;
        private System.Windows.Forms.GroupBox gbKnowl;
        private System.Windows.Forms.TreeView tvKnowl;
    }
}