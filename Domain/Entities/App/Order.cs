using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.App
{
    public class Order:BaseEntity
    {
        public int? Quantity { get; set; }
        public int? OfferId { get; set; }
        public int? AddressId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? SideProductId { get; set; }
        public int TotalPrice { get; set; }
        public string OrderCode { get; set; }
        public Offer? Offer { get; set; }
        public Customer? Customer { get; set; }
        public Address? Address { get; set; }

        public Product? Product { get; set; }

        public SideProduct SideProduct { get; set; }
    }
}
