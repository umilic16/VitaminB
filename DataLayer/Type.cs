using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Type
    {
        public String Name { get; set; }
        public List<Subtype> SubTypes { get; set; }
    }
}
