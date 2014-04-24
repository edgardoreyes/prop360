using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class Favorite : AuditFields
    {
        public int Id { get; set; }
        public int UserIdMarker { get; set; }
        public int ClientId { get; set; }
        public int ProfId { get; set; }
        public int ConsultantId { get; set; }
        public string Remark { get; set; }

    }
}