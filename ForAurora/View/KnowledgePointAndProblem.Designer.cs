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
            this.panelProblemGroup = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEditProblem = new System.Windows.Forms.Button();
            this.btnRefreshProblem = new System.Windows.Forms.Button();
            this.btnDelProblem = new System.Windows.Forms.Button();
            this.btnAddProblem = new System.Windows.Forms.Button();
            this.gbProblemInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbProblemOther = new System.Windows.Forms.RichTextBox();
            this.tbProblemType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProblemAnswer = new System.Windows.Forms.GroupBox();
            this.btnAnswerEdit = new System.Windows.Forms.Button();
            this.rtbAnswerOther = new System.Windows.Forms.RichTextBox();
            this.btnAnswerRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnswerDel = new System.Windows.Forms.Button();
            this.btnAnswerAdd = new System.Windows.Forms.Button();
            this.tbAnswerSRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.gbKnowledgePoint.SuspendLayout();
            this.gbProblem.SuspendLayout();
            this.gbProblemInfo.SuspendLayout();
            this.gbProblemAnswer.SuspendLayout();
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
            this.tvKnowlTree.BackColor = System.Drawing.SystemColors.Control;
            this.tvKnowlTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvKnowlTree.Location = new System.Drawing.Point(6, 20);
            this.tvKnowlTree.Name = "tvKnowlTree";
            this.tvKnowlTree.Size = new System.Drawing.Size(213, 483);
            this.tvKnowlTree.TabIndex = 0;
            this.tvKnowlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKnowlTree_AfterSelect);
            // 
            // gbProblem
            // 
            this.gbProblem.Controls.Add(this.panelProblemGroup);
            this.gbProblem.Controls.Add(this.comboBox1);
            this.gbProblem.Controls.Add(this.btnEditProblem);
            this.gbProblem.Controls.Add(this.btnRefreshProblem);
            this.gbProblem.Controls.Add(this.btnDelProblem);
            this.gbProblem.Controls.Add(this.btnAddProblem);
            this.gbProblem.Location = new System.Drawing.Point(243, 12);
            this.gbProblem.Name = "gbProblem";
            this.gbProblem.Size = new System.Drawing.Size(500, 538);
            this.gbProblem.TabIndex = 1;
            this.gbProblem.TabStop = false;
            this.gbProblem.Text = "题目";
            // 
            // panelProblemGroup
            // 
            this.panelProblemGroup.AutoScroll = true;
            this.panelProblemGroup.Location = new System.Drawing.Point(8, 23);
            this.panelProblemGroup.Name = "panelProblemGroup";
            this.panelProblemGroup.Size = new System.Drawing.Size(486, 480);
            this.panelProblemGroup.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 511);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 14;
            // 
            // btnEditProblem
            // 
            this.btnEditProblem.AutoSize = true;
            this.btnEditProblem.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnEditProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditProblem.Location = new System.Drawing.Point(177, 509);
            this.btnEditProblem.Name = "btnEditProblem";
            this.btnEditProblem.Size = new System.Drawing.Size(23, 23);
            this.btnEditProblem.TabIndex = 13;
            this.btnEditProblem.UseVisualStyleBackColor = true;
            this.btnEditProblem.Click += new System.EventHandler(this.btnEditProblem_Click);
            // 
            // btnRefreshProblem
            // 
            this.btnRefreshProblem.AutoSize = true;
            this.btnRefreshProblem.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnRefreshProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshProblem.Location = new System.Drawing.Point(240, 509);
            this.btnRefreshProblem.Name = "btnRefreshProblem";
            this.btnRefreshProblem.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshProblem.TabIndex = 12;
            this.btnRefreshProblem.UseVisualStyleBackColor = true;
            this.btnRefreshProblem.Click += new System.EventHandler(this.btnRefreshProblem_Click);
            // 
            // btnDelProblem
            // 
            this.btnDelProblem.AutoSize = true;
            this.btnDelProblem.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnDelProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelProblem.Location = new System.Drawing.Point(114, 509);
            this.btnDelProblem.Name = "btnDelProblem";
            this.btnDelProblem.Size = new System.Drawing.Size(23, 23);
            this.btnDelProblem.TabIndex = 11;
            this.btnDelProblem.UseVisualStyleBackColor = true;
            this.btnDelProblem.Click += new System.EventHandler(this.btnDelProblem_Click);
            // 
            // btnAddProblem
            // 
            this.btnAddProblem.AutoSize = true;
            this.btnAddProblem.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAddProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProblem.Location = new System.Drawing.Point(51, 509);
            this.btnAddProblem.Name = "btnAddProblem";
            this.btnAddProblem.Size = new System.Drawing.Size(23, 23);
            this.btnAddProblem.TabIndex = 10;
            this.btnAddProblem.UseVisualStyleBackColor = true;
            this.btnAddProblem.Click += new System.EventHandler(this.btnAddProblem_Click);
            // 
            // gbProblemInfo
            // 
            this.gbProblemInfo.Controls.Add(this.label3);
            this.gbProblemInfo.Controls.Add(this.rtbProblemOther);
            this.gbProblemInfo.Controls.Add(this.tbProblemType);
            this.gbProblemInfo.Controls.Add(this.label2);
            this.gbProblemInfo.Location = new System.Drawing.Point(749, 12);
            this.gbProblemInfo.Name = "gbProblemInfo";
            this.gbProblemInfo.Size = new System.Drawing.Size(303, 157);
            this.gbProblemInfo.TabIndex = 2;
            this.gbProblemInfo.TabStop = false;
            this.gbProblemInfo.Text = "题目详情";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "未尽事项";
            // 
            // rtbProblemOther
            // 
            this.rtbProblemOther.BackColor = System.Drawing.SystemColors.Control;
            this.rtbProblemOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbProblemOther.Location = new System.Drawing.Point(8, 61);
            this.rtbProblemOther.Name = "rtbProblemOther";
            this.rtbProblemOther.ReadOnly = true;
            this.rtbProblemOther.Size = new System.Drawing.Size(289, 90);
            this.rtbProblemOther.TabIndex = 2;
            this.rtbProblemOther.Text = "";
            // 
            // tbProblemType
            // 
            this.tbProblemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProblemType.Location = new System.Drawing.Point(65, 23);
            this.tbProblemType.Name = "tbProblemType";
            this.tbProblemType.ReadOnly = true;
            this.tbProblemType.Size = new System.Drawing.Size(232, 14);
            this.tbProblemType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "题目类型";
            // 
            // gbProblemAnswer
            // 
            this.gbProblemAnswer.Controls.Add(this.btnAnswerEdit);
            this.gbProblemAnswer.Controls.Add(this.rtbAnswerOther);
            this.gbProblemAnswer.Controls.Add(this.btnAnswerRefresh);
            this.gbProblemAnswer.Controls.Add(this.label6);
            this.gbProblemAnswer.Controls.Add(this.btnAnswerDel);
            this.gbProblemAnswer.Controls.Add(this.btnAnswerAdd);
            this.gbProblemAnswer.Controls.Add(this.tbAnswerSRC);
            this.gbProblemAnswer.Controls.Add(this.label5);
            this.gbProblemAnswer.Controls.Add(this.label4);
            this.gbProblemAnswer.Controls.Add(this.rtbAnswer);
            this.gbProblemAnswer.Location = new System.Drawing.Point(749, 175);
            this.gbProblemAnswer.Name = "gbProblemAnswer";
            this.gbProblemAnswer.Size = new System.Drawing.Size(303, 375);
            this.gbProblemAnswer.TabIndex = 3;
            this.gbProblemAnswer.TabStop = false;
            this.gbProblemAnswer.Text = "题目解析";
            // 
            // btnAnswerEdit
            // 
            this.btnAnswerEdit.AutoSize = true;
            this.btnAnswerEdit.BackgroundImage = global::ForAurora.Properties.Resources.edit;
            this.btnAnswerEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnswerEdit.Location = new System.Drawing.Point(180, 346);
            this.btnAnswerEdit.Name = "btnAnswerEdit";
            this.btnAnswerEdit.Size = new System.Drawing.Size(23, 23);
            this.btnAnswerEdit.TabIndex = 20;
            this.btnAnswerEdit.UseVisualStyleBackColor = true;
            // 
            // rtbAnswerOther
            // 
            this.rtbAnswerOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAnswerOther.Location = new System.Drawing.Point(6, 292);
            this.rtbAnswerOther.Name = "rtbAnswerOther";
            this.rtbAnswerOther.Size = new System.Drawing.Size(291, 48);
            this.rtbAnswerOther.TabIndex = 6;
            this.rtbAnswerOther.Text = "";
            // 
            // btnAnswerRefresh
            // 
            this.btnAnswerRefresh.AutoSize = true;
            this.btnAnswerRefresh.BackgroundImage = global::ForAurora.Properties.Resources.refresh;
            this.btnAnswerRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnswerRefresh.Location = new System.Drawing.Point(243, 346);
            this.btnAnswerRefresh.Name = "btnAnswerRefresh";
            this.btnAnswerRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnAnswerRefresh.TabIndex = 19;
            this.btnAnswerRefresh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "未尽事项";
            // 
            // btnAnswerDel
            // 
            this.btnAnswerDel.AutoSize = true;
            this.btnAnswerDel.BackgroundImage = global::ForAurora.Properties.Resources.delete;
            this.btnAnswerDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnswerDel.Location = new System.Drawing.Point(117, 346);
            this.btnAnswerDel.Name = "btnAnswerDel";
            this.btnAnswerDel.Size = new System.Drawing.Size(23, 23);
            this.btnAnswerDel.TabIndex = 18;
            this.btnAnswerDel.UseVisualStyleBackColor = true;
            // 
            // btnAnswerAdd
            // 
            this.btnAnswerAdd.AutoSize = true;
            this.btnAnswerAdd.BackgroundImage = global::ForAurora.Properties.Resources.add;
            this.btnAnswerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnswerAdd.Location = new System.Drawing.Point(54, 346);
            this.btnAnswerAdd.Name = "btnAnswerAdd";
            this.btnAnswerAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAnswerAdd.TabIndex = 17;
            this.btnAnswerAdd.UseVisualStyleBackColor = true;
            // 
            // tbAnswerSRC
            // 
            this.tbAnswerSRC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswerSRC.Location = new System.Drawing.Point(41, 253);
            this.tbAnswerSRC.Name = "tbAnswerSRC";
            this.tbAnswerSRC.Size = new System.Drawing.Size(256, 14);
            this.tbAnswerSRC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "来源";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "内容";
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAnswer.Location = new System.Drawing.Point(6, 37);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(291, 210);
            this.rtbAnswer.TabIndex = 4;
            this.rtbAnswer.Text = "";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KnowledgePointAndProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "知识点-题目";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KnowledgePointAndProblem_FormClosing);
            this.gbKnowledgePoint.ResumeLayout(false);
            this.gbKnowledgePoint.PerformLayout();
            this.gbProblem.ResumeLayout(false);
            this.gbProblem.PerformLayout();
            this.gbProblemInfo.ResumeLayout(false);
            this.gbProblemInfo.PerformLayout();
            this.gbProblemAnswer.ResumeLayout(false);
            this.gbProblemAnswer.PerformLayout();
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
        private System.Windows.Forms.Button btnEditProblem;
        private System.Windows.Forms.Button btnRefreshProblem;
        private System.Windows.Forms.Button btnDelProblem;
        private System.Windows.Forms.Button btnAddProblem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelProblemGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProblemType;
        private System.Windows.Forms.RichTextBox rtbProblemOther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAnswerSRC;
        private System.Windows.Forms.RichTextBox rtbAnswerOther;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnswerEdit;
        private System.Windows.Forms.Button btnAnswerRefresh;
        private System.Windows.Forms.Button btnAnswerDel;
        private System.Windows.Forms.Button btnAnswerAdd;
    }
}