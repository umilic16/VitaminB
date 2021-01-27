using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class User
    {
        public String username { get; set; }
        public String password { get; set; }
        public List<Rating> ratedBeers { get; set; }
        public List<Rating> ratedPubs { get; set; }
        public List<Beer> likedBeers { get; set; }
        public List<Pub> likedPubs { get; set; }
    }
}
