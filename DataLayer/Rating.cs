using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Rating
    {
        public User user { get; set; }
        public object beerOrPub { get; set; }
        public int stars { get; set; }
    }
}
