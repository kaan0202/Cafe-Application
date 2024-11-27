﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.App
{
    public class ProductDetail:BaseEntity
    {
       
        public int? ProductId { get; set; }
        public int? SizeId { get; set; }

        public string ProductDescription { get; set; }

        public Size? Size { get; set; }
        public Product? Product { get; set; }
        
       


    }
}
