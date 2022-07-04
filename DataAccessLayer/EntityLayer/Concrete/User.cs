using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            Baskets = new HashSet<Basket>();
            Comments = new HashSet<Comment>();
            MessageFromUsers = new HashSet<Message>();
            MessageToUsers = new HashSet<Message>();
            Orders = new HashSet<Order>();
            UserOperationClaims = new HashSet<UserOperationClaim>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Mail { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Message> MessageFromUsers { get; set; }
        public virtual ICollection<Message> MessageToUsers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
