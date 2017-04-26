using ForAurora.Model.Entry.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForAurora.View
{
    public partial class AnswerEditForm : Form
    {
        private EditAnswer editeAnswer;
        public AnswerEditForm(EditAnswer editeAnswer)
        {
            InitializeComponent();

            this.editeAnswer = editeAnswer;
            this.rtbAnswer.Text = "试题解析";
            this.tbSrc.Text = "解析来源";
            this.rtbOther.Text = "未尽事项";
        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCubmit_Click(object sender, EventArgs e)
        {
            ProblemAnswer pa = new ProblemAnswer();
            pa.Content = this.rtbAnswer.Text;
            pa.Other = this.rtbOther.Text;
            pa.Source = this.tbSrc.Text;
            this.editeAnswer(pa);
            this.Close();
        }
    }
}
