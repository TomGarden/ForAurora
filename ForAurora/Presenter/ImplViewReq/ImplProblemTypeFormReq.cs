using System;
using ForAurora.Model.Entry.Single;
using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ForAurora.Presenter.ImplViewReq
{
    public class ImplProblemTypeFormReq : IProblemTypeFormReq 
    {
        public static ImplProblemTypeFormReq NewInstance()
        {
            return new ImplProblemTypeFormReq();
        }

        public void DelTypeByIds(List<string> typeIDS)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            string delSql = "DELETE FROM problem_type WHERE problem_type.id = @id;";
            try
            {
                foreach (string typeID in typeIDS)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlTransaction, CommandType.Text, delSql,
                        new MySqlParameter("@id", typeID));
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

        public void InsertOneType(ProblemType type)
        {
            string insertSql = "INSERT INTO problem_type(problem_type.id,problem_type.utc8_create,problem_type.utc8_modify,problem_type.other,problem_type.`name`) VALUES (@id,@create,@modife,@other,@name);";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", type.Id),
                    new MySqlParameter("@create", type.Create),
                    new MySqlParameter("@modife", type.Modify),
                    new MySqlParameter("@other", type.Other),
                    new MySqlParameter("@name", type.Name));
            mySqlConnection.Close();
        }

        public void UpdateOneType(ProblemType type)
        {
            string updateSql = "UPDATE problem_type SET problem_type.utc8_modify = @modife,problem_type.other = @other,problem_type.`name` = @name WHERE problem_type.id = @id;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@modife", type.Modify),
                    new MySqlParameter("@other", type.Other),
                    new MySqlParameter("@name", type.Name),
                    new MySqlParameter("@id", type.Id));
            mySqlConnection.Close();
        }
    }
}
