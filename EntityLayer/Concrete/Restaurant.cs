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
    public class Restaurant : BaseEntity, IEntity
    {

        public string Name { get; set; }
        public string Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Food> Foods { get; set; }
    }
}
