using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.App
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public bool StockStatus { get; set; }

        public int? ProductDetailId { get; set; }

        public int? CategoryId { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public Category? Category { get; set; }


    }
}
