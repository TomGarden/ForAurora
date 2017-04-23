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
    }
}
