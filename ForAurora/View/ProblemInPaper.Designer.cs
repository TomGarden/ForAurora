namespace ForAurora.View
{
    partial class ProblemInPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemInPaper));
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.btnAnswerDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxContent
            // 
            this.rtxContent.Location = new System.Drawing.Point(0, 0);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(454, 96);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "";
            // 
            // btnAnswerDel
            // 
            this.btnAnswerDel.AutoSize = true;
            this.btnAnswerDel.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnAnswerDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnswerDel.Location = new System.Drawing.Point(460, 36);
            this.btnAnswerDel.Name = "btnAnswerDel";
            this.btnAnswerDel.Size = new System.Drawing.Size(23, 23);
            this.btnAnswerDel.TabIndex = 19;
            this.btnAnswerDel.UseVisualStyleBackColor = true;
            // 
            // ProblemInPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 96);
            this.Controls.Add(this.btnAnswerDel);
            this.Controls.Add(this.rtxContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProblemInPaper";
            this.Text = "试卷-试题";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxContent;
        private System.Windows.Forms.Button btnAnswerDel;
    }
}