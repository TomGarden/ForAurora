using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry
{
    class Textbook:Entry
    {
        private string name;
        private string uk_isbn;
        private string press;
        private string edition;

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

        public string Uk_isbn
        {
            get
            {
                return uk_isbn;
            }

            set
            {
                uk_isbn = value;
            }
        }

        public string Press
        {
            get
            {
                return press;
            }

            set
            {
                press = value;
            }
        }

        public string Edition
        {
            get
            {
                return edition;
            }

            set
            {
                edition = value;
            }
        }
    }
}
