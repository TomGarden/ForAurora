using ForAurora.View.Requirement;
using System;
using System.Collections.Generic;
using ForAurora.Model.Entry;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ForAurora.Presenter.ImplViewReq
{
    public class ImplCourseFormReq : ICourseFormReq
    {
        /// <summary>
        /// 更方便的获取实例，避免调用者对实例参数的关心
        /// </summary>
        /// <returns></returns>
        public static ImplCourseFormReq NewInstance()
        {
            return new ImplCourseFormReq();
        }

        public void AddOneCourse(Course course)
        {
            string insertSql = "INSERT INTO course(course.id,course.utc8_create,course.utc8_modify,course.other,course.`name`) VALUES(@id, @create, @modife, @other, @name)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", course.Id),
                    new MySqlParameter("@create", course.Create),
                    new MySqlParameter("@modife", course.Modify),
                    new MySqlParameter("@other", course.Other),
                    new MySqlParameter("@name", course.Name));
            mySqlConnection.Close();
        }

        public void DelCourseByIds(params string[] courseIDs)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM course WHERE course.id = @id;";
            try
            {
                foreach (string courseID in courseIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@id", courseID));
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

        public List<Course> QueryAllCourse()
        {
            List<Course> CourseList = new List<Course>();

            string comText = "SELECT course.id, course.`name`, course.other FROM course";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, comText, null);
            //if (!mySqlDataReader.HasRows)
            //{
            //    return CourseList;
            //}

            while (mySqlDataReader.Read())
            {
                Course course = new Course();
                course.Id = mySqlDataReader.GetString(0);
                course.Name = mySqlDataReader.GetString(1);
                course.Other = mySqlDataReader.GetString(2);
                CourseList.Add(course);
            }
            mySqlDataReader.Close();
            return CourseList;
        }

        public List<Teacher> QueryTeacherByCourse(string courseId)
        {
            List<Teacher> TeacherList = new List<Teacher>();
            //连接查询
            string cmdText = "SELECT teacher.id,teacher.name FROM teacher_teach_course INNER JOIN course INNER JOIN teacher ON teacher_teach_course.uk_course_id = course.id AND teacher_teach_course.uk_teacher_id = teacher.id WHERE course.id = @courseID";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, cmdText,
                new MySqlParameter("@courseID", courseId));

            while (mySqlDataReader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Name = mySqlDataReader.GetString(1);
                teacher.Id = mySqlDataReader.GetString(0);TeacherList.Add(teacher);
            }
            mySqlDataReader.Close();

            return TeacherList;
        }

        public List<Textbook> QueryTextbookByCourse(string courseId)
        {
            List<Textbook> TextbookList = new List<Textbook>();

            string cmdText = "SELECT textbook.id,textbook.`name` FROM textbook_belong_course INNER JOIN course INNER JOIN textbook ON textbook_belong_course.uk_course_id = course.id AND textbook_belong_course.uk_textbook_id = textbook.id WHERE course.id = @courseID";
            MySqlDataReader mSqlReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, cmdText, 
                new MySqlParameter("@courseID", courseId));

            while (mSqlReader.Read())
            {
                Textbook textbook = new Textbook();
                textbook.Id = mSqlReader.GetString(0);
                textbook.Name = mSqlReader.GetString(1);
                TextbookList.Add(textbook);
            }
            mSqlReader.Close();
            return TextbookList;
        }

        public void UpdateOneCourse(Course course)
        {
            string updateSql = "UPDATE course SET course.utc8_modify = @modife,course.other = @other,course.`name` = @name WHERE course.id = @id;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@modife", course.Modify),
                    new MySqlParameter("@other", course.Other),
                    new MySqlParameter("@name", course.Name),
                    new MySqlParameter("@id", course.Id));
            mySqlConnection.Close();
        }
    }
}
