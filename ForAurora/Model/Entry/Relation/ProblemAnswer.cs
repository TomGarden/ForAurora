using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    public class ProblemAnswer:Entry
    {
        private string uk_problem_id;
        private string content;
        private string source;

        public string ProblemId 
        {
            get
            {
                return uk_problem_id;
            }

            set
            {
                uk_problem_id = value;
            }
        }

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

        public string Source
        {
            get
            {
                return source;
            }

            set
            {
                source = value;
            }
        }
    }
}
