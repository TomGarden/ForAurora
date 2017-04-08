using ForAurora.Model;
using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForAurora.Model.Entry;
using ForAurora.Model.Entry.Relation;

namespace ForAurora.Presenter.ImplViewReq
{
    public class ImplTeacherFormReq : ITeacherFormReq
    {
        public static ITeacherFormReq NewInstance()
        {
            return new ImplTeacherFormReq();
        }

        public void AddOneTeacher(Teacher teacher)
        {
            string insertSql = "INSERT INTO teacher (teacher.id, teacher.utc8_create, teacher.utc8_modify, teacher.`name`, teacher.office, teacher.other, teacher.contact) VALUES (@ID,@Create,@Modify,@Name,@Office,@Other,@Contact)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection,CommandType.Text,insertSql,
                    new MySqlParameter("@ID", teacher.Id),
                    new MySqlParameter("@Create", teacher.Create),
                    new MySqlParameter("@Modify", teacher.Modify),
                    new MySqlParameter("@Name", teacher.Name),
                    new MySqlParameter("@Office", teacher.Office),
                    new MySqlParameter("@Other", teacher.Other),
                    new MySqlParameter("@Contact", teacher.Contact));
            mySqlConnection.Close();
        }

        public void AddOneTeacherForCourse(TeacherTeachCourse ttc)
        {
            string insertSql = "INSERT INTO teacher_teach_course (teacher_teach_course.id,teacher_teach_course.utc8_create,	teacher_teach_course.utc8_modify,	teacher_teach_course.uk_course_id,	teacher_teach_course.uk_teacher_id,	teacher_teach_course.other)VALUES	(@id,@create,@modife,@courseId,@teacherId,@other)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                   new MySqlParameter("@id", ttc.Id),
                   new MySqlParameter("@create", ttc.Create),
                   new MySqlParameter("@modife", ttc.Modify),
                   new MySqlParameter("@courseId", ttc.UkCourseId),
                   new MySqlParameter("@teacherId", ttc.UkTeacherId),
                   new MySqlParameter("@other", ttc.Other));
            mySqlConnection.Close();
        }

        public void DelById(string courseID, params string[] teacherIDs)
        {

            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM teacher_teach_course WHERE teacher_teach_course.uk_course_id = @uk_course_id AND teacher_teach_course.uk_teacher_id = @uk_teacher_id;";
            try
            {
                foreach(string teacherID in teacherIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@uk_course_id", courseID),
                        new MySqlParameter("@uk_teacher_id", teacherID));
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

        public void DelTeachersByIds(string[] teacherIDs)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM teacher WHERE teacher.id = @teacherID";
            try
            {
                foreach (string teacherID in teacherIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@teacherID", teacherID));
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

        public void UpdateOneTeacher(Teacher currentSelTeacher)
        {
            string updateSql = "UPDATE teacher SET teacher.`name` = @teacherName,teacher.contact = @teacherContact,teacher.office = @teacherOffice,teacher.other = @teacherOther,teacher.utc8_modify = @teacherModify WHERE teacher.id = @teacherID;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@teacherName", currentSelTeacher.Name),
                    new MySqlParameter("@teacherContact", currentSelTeacher.Contact),
                    new MySqlParameter("@teacherOffice", currentSelTeacher.Office),
                    new MySqlParameter("@teacherOther", currentSelTeacher.Other),
                    new MySqlParameter("@teacherModify", currentSelTeacher.Modify),
                    new MySqlParameter("@teacherID", currentSelTeacher.Id));
            mySqlConnection.Close();
        }
    }
}
