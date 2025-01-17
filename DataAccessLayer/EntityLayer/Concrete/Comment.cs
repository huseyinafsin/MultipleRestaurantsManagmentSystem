﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityLayer.Concrete
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
