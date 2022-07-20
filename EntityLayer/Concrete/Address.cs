﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Address 
    {

        public int Id { get; set; }

        public string Adress { get; set; }

        public int UserId { get; set; }

        public int LocationId { get; set; }
    }
}