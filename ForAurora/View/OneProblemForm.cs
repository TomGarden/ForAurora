using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
using System;
using System.Windows.Forms;

namespace ForAurora.View
{
    public partial class OneProblemForm : Form
    {
        public ProblemWithTypeName cuProblemWithTN;
        private SelProblem selProblem;
        public OneProblemForm(ProblemWithTypeName problem, SelProblem selProblem)
        {
            InitializeComponent();

            this.cuProblemWithTN = problem;
            this.selProblem = selProblem;
            this.rtxProblem.Text = problem.Content;
        }

        private void rtxProblem_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            rtxProblem.Height = e.NewRectangle.Height;

            this.btnAddToPage.Top = rtxProblem.Height + 8;

            this.Height = rtxProblem.Height + this.btnAddToPage.Height + 8 + rtxProblem.Top;

            this.labelTip.Height = this.Height;


        }

        private void btnAddToPage_Click(object sender, EventArgs e)
        {
            this.FormFocus(true);
        }

        private void OneProblemForm_Click(object sender, EventArgs e)
        {
            this.FormFocus(false);
        }

        private void rtxProblem_Click(object sender, EventArgs e)
        {
            this.FormFocus(false);
        }
        private void FormFocus(bool isAddToPaper)
        {
            //MessageBox.Show("当前焦点窗口：" + this.problem.Content);
            this.selProblem(this, this.cuProblemWithTN, isAddToPaper);
        }

        public void SetFocus()
        {
            this.labelTip.BackColor = System.Drawing.Color.Black;
        }
        public void CancelFocus()
        {
            this.labelTip.BackColor = System.Drawing.Color.White;
        }
    }
}
