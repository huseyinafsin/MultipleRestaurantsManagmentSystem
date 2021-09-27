using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public string  FoodName { get; set; }
        public float FoodPrice { get; set; }
        public string FoodDesc { get; set; }
        public bool FoodStatus { get; set; }

        public int FoodCategoryID { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<Basket> Baskets { get; set; }
        public List<Order> Orders { get; set; }
    }
}
