using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class FoodAdded 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FoodId { get; set; }
    }
}
