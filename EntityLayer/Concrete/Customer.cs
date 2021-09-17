using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerType { get; set; }
        //
        public DateTime CustomerRegisterDate { get; set; }
        public string UserPicture { get; set; }
        public bool CustomerStatus { get; set; }


    }
}
