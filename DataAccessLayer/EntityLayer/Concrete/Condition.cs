using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Condition
    {
        public Condition()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
