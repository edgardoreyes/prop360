using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Web;

namespace prop360.web.Models
{
    public class Contact : AuditFields
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string SecondPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        //public Geography Geolocation { get; set; }

    }
}