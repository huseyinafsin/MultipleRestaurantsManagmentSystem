﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    [NotMapped]
    public class BaseEntity 
    {
        public int Id { get; set; }
        public bool Status { get; set; }

    }
}
