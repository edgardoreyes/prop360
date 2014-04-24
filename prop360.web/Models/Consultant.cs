using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class Consultant : AuditFields
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserType { get; set; }
        public int ContactId { get; set; }
        public string BadgeId { get; set; }
        public string Division { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public int UpperLine { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveThru { get; set; }

    }
}