using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.entities
{
    public class AuditFields
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}