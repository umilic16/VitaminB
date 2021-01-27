using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Pub
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public List<Selling> Menu { get; set; }
    }
}
