using System;
using System.Collections.Generic;
using ForAurora.Model.Entry.Single;
using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ForAurora.Presenter.ImplViewReq
{
    public class ImplProblemEditFormReq : IProblemEditFormReq
    {
        public static ImplProblemEditFormReq NewInstance()
        {
            return new ImplProblemEditFormReq();
        }

        public void InsertOneProblem(Problem problem, List<string> checkIDs)
        {
            //throw new NotImplementedException();
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string insertSql_problem = "INSERT INTO problem (problem.id,problem.utc8_create,problem.utc8_modify,problem.other,problem.content,problem.uk_problem_type_id) VALUES (@id,@create,@modife,@other,@content,@typeId);";
            string insertSql_knowledge_point_compose_problem = "INSERT INTO knowledge_point_compose_problem(knowledge_point_compose_problem.id,knowledge_point_compose_problem.utc8_create,knowledge_point_compose_problem.utc8_modify,knowledge_point_compose_problem.other,knowledge_point_compose_problem.uk_problem_id,knowledge_point_compose_problem.uk_knowledge_point_id) VALUES (@id,@create,@modife,@other,@problemId,@knowlIds);";
            try
            {
                Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql_problem,
                    new MySqlParameter("@id", problem.Id),
                    new MySqlParameter("@create", problem.Create),
                    new MySqlParameter("@modife", problem.Modify),
                    new MySqlParameter("@other", problem.Other),
                    new MySqlParameter("@content", problem.Content),
                    new MySqlParameter("@typeId", problem.TypeId));
                foreach (string checkId in checkIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql_knowledge_point_compose_problem,
                        new MySqlParameter("@id", Guid.NewGuid().ToString("N")),
                        new MySqlParameter("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new MySqlParameter("@modife", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new MySqlParameter("@other", null),
                        new MySqlParameter("@problemId", problem.Id),
                        new MySqlParameter("@knowlIds", checkIDs));
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

        public List<Model.Entry.Single.ProblemType> QueryAllType()
        {
            //throw new NotImplementedException();
            List<Model.Entry.Single.ProblemType> TypeList = new List<Model.Entry.Single.ProblemType>();

            string querySql = "SELECT problem_type.id,problem_type.`name`,problem_type.other FROM problem_type;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, null);


            while (mySqlDataReader.Read())
            {
                Model.Entry.Single.ProblemType type = new Model.Entry.Single.ProblemType();
                type.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                type.Name = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                type.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                TypeList.Add(type);
            }
            mySqlDataReader.Close();
            return TypeList;
        }
    }
}
