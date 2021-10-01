using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FoodAdded
    {
        public int FoodAddedID { get; set; }
        public string FoodAddedName { get; set; }

        public int FoodID { get; set; }
        public Food food { get; set; }
    }
}
