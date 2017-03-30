namespace ForAurora
{
    partial class KnowledgePointAndProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgePointAndProblem));
            this.gbKnowledgePoint = new System.Windows.Forms.GroupBox();
            this.gbProblem = new System.Windows.Forms.GroupBox();
            this.gbProblemInfo = new System.Windows.Forms.GroupBox();
            this.gbProblemAnswer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbKnowledgePoint
            // 
            this.gbKnowledgePoint.Location = new System.Drawing.Point(12, 12);
            this.gbKnowledgePoint.Name = "gbKnowledgePoint";
            this.gbKnowledgePoint.Size = new System.Drawing.Size(225, 538);
            this.gbKnowledgePoint.TabIndex = 0;
            this.gbKnowledgePoint.TabStop = false;
            this.gbKnowledgePoint.Text = "知识点";
            // 
            // gbProblem
            // 
            this.gbProblem.Location = new System.Drawing.Point(243, 12);
            this.gbProblem.Name = "gbProblem";
            this.gbProblem.Size = new System.Drawing.Size(500, 538);
            this.gbProblem.TabIndex = 1;
            this.gbProblem.TabStop = false;
            this.gbProblem.Text = "题目";
            // 
            // gbProblemInfo
            // 
            this.gbProblemInfo.Location = new System.Drawing.Point(749, 12);
            this.gbProblemInfo.Name = "gbProblemInfo";
            this.gbProblemInfo.Size = new System.Drawing.Size(303, 157);
            this.gbProblemInfo.TabIndex = 2;
            this.gbProblemInfo.TabStop = false;
            this.gbProblemInfo.Text = "题目详情";
            // 
            // gbProblemAnswer
            // 
            this.gbProblemAnswer.Location = new System.Drawing.Point(749, 175);
            this.gbProblemAnswer.Name = "gbProblemAnswer";
            this.gbProblemAnswer.Size = new System.Drawing.Size(303, 375);
            this.gbProblemAnswer.TabIndex = 3;
            this.gbProblemAnswer.TabStop = false;
            this.gbProblemAnswer.Text = "题目解析";
            // 
            // KnowledgePointAndProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 562);
            this.Controls.Add(this.gbProblemAnswer);
            this.Controls.Add(this.gbProblemInfo);
            this.Controls.Add(this.gbProblem);
            this.Controls.Add(this.gbKnowledgePoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnowledgePointAndProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "知识点-题目";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKnowledgePoint;
        private System.Windows.Forms.GroupBox gbProblem;
        private System.Windows.Forms.GroupBox gbProblemInfo;
        private System.Windows.Forms.GroupBox gbProblemAnswer;
    }
}