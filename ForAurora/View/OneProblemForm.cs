using ForAurora.Model.Entry.Single;
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
    public partial class OneProblemForm : Form
    {
        private Problem problem;
        public OneProblemForm(Problem problem)
        {
            InitializeComponent();

            this.problem = problem;
            this.rtxProblem.Text = problem.Content;
        }

        private void rtxProblem_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            rtxProblem.Height = e.NewRectangle.Height;

            this.btnAddToPage.Top = rtxProblem.Height + 8;

            this.Height = rtxProblem.Height + this.btnAddToPage.Height + 8 + rtxProblem.Top;
        }

        private void btnAddToPage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.problem.Content);
        }
    }
}
