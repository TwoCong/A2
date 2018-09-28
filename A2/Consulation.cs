using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public enum day { Monday, Tuesday,Wednesday, Thursday, Friday, Saturday, Sunday }
    class Consulation
    {
        public int staffId { get; set; }
        public day day { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
