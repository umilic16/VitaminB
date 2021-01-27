using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Rating
    {
        public User User { get; set; }
        public object BeerOrPub { get; set; }
        public int Stars { get; set; }
    }
}
