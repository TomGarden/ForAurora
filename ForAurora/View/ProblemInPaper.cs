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
        private static ProblemInPaper instance;
        private ProblemInPaper()
        {
            InitializeComponent();
        }
        public static ProblemInPaper getInstance()
        {
            if (instance == null)
            {
                instance = new ProblemInPaper();
            }
            return instance;
        }


    }
}
