using ForAurora.Model.Entry.Single;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    /// <summary>
    /// 本类在实体problem之外有扩展了一个字段那就是试题类型名，方便后续调用
    /// </summary>
    public class ProblemWithTypeName : Problem
    {
        private string typeName;

        public string TypeName
        {
            get
            {
                return typeName;
            }

            set
            {
                typeName = value;
            }
        }
    }
}
