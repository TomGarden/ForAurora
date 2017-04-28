using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
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
    public partial class KnowledgePointForm : Form
    {
        private AddKnowlPoint addKnowlPoint = null;
        private KnowledgePoint CurrentSelKnowl = null;
        private string courseId;
        public KnowledgePointForm(string courseId,AddKnowlPoint addKnowlPoint,KnowledgePoint CurrentSelKnowl)
        {
            InitializeComponent();
            this.CurrentSelKnowl = CurrentSelKnowl;
            this.addKnowlPoint = addKnowlPoint;
            this.courseId = courseId;

            //如果没有上层知识点，就只能是根节点了
            if (this.CurrentSelKnowl == null)
            {
                this.rbNotRoot.Hide();
                this.rbNotRoot.Checked = false;
                this.rbRoot.Checked = true;

            }
        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            KnowledgePoint knowl = new KnowledgePoint();
            knowl.Id = Guid.NewGuid().ToString("N");
            knowl.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            knowl.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            knowl.Name = this.tbKnowlName.Text.Trim();
            knowl.Other = this.rtbOther.Text;
            if (this.rbRoot.Checked) { knowl.UpperKnowlId = "root"; }
            if (this.rbNotRoot.Checked) { knowl.UpperKnowlId = this.CurrentSelKnowl.Id; }

            CourseSpreadKnowl courseSpreadKnowl = new CourseSpreadKnowl();
            courseSpreadKnowl.Id = Guid.NewGuid().ToString("N");
            courseSpreadKnowl.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            courseSpreadKnowl.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            courseSpreadKnowl.KnowlId = knowl.Id;
            courseSpreadKnowl.CourseId = this.courseId;
            this.addKnowlPoint(knowl, courseSpreadKnowl);

            this.Close();
        }
    }
}
