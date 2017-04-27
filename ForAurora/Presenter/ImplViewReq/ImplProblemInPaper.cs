using ForAurora.View.Requirement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    public class ImplProblemInPaper : IProblemInPaperReq
    {
        private static ImplProblemInPaper instance;
        private ImplProblemInPaper() { }
        public static ImplProblemInPaper getInstance()
        {
            if (instance == null)
            {
                instance = new ImplProblemInPaper();
            }
            return instance;
        }

        public void InsertOneProblem(ProblemWithTypeName problemWithTN)
        {
            //throw new NotImplementedException();
            string insertSql = "INSERT INTO problem_compose_examination_papers(problem_compose_examination_papers.id,problem_compose_examination_papers.utc8_create,problem_compose_examination_papers.utc8_modify,problem_compose_examination_papers.other,problem_compose_examination_papers.uk_problem_id)	VALUES	(@id, @create, @modife, @other, @problemId)WHERE NOT EXISTS (SELECT * FROM problem_compose_examination_papers WHERE problem_compose_examination_papers.uk_problem_id = @problemId);";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", Guid.NewGuid().ToString("N")),
                    new MySqlParameter("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new MySqlParameter("@modife", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new MySqlParameter("@other", null),
                    new MySqlParameter("@problemId", problemWithTN.Id),
                    new MySqlParameter("@problemId", problemWithTN.Id));
            mySqlConnection.Close();
        }
    }
}
