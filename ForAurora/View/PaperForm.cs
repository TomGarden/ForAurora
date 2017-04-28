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
    public partial class PaperForm : Form
    {
        private static PaperForm instance;
        private ClosePaper ClosePaper;
        private string closeStr = "def";
        private string exportPath;
        private int height;
        private PaperForm(ClosePaper ClosePaper)
        {
            InitializeComponent();
            this.ClosePaper = ClosePaper;
        }
        public static PaperForm getInstance(ClosePaper ClosePaper)
        {
            if (instance == null)
            {
                instance = new PaperForm(ClosePaper);
            }
            instance.Show();
            return instance;
        }

        private void PaperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
                this.ClosePaper(this.closeStr, this.exportPath);
        }

        public void AddChild(Form form)
        {
            form.TopLevel = false;
            form.Location = new Point(0, this.height);
            this.panelPaper.Controls.Add(form);
            form.Show();
            height += form.Height + 5;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //this.BrowserPathTextBox.Text = folderBrowserDialog.SelectedPath;
                this.closeStr = "btnExport";
                this.exportPath = folderBrowserDialog.SelectedPath;
                this.Close();

            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
