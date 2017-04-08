using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry;

namespace ForAurora.View.Requirement
{
    public interface ICourseFormReq
    {
        /// <summary>
        /// 查询所有课程
        /// </summary>
        /// <returns></returns>
        List<Course> QueryAllCourse();

        /// <summary>
        /// 根据课程查询执教本课程的所有教师
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        List<Teacher> QueryTeacherByCourse(string courseId);

        /// <summary>
        /// 根据课程查询本课程所使用到的所有教科书
        /// </summary>
        /// <param name="courseList"></param>
        /// <returns></returns>
        List<Textbook> QueryTextbookByCourse(string courseId);
        void AddOneCourse(Course course);
        void UpdateOneCourse(Course course);
        void DelCourseByIds(params string[] courseIDs);
    }
}
