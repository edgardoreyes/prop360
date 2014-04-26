using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.entities
{
    public class Professional : AuditFields
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserType { get; set; }
        public int ContactId { get; set; }
        public string LicenseNum { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public decimal FeePercentage { get; set; }
        public decimal FeeLow { get; set; }
        public decimal FeeHigh { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveThru { get; set; }

    }
}