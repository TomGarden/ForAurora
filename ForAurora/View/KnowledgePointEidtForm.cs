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
    public partial class KnowledgePointEidtForm : Form
    {
        private UpdateKnowlPoint updateKnowlPoint;
        private KnowledgePoint CurrentSelKnol;
        public KnowledgePointEidtForm(UpdateKnowlPoint updateKnowlPoint, KnowledgePoint CurrentSelKnol)
        {
            InitializeComponent();
            this.updateKnowlPoint = updateKnowlPoint;
            this.CurrentSelKnol = CurrentSelKnol;

            this.tbKnowlName.Text = this.CurrentSelKnol.Name;
            this.rtbOther.Text = this.CurrentSelKnol.Other;
        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.CurrentSelKnol.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.CurrentSelKnol.Name = this.tbKnowlName.Text.Trim();
            this.CurrentSelKnol.Other = this.rtbOther.Text;

            this.updateKnowlPoint(this.CurrentSelKnol);

            this.Close();
        }
    }
}
