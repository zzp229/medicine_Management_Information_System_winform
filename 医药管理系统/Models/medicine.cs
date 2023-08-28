using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class medicine
    {
        private string mno;
        private string mname;
        private string mmode;
        private string mefficacy;

        public string Mno { get => mno; set => mno = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Mmode { get => mmode; set => mmode = value; }
        public string Mefficacy { get => mefficacy; set => mefficacy = value; }
    }
}
