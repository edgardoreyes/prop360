using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Web;


namespace prop360.entities
{
    public class Property : AuditFields
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int PropertyType { get; set; }
        public bool ForRent { get; set; }
        public bool ForSale { get; set; }
        public int ProfId { get; set; }
        public int BuyerId { get; set; }
        public decimal AskingPrice { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int HomeSize { get; set; }
        public int LotSize { get; set; }
        public int YearBuilt { get; set; }
        public int Bedroom { get; set; }
        public int Bathroom { get; set; }
        public int Garage { get; set; }
        public int Story { get; set; }
        public string Roof { get; set; }
        public string Exterior { get; set; }
        //public Geography Geolocation { get; set; }
    }
}