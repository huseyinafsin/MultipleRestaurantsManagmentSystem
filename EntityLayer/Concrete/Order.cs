using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Order 
    {
        public int Id { get; set; }

        public int FoodCount { get; set; }
        public DateTime Date { get; set; }

        public int ConditionId { get; set; }

        public int UserId { get; set; }

        public int FoodId { get; set; }
    }
}
