using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry.Single;

namespace ForAurora.View.Requirement
{
    public interface IProblemTypeFormReq
    {
        void InsertOneType(ProblemType type);
        void UpdateOneType(ProblemType type);
        void DelTypeByIds(List<string> typeIDS);
    }
}
