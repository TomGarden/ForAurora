using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAurora.Model.Entry;
using ForAurora.Model.Entry.Relation;

namespace ForAurora.View.Requirement
{
    public interface ITextbookFormReq
    {
        //根据课程ID和教材ID删除textbook_belong_course中的数据
        void DelById(string currentCourseId, params string[] textbookIDs);
        void AddOneTextbookForCourse(TextbookBelongCourse textbookBelongCourse);
        void DelTextbookByIds(params string[] textbookIDs);
        void AddOneTextbook(Textbook textbook);
        void UpdateOneTextbook(Textbook textbook);
    }
}
