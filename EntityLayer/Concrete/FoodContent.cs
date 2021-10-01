using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FoodContent
    {
        public int FoodContentID { get; set; }
        public string FoodContentName { get; set; }

        public int FoodID { get; set; }
        public Food food { get; set; }
    }
}
