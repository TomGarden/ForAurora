using ForAurora.Model;
using ForAurora.Model.Entry;
using MySql.Data.MySqlClient;
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
    public partial class AddTeacherForm : Form
    {
        private List<Teacher> TeacherList;

        public AddTeacherForm(List<Teacher> teacherList)
        {
            this.TeacherList = teacherList;
            InitializeComponent();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Id = Guid.NewGuid().ToString("N");
            teacher.Create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            teacher.Modify = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            teacher.Name = tbName.Text.Trim();
            teacher.Contact = tbContact.Text.Trim();
            teacher.Office = tbOffice.Text.Trim();
            teacher.Other = rtbOther.Text;

            string insertSql = "INSERT INTO teacher (teacher.id, teacher.utc8_create, teacher.utc8_modify, teacher.`name`, teacher.office, teacher.other, teacher.contact) VALUES (@ID,@Create,@Modify,@Name,@Office,@Other,@Contact)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();

            try
            {
                Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, insertSql,
                    new MySqlParameter("@ID", teacher.Id),
                    new MySqlParameter("@Create", teacher.Create),
                    new MySqlParameter("@Modify", teacher.Modify),
                    new MySqlParameter("@Name", teacher.Name),
                    new MySqlParameter("@Office", teacher.Office),
                    new MySqlParameter("@Other", teacher.Other),
                    new MySqlParameter("@Contact", teacher.Contact));

                Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, insertSql,
                    new MySqlParameter("@ID", Guid.NewGuid().ToString("N")),
                    new MySqlParameter("@Create", teacher.Create),
                    new MySqlParameter("@Modify", teacher.Modify),
                    new MySqlParameter("@Name", teacher.Name),
                    new MySqlParameter("@Office", teacher.Office),
                    new MySqlParameter("@Other", teacher.Other),
                    new MySqlParameter("@Contact", teacher.Contact));

                Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, insertSql,
                    new MySqlParameter("@ID", Guid.NewGuid().ToString("N")),
                    new MySqlParameter("@Create", teacher.Create),
                    new MySqlParameter("@Modify", teacher.Modify),
                    new MySqlParameter("@Name", teacher.Name),
                    new MySqlParameter("@Office", teacher.Office),
                    new MySqlParameter("@Other", teacher.Other),
                    new MySqlParameter("@Contact", teacher.Contact));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
                mySqlTransaction.Rollback();
                mySqlConnection.Close();
            }
            finally
            {
                Console.WriteLine("状态：" + mySqlConnection.State);
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlTransaction.Commit();
                    mySqlConnection.Close();
                }
            }
        }
    }
}
