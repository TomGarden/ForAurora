using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Utils
{
    public class StringUtil
    {
        /// <summary>
        /// 获取UUID
        /// </summary>
        /// <returns></returns>
        public static String GetUUID() {
            return Guid.NewGuid().ToString("N"); ;
        }
    }
}
