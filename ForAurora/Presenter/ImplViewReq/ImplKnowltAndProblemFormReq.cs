using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ForAurora.Presenter.ImplViewReq
{
    class ImplKnowltAndProblemFormReq: IKnowltAndProblemFormReq
    {
        public static ImplKnowltAndProblemFormReq NewInstance()
        {
            return new ImplKnowltAndProblemFormReq();
        }

        public void DelKnowlByID(string knowlID)
        {
            string delSql = "DELETE FROM knowledge_point WHERE knowledge_point.id = @knowlID;";
            Model.MySqlHelper.ExecuteNonQuery(Model.MySqlHelper.Conn, CommandType.Text, delSql,
                new MySqlParameter("@knowlID", knowlID));
        }

        //注意本次添加应该是一个事务，对两个表进行添加操作才对。
        public void InsertOneKnowl(KnowledgePoint knowlPoint, CourseSpreadKnowl courseSpreadKnowl)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string insertSql_knowledge_point = "INSERT INTO knowledge_point(knowledge_point.id,knowledge_point.utc8_create,knowledge_point.utc8_modify,knowledge_point.other,knowledge_point.`name`,knowledge_point.uk_upper_knowledge_point_id) VALUES (@id,@create,@modife,@other,@name,@upperId);";
            string insertSql_course_spread_knowledge_point = "INSERT INTO course_spread_knowledge_point(course_spread_knowledge_point.id,course_spread_knowledge_point.utc8_create,course_spread_knowledge_point.utc8_modify,course_spread_knowledge_point.other,course_spread_knowledge_point.uk_knowledge_point_id,course_spread_knowledge_point.uk_course_id)VALUES(@id,@create,@modife,@other,@knowlId,@courseId);";
            try
            {
                Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql_knowledge_point,
                    new MySqlParameter("@id", knowlPoint.Id),
                    new MySqlParameter("@create", knowlPoint.Create),
                    new MySqlParameter("@modife", knowlPoint.Modify),
                    new MySqlParameter("@other", knowlPoint.Other),
                    new MySqlParameter("@name", knowlPoint.Name),
                    new MySqlParameter("@upperId", knowlPoint.UpperKnowlId));

                Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql_course_spread_knowledge_point,
                    new MySqlParameter("@id", courseSpreadKnowl.Id),
                    new MySqlParameter("@create", courseSpreadKnowl.Create),
                    new MySqlParameter("@modife", courseSpreadKnowl.Modify),
                    new MySqlParameter("@other", courseSpreadKnowl.Other),
                    new MySqlParameter("@knowlId", courseSpreadKnowl.KnowlId),
                    new MySqlParameter("@courseId", courseSpreadKnowl.CourseId));
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

        public List<KnowledgePoint> QueryConnectKnowlBySuperID(string upperID)
        {
            List<KnowledgePoint> KnowlList = new List<KnowledgePoint>();
            //连接查询
            //string cmdText = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.uk_upper_knowledge_point_id FROM knowledge_point WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            string querySQL = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.other,knowledge_point.uk_upper_knowledge_point_id FROM course_spread_knowledge_point INNER JOIN knowledge_point ON course_spread_knowledge_point.uk_knowledge_point_id = knowledge_point.id WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@upperID", upperID));

            while (mySqlDataReader.Read())
            {
                KnowledgePoint KnowledgePoint = new KnowledgePoint();
                KnowledgePoint.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                KnowledgePoint.Name = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                KnowledgePoint.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                KnowledgePoint.UpperKnowlId = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                KnowlList.Add(KnowledgePoint);
            }
            mySqlDataReader.Close();

            return KnowlList;
        }


        public List<KnowledgePoint> QuerySingleKnowlBySuperID(string upperID)
        {
            List<KnowledgePoint> KnowlList = new List<KnowledgePoint>();
            //连接查询
            string querySQL = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.other,knowledge_point.uk_upper_knowledge_point_id FROM knowledge_point WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            //string querySQL = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.uk_upper_knowledge_point_id FROM course_spread_knowledge_point INNER JOIN knowledge_point ON course_spread_knowledge_point.uk_knowledge_point_id = knowledge_point.id WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@upperID", upperID));

            while (mySqlDataReader.Read())
            {
                KnowledgePoint KnowledgePoint = new KnowledgePoint();
                KnowledgePoint.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                KnowledgePoint.Name = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                KnowledgePoint.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                KnowledgePoint.UpperKnowlId = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                KnowlList.Add(KnowledgePoint);
            }
            mySqlDataReader.Close();

            return KnowlList;
        }

        public void UpdateOneKnowl(KnowledgePoint knowlPoint)
        {
            string updateSql = "UPDATE knowledge_point SET knowledge_point.utc8_modify = @modify,knowledge_point.other = @other,knowledge_point.`name` = @name WHERE knowledge_point.id = @id;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@modify", knowlPoint.Modify),
                    new MySqlParameter("@other", knowlPoint.Other),
                    new MySqlParameter("@name", knowlPoint.Name),
                    new MySqlParameter("@id", knowlPoint.Id));
            mySqlConnection.Close();
        }
    }
}
