using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserMail { get; set; }
        public DateTime UserRegisterDate { get; set; }
        public string UserPicture { get; set; }
        public bool UserStatus { get; set; }

        public int UserTypeID { get; set; }
        public UserType userType { get; set; }

        public List<UserAddress> UserAdresses { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Order> Orders { get; set; }
        public List<Message> Messages { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
