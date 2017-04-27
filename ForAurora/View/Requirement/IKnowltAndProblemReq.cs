using ForAurora.Model.Entry.Relation;
using ForAurora.Model.Entry.Single;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.View.Requirement
{
    public interface IKnowltAndProblemFormReq
    {
        //多表连接查询，主要用来查询根知识点
        List<KnowledgePoint> QueryConnectKnowlBySuperID(string super);
        //单表查询，主要用来查询子知识点
        List<KnowledgePoint> QuerySingleKnowlBySuperID(string super);
        void DelKnowlByID(string id);
        void InsertOneKnowl(KnowledgePoint knowlPoint, CourseSpreadKnowl courseSpreadKnowl);
        void UpdateOneKnowl(KnowledgePoint knowlPoint);
        List<ProblemWithTypeName> QueryAllProblems(string knowlId);
        //双条件进行查询按类型和知识点展示试题
        List<ProblemWithTypeName> QueryAllProblems(string knowlId,string typeId);
        //想试题表添加内容
        void InsertOneProblem(Problem problem, List<string> checkIDs);
        void DelOneProblem(string id);
        void EditOneProblem(Problem problem, List<string> oldKnowl, List<string> checkIDs);
        //查询试题ID所关联的知识点
        List<string> QueryKnowlByProblemId(string id);
        //根据试题ID查询答案
        List<ProblemAnswer> QueryOneAnswerByProblemId(string id);
        void DelAnswerById(string id);
        void InsertOneAnswer(ProblemAnswer pa);
        void UpdateOneAnswer(ProblemAnswer pa);
        List<ProblemType> QueryAllType();
        //向试题组成试卷表添加内容
        int InsertOneProblem(ProblemWithTypeName curSelProblemWithTN);
        void ClearPaper();
    }
}
