namespace ForAurora.View
{
    partial class AnswerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerEditForm));
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.btnCubmit = new System.Windows.Forms.Button();
            this.btnCancelSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Location = new System.Drawing.Point(12, 12);
            this.rtbAnswer.MaxLength = 500;
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(499, 175);
            this.rtbAnswer.TabIndex = 0;
            this.rtbAnswer.Text = "";
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(12, 194);
            this.tbSrc.MaxLength = 50;
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(499, 21);
            this.tbSrc.TabIndex = 1;
            // 
            // rtbOther
            // 
            this.rtbOther.Location = new System.Drawing.Point(12, 221);
            this.rtbOther.MaxLength = 255;
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(499, 57);
            this.rtbOther.TabIndex = 2;
            this.rtbOther.Text = "";
            // 
            // btnCubmit
            // 
            this.btnCubmit.Location = new System.Drawing.Point(436, 284);
            this.btnCubmit.Name = "btnCubmit";
            this.btnCubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCubmit.TabIndex = 3;
            this.btnCubmit.Text = "提交";
            this.btnCubmit.UseVisualStyleBackColor = true;
            this.btnCubmit.Click += new System.EventHandler(this.btnCubmit_Click);
            // 
            // btnCancelSubmit
            // 
            this.btnCancelSubmit.Location = new System.Drawing.Point(355, 284);
            this.btnCancelSubmit.Name = "btnCancelSubmit";
            this.btnCancelSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSubmit.TabIndex = 4;
            this.btnCancelSubmit.Text = "取消";
            this.btnCancelSubmit.UseVisualStyleBackColor = true;
            this.btnCancelSubmit.Click += new System.EventHandler(this.btnCancelSubmit_Click);
            // 
            // AnswerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 319);
            this.Controls.Add(this.btnCancelSubmit);
            this.Controls.Add(this.btnCubmit);
            this.Controls.Add(this.rtbOther);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.rtbAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnswerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题解析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.Button btnCubmit;
        private System.Windows.Forms.Button btnCancelSubmit;
    }
}