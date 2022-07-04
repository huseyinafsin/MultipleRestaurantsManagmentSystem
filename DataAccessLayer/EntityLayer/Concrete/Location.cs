using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Location
    {
        public Location()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
