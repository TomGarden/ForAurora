using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForAurora.View;

namespace ForAurora
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Form mDialogForm = new MyDialog();
            //mDialogForm.ShowDialog();
            DialogResult dialogResult = MessageBox.Show("您希望成功登陆吗？", "登陆测试", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.Close();
                    ViewGlobal.courseForm.Show();
                    break;
                case DialogResult.No:
                    this.Close();
                    ViewGlobal.courseForm.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            View.ViewGlobal.courseForm.Close();
        }
    }
}
