using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry;

namespace ForAurora.Presenter.ImplViewReq
{
    public class ImplTextbookFormReq : ITextbookFormReq
    {
        public static ImplTextbookFormReq NewInstance()
        {
            return new ImplTextbookFormReq();
        }

        public void AddOneTextbook(Textbook textbook)
        {
            string insertSql = "INSERT INTO textbook(textbook.id,textbook.utc8_create,textbook.utc8_modify,textbook.other,textbook.`name`,textbook.uk_isbn,textbook.press,textbook.edition) VALUES (@id,@create,@modife,@other,@name,@isbn,@press,@edition)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", textbook.Id),
                    new MySqlParameter("@create", textbook.Create),
                    new MySqlParameter("@modife", textbook.Modify),
                    new MySqlParameter("@other", textbook.Other),
                    new MySqlParameter("@name", textbook.Name),
                    new MySqlParameter("@isbn", textbook.Uk_isbn),
                    new MySqlParameter("@press", textbook.Press),
                    new MySqlParameter("@edition", textbook.Edition));
            mySqlConnection.Close();
        }

        public void AddOneTextbookForCourse(TextbookBelongCourse tbc)
        {
            string insertSql = "INSERT INTO textbook_belong_course(textbook_belong_course.id,textbook_belong_course.utc8_create,textbook_belong_course.utc8_modify,textbook_belong_course.uk_textbook_id,textbook_belong_course.uk_course_id,textbook_belong_course.other)VALUES(@id, @create, @modife, @textbookId, @courseId, @other)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                   new MySqlParameter("@id", tbc.Id),
                   new MySqlParameter("@create", tbc.Create),
                   new MySqlParameter("@modife", tbc.Modify),
                   new MySqlParameter("@@textbookId", tbc.UkTextbookId),
                   new MySqlParameter("@courseId", tbc.UkCourseId),
                   new MySqlParameter("@other", tbc.Other));
            mySqlConnection.Close();
        }

        public void DelById(string currentCourseId, string[] textbookIDs)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM textbook_belong_course WHERE textbook_belong_course.uk_course_id = @uk_course_id AND textbook_belong_course.uk_textbook_id = @uk_textbook_id;";
            try
            {
                foreach (string textbookId in textbookIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@uk_course_id", currentCourseId),
                        new MySqlParameter("@uk_textbook_id", textbookId));
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
                mySqlTransaction.Rollback();
                mySqlConnection.Close();
                MessageBox.Show("操作失败，操作已回滚。");
            }
            finally
            {
                Console.WriteLine("操作成功，状态：" + mySqlConnection.State);
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlTransaction.Commit();
                    mySqlConnection.Close();
                }
            }
        }

        public void DelTextbookByIds(params string[] textbookIDs)
        {
            //throw new NotImplementedException();
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM textbook WHERE textbook.id = @textbookID";
            try
            {
                foreach (string textbookID in textbookIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@textbookID", textbookID));
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
                mySqlTransaction.Rollback();
                mySqlConnection.Close();
                MessageBox.Show("操作失败，操作已回滚。");
            }
            finally
            {
                Console.WriteLine("操作成功，状态：" + mySqlConnection.State);
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlTransaction.Commit();
                    mySqlConnection.Close();
                }
            }
        }

        public void UpdateOneTextbook(Textbook textbook)
        {
            string updateSql = "UPDATE textbook SET textbook.utc8_modify = @modife,textbook.other = @other,textbook.`name` = @name,textbook.uk_isbn = @isbn,textbook.press = @press,textbook.edition = @edition WHERE textbook.id = @id;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@modife", textbook.Modify),
                    new MySqlParameter("@other", textbook.Other),
                    new MySqlParameter("@name", textbook.Name),
                    new MySqlParameter("@isbn", textbook.Uk_isbn),
                    new MySqlParameter("@press", textbook.Press),
                    new MySqlParameter("@edition", textbook.Edition),
                    new MySqlParameter("@id", textbook.Id));
            mySqlConnection.Close();
        }
    }
}
