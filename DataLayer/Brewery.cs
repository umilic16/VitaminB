using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Brewery
    {
        public String name { get; set; }
        public String address { get; set; }
        public String phone { get; set; }
        public List<Making> beers { get; set; }
    }
}
