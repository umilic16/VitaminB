using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Country
    {
        public String Name { get; set; }
        public List<Pub> Pubs { get; set; }
        public List<Brewery> Breweries { get; set; }
    }
}
