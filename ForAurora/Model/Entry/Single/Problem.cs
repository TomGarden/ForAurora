using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Single
{
    public class Problem:Entry
    {
        private string content;
        private string uk_problem_type_id;

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string TypeId
        {
            get
            {
                return uk_problem_type_id;
            }

            set
            {
                uk_problem_type_id = value;
            }
        }
    }
}
