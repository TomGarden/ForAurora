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
            this.SuspendLayout();
            // 
            // rtxContent
            // 
            this.rtxContent.BackColor = System.Drawing.Color.White;
            this.rtxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxContent.Location = new System.Drawing.Point(4, 0);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxContent.Size = new System.Drawing.Size(477, 96);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "";
            this.rtxContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtxContent_ContentsResized);
            // 
            // ProblemInPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 96);
            this.Controls.Add(this.rtxContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProblemInPaper";
            this.Text = "试卷-试题";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxContent;
    }
}