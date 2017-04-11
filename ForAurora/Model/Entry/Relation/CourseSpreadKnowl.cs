using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    public class CourseSpreadKnowl:Entry
    {
        private string uk_knowkedge_point_id;
        private string uk_course_id;

        public string KnowlId
        {
            get
            {
                return uk_knowkedge_point_id;
            }

            set
            {
                uk_knowkedge_point_id = value;
            }
        }

        public string CourseId
        {
            get
            {
                return uk_course_id;
            }

            set
            {
                uk_course_id = value;
            }
        }
    }
}
