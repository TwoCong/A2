using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public enum Campus { Hobart, Launceston };
    public enum Category { Academic, Technical, Administrative, Casual };
    class Staff
    {
        public int Id {get; set; }
		public string FamilyName { get; set; }
		public string GivenName { get; set; }
		public string Title { get; set; }
        public Campus Campus { get; set; }
        public string Room { get; set; }
        public string Email { get; set; }
		public string Photo { get; set; }
        public Category Category { get; set; }
    }
}
