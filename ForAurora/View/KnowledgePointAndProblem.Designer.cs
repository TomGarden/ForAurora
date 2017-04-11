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
            this.btnEditKnowl = new System.Windows.Forms.Button();
            this.btnRefreshKnowl = new System.Windows.Forms.Button();
            this.btnDelKnowl = new System.Windows.Forms.Button();
            this.btnAddKnowl = new System.Windows.Forms.Button();
            this.tvKnowlTree = new System.Windows.Forms.TreeView();
            this.gbProblem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbProblemInfo = new System.Windows.Forms.GroupBox();
            this.gbProblemAnswer = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbKnowledgePoint.SuspendLayout();
            this.gbProblem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKnowledgePoint
            // 
            this.gbKnowledgePoint.Controls.Add(this.btnEditKnowl);
            this.gbKnowledgePoint.Controls.Add(this.btnRefreshKnowl);
            this.gbKnowledgePoint.Controls.Add(this.btnDelKnowl);
            this.gbKnowledgePoint.Controls.Add(this.btnAddKnowl);
            this.gbKnowledgePoint.Controls.Add(this.tvKnowlTree);
            this.gbKnowledgePoint.Location = new System.Drawing.Point(12, 12);
            this.gbKnowledgePoint.Name = "gbKnowledgePoint";
            this.gbKnowledgePoint.Size = new System.Drawing.Size(225, 538);
            this.gbKnowledgePoint.TabIndex = 0;
            this.gbKnowledgePoint.TabStop = false;
            this.gbKnowledgePoint.Text = "知识点";
            // 
            // btnEditKnowl
            // 
            this.btnEditKnowl.AutoSize = true;
            this.btnEditKnowl.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditKnowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditKnowl.Location = new System.Drawing.Point(132, 509);
            this.btnEditKnowl.Name = "btnEditKnowl";
            this.btnEditKnowl.Size = new System.Drawing.Size(23, 23);
            this.btnEditKnowl.TabIndex = 9;
            this.btnEditKnowl.UseVisualStyleBackColor = true;
            this.btnEditKnowl.Click += new System.EventHandler(this.btnEditKnowl_Click);
            // 
            // btnRefreshKnowl
            // 
            this.btnRefreshKnowl.AutoSize = true;
            this.btnRefreshKnowl.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshKnowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshKnowl.Location = new System.Drawing.Point(195, 509);
            this.btnRefreshKnowl.Name = "btnRefreshKnowl";
            this.btnRefreshKnowl.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshKnowl.TabIndex = 8;
            this.btnRefreshKnowl.UseVisualStyleBackColor = true;
            this.btnRefreshKnowl.Click += new System.EventHandler(this.btnRefreshKnowl_Click);
            // 
            // btnDelKnowl
            // 
            this.btnDelKnowl.AutoSize = true;
            this.btnDelKnowl.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelKnowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelKnowl.Location = new System.Drawing.Point(69, 509);
            this.btnDelKnowl.Name = "btnDelKnowl";
            this.btnDelKnowl.Size = new System.Drawing.Size(23, 23);
            this.btnDelKnowl.TabIndex = 7;
            this.btnDelKnowl.UseVisualStyleBackColor = true;
            this.btnDelKnowl.Click += new System.EventHandler(this.btnDelKnowl_Click);
            // 
            // btnAddKnowl
            // 
            this.btnAddKnowl.AutoSize = true;
            this.btnAddKnowl.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddKnowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKnowl.Location = new System.Drawing.Point(6, 509);
            this.btnAddKnowl.Name = "btnAddKnowl";
            this.btnAddKnowl.Size = new System.Drawing.Size(23, 23);
            this.btnAddKnowl.TabIndex = 6;
            this.btnAddKnowl.UseVisualStyleBackColor = true;
            this.btnAddKnowl.Click += new System.EventHandler(this.btnAddKnowl_Click);
            // 
            // tvKnowlTree
            // 
            this.tvKnowlTree.Location = new System.Drawing.Point(6, 20);
            this.tvKnowlTree.Name = "tvKnowlTree";
            this.tvKnowlTree.Size = new System.Drawing.Size(213, 483);
            this.tvKnowlTree.TabIndex = 0;
            this.tvKnowlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKnowlTree_AfterSelect);
            // 
            // gbProblem
            // 
            this.gbProblem.Controls.Add(this.tabControl1);
            this.gbProblem.Controls.Add(this.button1);
            this.gbProblem.Controls.Add(this.button2);
            this.gbProblem.Controls.Add(this.button3);
            this.gbProblem.Controls.Add(this.button4);
            this.gbProblem.Location = new System.Drawing.Point(243, 12);
            this.gbProblem.Name = "gbProblem";
            this.gbProblem.Size = new System.Drawing.Size(500, 538);
            this.gbProblem.TabIndex = 1;
            this.gbProblem.TabStop = false;
            this.gbProblem.Text = "题目";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(270, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(333, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(207, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(144, 509);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 483);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KnowledgePointAndProblem_FormClosing);
            this.gbKnowledgePoint.ResumeLayout(false);
            this.gbKnowledgePoint.PerformLayout();
            this.gbProblem.ResumeLayout(false);
            this.gbProblem.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKnowledgePoint;
        private System.Windows.Forms.GroupBox gbProblem;
        private System.Windows.Forms.GroupBox gbProblemInfo;
        private System.Windows.Forms.GroupBox gbProblemAnswer;
        private System.Windows.Forms.TreeView tvKnowlTree;
        private System.Windows.Forms.Button btnRefreshKnowl;
        private System.Windows.Forms.Button btnDelKnowl;
        private System.Windows.Forms.Button btnAddKnowl;
        private System.Windows.Forms.Button btnEditKnowl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}