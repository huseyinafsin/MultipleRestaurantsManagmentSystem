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
    public class Restaurant 
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public int UserId { get; set; }

    }
}
