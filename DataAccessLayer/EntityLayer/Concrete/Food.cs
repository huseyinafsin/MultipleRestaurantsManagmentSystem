using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Food
    {
        public Food()
        {
            Addeds = new HashSet<Added>();
            Baskets = new HashSet<Basket>();
            Contents = new HashSet<Content>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Desc { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Added> Addeds { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
