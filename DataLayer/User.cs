using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public List<Rating> RatedBeers { get; set; }
        public List<Rating> RatedPubs { get; set; }
        public List<Beer> LikedBeers { get; set; }
        public List<Pub> LikedPubs { get; set; }
    }
}
