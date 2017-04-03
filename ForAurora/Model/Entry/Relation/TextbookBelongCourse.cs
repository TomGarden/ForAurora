using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    class TextbookBelongCourse
    {
        private string ukTextbookId;
        private string ukCourseId;

        public string UkTextbookId
        {
            get
            {
                return ukTextbookId;
            }

            set
            {
                ukTextbookId = value;
            }
        }

        public string UkCourseId
        {
            get
            {
                return ukCourseId;
            }

            set
            {
                ukCourseId = value;
            }
        }
    }
}
