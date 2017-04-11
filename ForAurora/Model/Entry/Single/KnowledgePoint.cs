using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Single
{
    /// <summary>
    /// 知识点
    /// </summary>
    public class KnowledgePoint:Entry
    {
        private string name;
        private string uk_upper_knowledge_point_id;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string UpperKnowlId
        {
            get
            {
                return uk_upper_knowledge_point_id;
            }

            set
            {
                uk_upper_knowledge_point_id = value;
            }
        }
    }
}
