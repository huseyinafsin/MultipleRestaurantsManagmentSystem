using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }
}
