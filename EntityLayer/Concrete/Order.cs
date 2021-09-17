using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        //
        public int UniqueKey { get; set; }
        //
        public DateTime OrderDate { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public double FinalPrice { get; set; }
        public bool OrderStatus { get; set; }



    }
}
