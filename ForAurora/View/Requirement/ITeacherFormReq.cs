using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry;
using ForAurora.Model.Entry.Relation;

namespace ForAurora.View.Requirement
{
    public interface ITeacherFormReq
    {
        /// <summary>
        /// 删除教师教授课程（teacher_teach_course）表的一条信息
        /// </summary>
        /// <param name="teacherID">教师ID</param>
        /// <param name="courseID">课程ID</param>
        void DelById(string courseID, params string[] teacherIDs);

        //向教师列表中添加新教师
        void AddOneTeacher(Teacher teacher);
        //修改老师
        void UpdateOneTeacher(Teacher currentSelTeacher);
        //为一堂课程添加一位老师
        void AddOneTeacherForCourse(TeacherTeachCourse ttc);
        /// <summary>
        /// 根据给定的ID数组删除Teacher表中的数据
        /// </summary>
        /// <param name="teacherIDs"></param>
        void DelTeachersByIds(string[] teacherIDs);
    }
}
