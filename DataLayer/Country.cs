using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Country
    {
        public String name { get; set; }
        public List<Pub> pubs { get; set; }
        public List<Brewery> breweries { get; set; }
    }
}
