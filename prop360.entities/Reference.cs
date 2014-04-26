using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.entities
{
    public class Reference : AuditFields
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}