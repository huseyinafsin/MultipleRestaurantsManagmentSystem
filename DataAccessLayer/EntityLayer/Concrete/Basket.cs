using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Basket
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }

        public virtual Food Food { get; set; }
        public virtual User User { get; set; }
    }
}
