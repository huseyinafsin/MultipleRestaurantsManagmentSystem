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
    public class Message : BaseEntity, IEntity
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int ToUserID { get; set; }
        public User FromUser { get; set; }

        public int FromUserID { get; set; }
        public User ToUser { get; set; }
    }
}
