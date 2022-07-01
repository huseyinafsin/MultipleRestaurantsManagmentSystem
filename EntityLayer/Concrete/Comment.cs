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
    public class Comment: BaseEntity, IEntity
    {
        public string Text { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
