using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    /// <summary>
    /// 试题组成试卷
    /// </summary>
    class ProblemComposePapers
    {
        //试题ID
        private string uk_problem_id;
        //试卷ID
        private string uk_examination_papers_id;

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

        public string PapersId 
        {
            get
            {
                return uk_examination_papers_id;
            }

            set
            {
                uk_examination_papers_id = value;
            }
        }
    }
}
