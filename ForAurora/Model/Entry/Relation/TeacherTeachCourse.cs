using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    class TeacherTeachCourse:Entry
    {
        private string ukTeacherId;
        private string ukCourseId;

        public string UkTeacherId
        {
            get
            {
                return ukTeacherId;
            }

            set
            {
                ukTeacherId = value;
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
