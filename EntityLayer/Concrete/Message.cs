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
    public class Message 
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int ToUserId { get; set; }

        public int FromUserId { get; set; }

    }
}
