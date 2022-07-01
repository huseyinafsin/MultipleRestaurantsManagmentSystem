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
    public class User : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Mail { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Picture { get; set; }

        public List<UserAddress> UserAdresses { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Order> Orders { get; set; }
        public List<Message> Messages { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
