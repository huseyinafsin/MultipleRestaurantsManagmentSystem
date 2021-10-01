using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FoodCondition
    {
        public int FoodConditionID { get; set; }
        public string FoodConditionName { get; set; }

        public List<Order> orders { get; set; }
    }
}
