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
        public int UserType { get; set; }
        public DateTime UserRegisterDate { get; set; }
        public string UserPicture { get; set; }
        public bool UserStatus { get; set; }

        public List<UserAdress> userAdresses { get; set; }
        public List<Restaurant> restaurants { get; set; }
        public List<Order> orders { get; set; }
        public List<Message> messages { get; set; }
        public List<Comment> comments { get; set; }
        public List<Basket> baskets { get; set; }
    }
}
