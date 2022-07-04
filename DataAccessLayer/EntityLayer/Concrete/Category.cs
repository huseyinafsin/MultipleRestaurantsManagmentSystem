﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Category
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
