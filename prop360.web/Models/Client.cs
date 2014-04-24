using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class Client : AuditFields
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public int ContactId { get; set; }
        public int ProfBuyerId { get; set; }
        public decimal PriceLow { get; set; }
        public decimal PriceHigh { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveThru { get; set; }
    }
}