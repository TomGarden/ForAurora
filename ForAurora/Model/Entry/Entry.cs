using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry
{
    /// <summary>
    /// 由于我们的数据具有一致性所以抽象出一个超类来管理几个字段
    /// </summary>
    public class Entry
    {
        private string id;
        private string utc8_create;
        private string utc8_modify;
        private string other;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Create
        {
            get
            {
                return utc8_create;
            }

            set
            {
                utc8_create = value;
            }
        }

        public string Modify
        {
            get
            {
                return utc8_modify;
            }

            set
            {
                utc8_modify = value;
            }
        }

        public string Other
        {
            get
            {
                return other;
            }

            set
            {
                other = value;
            }
        }
    }
}
