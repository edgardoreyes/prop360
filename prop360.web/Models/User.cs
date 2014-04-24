using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class User : AuditFields
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
    }
}