using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry.Relation;

namespace ForAurora.View.Requirement
{
    public interface IProblemInPaperReq
    {
        void InsertOneProblem(ProblemWithTypeName problemWithTN);
    }
}
