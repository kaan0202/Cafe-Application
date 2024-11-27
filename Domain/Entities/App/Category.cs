﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.App
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public ICollection<Product>? Products { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
