using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class PropertyPost : AuditFields
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int BuyerId { get; set; }
        public int ConsultantId { get; set; }
        public string ConsultantBadge { get; set; }
        public int ProfessionalId { get; set; }
        public string ProfessionalLicense { get; set; }
        public int PropertyId { get; set; }
        public DateTime PostDate { get; set; }
    }
}