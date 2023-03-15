﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
   public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; }
    }
}
