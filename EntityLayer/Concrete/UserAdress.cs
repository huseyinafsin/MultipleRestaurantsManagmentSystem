using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserAdress
    {
        public int UserAdressID { get; set; }
        public string Adress { get; set; }

        public int UserID { get; set; }
        public User user { get; set; }

        public int LocationID { get; set; }
        public Location location { get; set; }
    }
}
