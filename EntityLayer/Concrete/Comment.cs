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
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
    }
}
