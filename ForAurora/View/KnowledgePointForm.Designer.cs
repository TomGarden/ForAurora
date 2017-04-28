namespace ForAurora.View
{
    partial class KnowledgePointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgePointForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbKnowlName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.rbRoot = new System.Windows.Forms.RadioButton();
            this.rbNotRoot = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称:";
            // 
            // tbKnowlName
            // 
            this.tbKnowlName.Location = new System.Drawing.Point(49, 13);
            this.tbKnowlName.MaxLength = 64;
            this.tbKnowlName.Name = "tbKnowlName";
            this.tbKnowlName.Size = new System.Drawing.Size(223, 21);
            this.tbKnowlName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "备注:";
            // 
            // rtbOther
            // 
            this.rtbOther.Location = new System.Drawing.Point(28, 74);
            this.rtbOther.MaxLength = 255;
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(244, 142);
            this.rtbOther.TabIndex = 3;
            this.rtbOther.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(216, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Location = new System.Drawing.Point(154, 227);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(56, 23);
            this.btnCancelSubmit.TabIndex = 5;
            this.btnCancelSubmit.Text = "取消";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // rbRoot
            // 
            this.rbRoot.AutoSize = true;
            this.rbRoot.Location = new System.Drawing.Point(15, 230);
            this.rbRoot.Name = "rbRoot";
            this.rbRoot.Size = new System.Drawing.Size(59, 16);
            this.rbRoot.TabIndex = 6;
            this.rbRoot.Text = "根节点";
            this.rbRoot.UseVisualStyleBackColor = true;
            // 
            // rbNotRoot
            // 
            this.rbNotRoot.AutoSize = true;
            this.rbNotRoot.Checked = true;
            this.rbNotRoot.Location = new System.Drawing.Point(80, 230);
            this.rbNotRoot.Name = "rbNotRoot";
            this.rbNotRoot.Size = new System.Drawing.Size(47, 16);
            this.rbNotRoot.TabIndex = 7;
            this.rbNotRoot.TabStop = true;
            this.rbNotRoot.Text = "非根";
            this.rbNotRoot.UseVisualStyleBackColor = true;
            // 
            // KnowledgePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rbNotRoot);
            this.Controls.Add(this.rbRoot);
            this.Controls.Add(this.btnCancelSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbOther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKnowlName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KnowledgePointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "知识点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKnowlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancelSubmit;
        private System.Windows.Forms.RadioButton rbRoot;
        private System.Windows.Forms.RadioButton rbNotRoot;
    }
}