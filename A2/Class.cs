using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public enum type { Lecture, Tutorial, Practical, Workshop };
    class Class
    {
        public string unitCode { get; set; }
        public type type { get; set; }
    }
}
