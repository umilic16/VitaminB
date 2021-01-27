using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Brewery
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public List<Making> Beers { get; set; }
    }
}
