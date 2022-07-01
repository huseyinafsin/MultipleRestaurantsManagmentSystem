using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class FoodAdded : BaseEntity, IEntity
    {
        public string FoodAddedName { get; set; }

        public int FoodID { get; set; }
        public Food Food { get; set; }
    }
}
