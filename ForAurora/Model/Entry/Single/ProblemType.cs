using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Single
{
    public class ProblemType:Entry
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            if (name == null) { return ""; } else { return this.Name; }
        }
    }
}
