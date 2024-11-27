using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.App
{
    public class Offer:BaseEntity  
    {
        public int? CategoryId { get; set; }
        public short OfferPercent { get; set; }
        public string OfferName { get; set; }
        public string OfferDescription { get; set; }
        public string OfferStatus { get; set; }
        public DateTime OfferTime { get; set; }


        public Category? Category { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
