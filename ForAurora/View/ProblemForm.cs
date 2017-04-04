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
    public partial class ProblemForm : Form
    {
        public ProblemForm()
        {
            InitializeComponent();
        }

        private void ProblemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ViewGlobal.courseForm.Show();
        }
    }
}
