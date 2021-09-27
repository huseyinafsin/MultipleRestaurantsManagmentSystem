using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserAddress
    {
        public int UserAdressID { get; set; }
        public string Adress { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
