using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryID { get; set; }
        public string FoodCategoryName { get; set; }
        //public bool FoodCategoryStatus { get; set; }

        public List<Food> foods { get; set; }
    }
}
