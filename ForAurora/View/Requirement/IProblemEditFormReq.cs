using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry.Single;

namespace ForAurora.View.Requirement
{
    public interface IProblemEditFormReq
    {
        //插入一个试题，在这同时插入试题和知识点的关联
        void InsertOneProblem(Problem problem, List<string> checkIDs);
        List<Model.Entry.Single.ProblemType> QueryAllType();
    }
}
