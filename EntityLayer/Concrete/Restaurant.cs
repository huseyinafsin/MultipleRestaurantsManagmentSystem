using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        //
        public string RestaurantName { get; set; }
        //
        public float RestaurantRating { get; set; }
        public string RestaurantDesc { get; set; }
        public string MinOrderPrice { get; set; }
        public bool RestaurantStatus { get; set; }



    }
}
