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
    public class Food
    {
        public int Id { get; set; }

        public string  Name { get; set; }
        public float Price { get; set; }
        public string Desc { get; set; }

        public int CategoryId { get; set; }

        public int RestaurantId { get; set; }

    }
}
