namespace ForAurora.View
{
    partial class OneProblemForm
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
            this.rtxProblem = new System.Windows.Forms.RichTextBox();
            this.btnAddToPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxProblem
            // 
            this.rtxProblem.BackColor = System.Drawing.Color.White;
            this.rtxProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxProblem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxProblem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxProblem.Location = new System.Drawing.Point(3, 3);
            this.rtxProblem.Name = "rtxProblem";
            this.rtxProblem.ReadOnly = true;
            this.rtxProblem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxProblem.Size = new System.Drawing.Size(457, 129);
            this.rtxProblem.TabIndex = 0;
            this.rtxProblem.Text = "";
            this.rtxProblem.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtxProblem_ContentsResized);
            this.rtxProblem.Click += new System.EventHandler(this.rtxProblem_Click);
            // 
            // btnAddToPage
            // 
            this.btnAddToPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToPage.Location = new System.Drawing.Point(385, 138);
            this.btnAddToPage.Name = "btnAddToPage";
            this.btnAddToPage.Size = new System.Drawing.Size(75, 23);
            this.btnAddToPage.TabIndex = 1;
            this.btnAddToPage.Text = "添加到试卷";
            this.btnAddToPage.UseVisualStyleBackColor = true;
            this.btnAddToPage.Click += new System.EventHandler(this.btnAddToPage_Click);
            // 
            // OneProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 173);
            this.Controls.Add(this.btnAddToPage);
            this.Controls.Add(this.rtxProblem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneProblemForm";
            this.Text = "OneProblemForm";
            this.Click += new System.EventHandler(this.OneProblemForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxProblem;
        private System.Windows.Forms.Button btnAddToPage;
    }
}