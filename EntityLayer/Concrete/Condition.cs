using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Condition : BaseEntity, IEntity
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}
