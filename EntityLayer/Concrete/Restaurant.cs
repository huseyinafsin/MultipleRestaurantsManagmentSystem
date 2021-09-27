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
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantType { get; set; }
        public bool RestaurantStatus { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public List<Food> Foods { get; set; }
    }
}
