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
    class ImplKnowltAndProblemFormReq : IKnowltAndProblemFormReq
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

        //查询和本知识点相关的试题出来
        public List<ProblemWithTypeName> QueryAllProblems(string knowlId)
        {
            List<ProblemWithTypeName> ProblemList = new List<ProblemWithTypeName>();
            //包含题目类型
            string querySQL = "SELECT problem.id,problem.content,problem.other,problem.uk_problem_type_id,problem_type.`name` FROM knowledge_point_compose_problem INNER JOIN problem ON knowledge_point_compose_problem.uk_problem_id = problem.id       LEFT JOIN problem_type ON problem.uk_problem_type_id = problem_type.id WHERE knowledge_point_compose_problem.uk_knowledge_point_id = @knowlId;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@knowlId", knowlId));

            while (mySqlDataReader.Read())
            {
                ProblemWithTypeName pwt = new ProblemWithTypeName();
                pwt.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                pwt.Content = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                pwt.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                pwt.TypeId = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                pwt.TypeName = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(4);
                ProblemList.Add(pwt);

            }
            mySqlDataReader.Close();

            return ProblemList;
        }
        public List<ProblemWithTypeName> QueryAllProblems(string knowlId, string typeId)
        {
            List<ProblemWithTypeName> ProblemList = new List<ProblemWithTypeName>();
            //包含题目类型
            string querySQL = "SELECT problem.id,problem.content,problem.other,problem.uk_problem_type_id,problem_type.`name` FROM knowledge_point_compose_problem INNER JOIN problem ON knowledge_point_compose_problem.uk_problem_id = problem.id LEFT JOIN problem_type ON problem.uk_problem_type_id = problem_type.id WHERE knowledge_point_compose_problem.uk_knowledge_point_id = @knowlId AND problem.uk_problem_type_id = @typeId;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@knowlId", knowlId),
                new MySqlParameter("@typeId", typeId));

            while (mySqlDataReader.Read())
            {
                ProblemWithTypeName pwt = new ProblemWithTypeName();
                pwt.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                pwt.Content = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                pwt.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                pwt.TypeId = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                pwt.TypeName = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(4);
                ProblemList.Add(pwt);

            }
            mySqlDataReader.Close();

            return ProblemList;
        }

        //插入试题到试题表
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
                        new MySqlParameter("@knowlIds", checkId));
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
        //想试题组成试卷表添加内容
        public int InsertOneProblem(ProblemWithTypeName problemWithTN)
        {
            //throw new NotImplementedException();
            int result = -1;
            string insertSql = "INSERT INTO problem_compose_examination_papers(problem_compose_examination_papers.id,problem_compose_examination_papers.utc8_create,problem_compose_examination_papers.utc8_modify,problem_compose_examination_papers.other,problem_compose_examination_papers.uk_problem_id)	SELECT	@id, @create, @modife, @other, @problemId FROM  DUAL WHERE NOT EXISTS (SELECT * FROM problem_compose_examination_papers WHERE problem_compose_examination_papers.uk_problem_id = @problemId);";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            result = Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", Guid.NewGuid().ToString("N")),
                    new MySqlParameter("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new MySqlParameter("@modife", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new MySqlParameter("@other", null),
                    new MySqlParameter("@problemId", problemWithTN.Id));
            mySqlConnection.Close();
            return result;
        }

        public void EditOneProblem(Problem problem, List<string> oldKnowl, List<string> checkIDs)
        {
            //throw new NotImplementedException();
            //old需要删除
            //check需要添加
            //problem需要更新
            foreach (string old in oldKnowl)
            {
                foreach (string check in checkIDs)
                {
                    if (check.Equals(old))
                    {
                        oldKnowl.Remove(old);
                        checkIDs.Remove(check);
                    }
                }
            }

            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();


            string updateSql_problem = "UPDATE problem SET problem.utc8_modify = @modife,problem.content = @content,problem.other = @other,problem.uk_problem_type_id = @typeId WHERE problem.id = @id;";
            string delSql_knowl = "DELETE FROM knowledge_point_compose_problem WHERE knowledge_point_compose_problem.uk_problem_id = @problemId AND knowledge_point_compose_problem.uk_knowledge_point_id = @knowlId;";
            string insertSql_knowledge_point_compose_problem = "INSERT INTO knowledge_point_compose_problem(knowledge_point_compose_problem.id,knowledge_point_compose_problem.utc8_create,knowledge_point_compose_problem.utc8_modify,knowledge_point_compose_problem.other,knowledge_point_compose_problem.uk_problem_id,knowledge_point_compose_problem.uk_knowledge_point_id) VALUES (@id,@create,@modife,@other,@problemId,@knowlIds);";

            Console.WriteLine("*******");
            try
            {
                Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql_problem,
                    new MySqlParameter("@modife", problem.Modify),
                    new MySqlParameter("@content", problem.Content),
                    new MySqlParameter("@other", problem.Other),
                    new MySqlParameter("@typeId", problem.TypeId),
                    new MySqlParameter("@id", problem.Id));

                Console.WriteLine("更新");

                foreach (string old in oldKnowl)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, delSql_knowl,
                        new MySqlParameter("@problemId", problem.Id),
                        new MySqlParameter("@knowlId", old));
                }

                Console.WriteLine("删除");

                foreach (string checkId in checkIDs)
                {
                    Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql_knowledge_point_compose_problem,
                        new MySqlParameter("@id", Guid.NewGuid().ToString("N")),
                        new MySqlParameter("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new MySqlParameter("@modife", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new MySqlParameter("@other", null),
                        new MySqlParameter("@problemId", problem.Id),
                        new MySqlParameter("@knowlIds", checkId));
                }

                Console.WriteLine("添加");
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

        public void DelOneProblem(string problemId)
        {
            //throw new NotImplementedException();
            string delSql = "DELETE FROM problem WHERE problem.id = @problemId;";
            Model.MySqlHelper.ExecuteNonQuery(Model.MySqlHelper.Conn, CommandType.Text, delSql,
                new MySqlParameter("@problemId", problemId));
        }

        public List<KnowledgePoint> QueryConnectKnowlBySuperID(string upperID,string courseID)
        {
            List<KnowledgePoint> KnowlList = new List<KnowledgePoint>();
            //连接查询
            //string cmdText = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.uk_upper_knowledge_point_id FROM knowledge_point WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            //string querySQL = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.other,knowledge_point.uk_upper_knowledge_point_id FROM course_spread_knowledge_point INNER JOIN knowledge_point ON course_spread_knowledge_point.uk_knowledge_point_id = knowledge_point.id WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID;";
            string querySQL = "SELECT knowledge_point.id,knowledge_point.`name`,knowledge_point.other,knowledge_point.uk_upper_knowledge_point_id FROM course_spread_knowledge_point INNER JOIN knowledge_point ON course_spread_knowledge_point.uk_knowledge_point_id = knowledge_point.id WHERE knowledge_point.uk_upper_knowledge_point_id = @upperID AND course_spread_knowledge_point.uk_course_id = @courseId;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@upperID", upperID),
                new MySqlParameter("@courseId", courseID));

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

        //查询试题ID所关联的知识点
        public List<string> QueryKnowlByProblemId(string id)
        {
            //throw new NotImplementedException();
            List<string> idList = new List<string>();
            string querySQL = "SELECT knowledge_point_compose_problem.uk_knowledge_point_id FROM knowledge_point_compose_problem WHERE knowledge_point_compose_problem.uk_problem_id = @problemId";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@problemId", id));

            while (mySqlDataReader.Read())
            {
                if (!mySqlDataReader.IsDBNull(0))
                {
                    string knowlId = mySqlDataReader.GetString(0);
                    idList.Add(knowlId);
                }
            }
            mySqlDataReader.Close();

            return idList;
        }

        public List<ProblemAnswer> QueryOneAnswerByProblemId(string id)
        {
            //throw new NotImplementedException();
            List<ProblemAnswer> paList = new List<ProblemAnswer>();
            string querySQL = "SELECT problem_answer.id,problem_answer.content,problem_answer.other,problem_answer.source FROM problem_answer WHERE problem_answer.uk_problem_id = @problemId;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(
                Model.MySqlHelper.Conn, CommandType.Text, querySQL,
                new MySqlParameter("@problemId", id));

            while (mySqlDataReader.Read())
            {
                ProblemAnswer pa = new ProblemAnswer();
                pa.Id = mySqlDataReader.IsDBNull(0) ? "" : mySqlDataReader.GetString(0);
                pa.Content = mySqlDataReader.IsDBNull(1) ? "" : mySqlDataReader.GetString(1);
                pa.Other = mySqlDataReader.IsDBNull(2) ? "" : mySqlDataReader.GetString(2);
                pa.Source = mySqlDataReader.IsDBNull(3) ? "" : mySqlDataReader.GetString(3);
                paList.Add(pa);
            }
            mySqlDataReader.Close();

            return paList;
        }

        public void DelAnswerById(string id)
        {
            //throw new NotImplementedException();
            string delSql = "DELETE FROM problem_answer WHERE problem_answer.id = @answerId;";
            Model.MySqlHelper.ExecuteNonQuery(Model.MySqlHelper.Conn, CommandType.Text, delSql, new MySqlParameter("@answerId", id));
        }

        public void InsertOneAnswer(ProblemAnswer pa)
        {
            //throw new NotImplementedException();
            string insertSql = "INSERT INTO problem_answer (problem_answer.id,problem_answer.utc8_create,problem_answer.utc8_modify,problem_answer.other,problem_answer.uk_problem_id,problem_answer.content,problem_answer.source)VALUES (@id, @create, @modife, @other, @problemId, @content, @source)";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, insertSql,
                    new MySqlParameter("@id", pa.Id),
                    new MySqlParameter("@create", pa.Create),
                    new MySqlParameter("@modife", pa.Modify),
                    new MySqlParameter("@other", pa.Other),
                    new MySqlParameter("@problemId", pa.ProblemId),
                    new MySqlParameter("@content", pa.Content),
                    new MySqlParameter("@source", pa.Source));
            mySqlConnection.Close();
        }

        public void UpdateOneAnswer(ProblemAnswer pa)
        {
            throw new NotImplementedException();
            string updateSql = "UPDATE problem_answer SET problem_answer.utc8_modify = @modife,problem_answer.content = @content,problem_answer.source = @source,problem_answer.other= @other WHERE problem_answer.id = @answerId;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, updateSql,
                    new MySqlParameter("@modify", pa.Modify),
                    new MySqlParameter("@content", pa.Content),
                    new MySqlParameter("@source", pa.Source),
                    new MySqlParameter("@other", pa.Other),
                    new MySqlParameter("@answerId", pa.Id));
            mySqlConnection.Close();
        }
        //查询所有的试题类型
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

        public void ClearPaper()
        {
            string truncateSql = "TRUNCATE TABLE problem_compose_examination_papers;";
            MySqlConnection mySqlConnection = new MySqlConnection(Model.MySqlHelper.Conn);
            mySqlConnection.Open();
            Model.MySqlHelper.ExecuteNonQuery(mySqlConnection, CommandType.Text, truncateSql,null);
            mySqlConnection.Close();
        }

        public List<string> QueryAllPaper()
        {
            //throw new NotImplementedException();
            List<string> problemList = new List<string>();

            string querySql = "SELECT problem.content FROM problem_compose_examination_papers INNER JOIN problem ON problem_compose_examination_papers.uk_problem_id = problem.id ORDER BY problem.uk_problem_type_id;";
            MySqlDataReader mySqlDataReader = Model.MySqlHelper.ExecuteReader(Model.MySqlHelper.Conn, CommandType.Text, querySql, null);


            while (mySqlDataReader.Read())
            {
                if (!mySqlDataReader.IsDBNull(0))
                {
                    problemList.Add(mySqlDataReader.GetString(0));
                }
            }
            mySqlDataReader.Close();
            return problemList;
        }
    } 
}
