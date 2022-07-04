using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Order
    {
        public int Id { get; set; }
        public int FoodCount { get; set; }
        public DateTime Date { get; set; }
        public int ConditionId { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }

        public virtual Condition Condition { get; set; }
        public virtual Food Food { get; set; }
        public virtual User User { get; set; }
    }
}
