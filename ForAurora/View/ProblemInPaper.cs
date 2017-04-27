using ForAurora.Model.Entry.Relation;
using ForAurora.View.Requirement;
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
    public partial class ProblemInPaper : Form
    {
        private ProblemWithTypeName problemWithTN;
        public ProblemInPaper(ProblemWithTypeName problemWithTN)
        {
            InitializeComponent();

            this.problemWithTN = problemWithTN;
            this.rtxContent.Text = problemWithTN.Content;
        }
    }
}
