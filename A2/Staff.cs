using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public enum campus { Hobart, Launceston };
    public enum category { Academic, Technical, Administrative, Casual };
    class Staff
    {
        public int id {get; set; }
		public string familyName { get; set; }
		public string givenName { get; set; }
		public string title { get; set; }
        public campus campus { get; set; }
        public string room { get; set; }
        public string rmail { get; set; }
		public string photo { get; set; }
        public category category { get; set; }
    }
}
