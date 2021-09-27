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
        public int BasketID { get; set; }
        public int FoodCount { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int FoodID { get; set; }
        public Food Food { get; set; }
    }
}
