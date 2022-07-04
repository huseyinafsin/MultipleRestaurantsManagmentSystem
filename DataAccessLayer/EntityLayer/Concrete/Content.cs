using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoodId { get; set; }

        public virtual Food Food { get; set; }
    }
}
