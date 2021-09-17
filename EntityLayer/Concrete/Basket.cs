using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        //
        //
        public int QTY { get; set; }
        public float UnitPrice { get; set; }
        public bool BasketStatus { get; set; }


    }
}
