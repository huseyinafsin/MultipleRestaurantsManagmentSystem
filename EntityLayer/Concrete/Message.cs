using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
        //public bool MessageStatus { get; set; }

        public int ToUserID { get; set; }
        public User FromUser { get; set; }

        public int FromUserID { get; set; }
        public User ToUser { get; set; }
    }
}
