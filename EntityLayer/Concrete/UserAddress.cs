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
    public class UserAddress : BaseEntity, IEntity
    {

        public string Adress { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
