using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Food : BaseEntity, IEntity
    {
        public string  Name { get; set; }
        public float Price { get; set; }
        public string Desc { get; set; }

        public int CategoryID { get; set; }
        public FoodCategory Category { get; set; }

        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<Basket> Baskets { get; set; }
        public List<Order> Orders { get; set; }
        public List<FoodContent> Contents { get; set; }
        public List<FoodAdded> Addeds { get; set; }
    }
}
