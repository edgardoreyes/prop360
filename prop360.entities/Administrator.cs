﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prop360.entities
{
    public class Administrator : AuditFields
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserType { get; set; }
        public int ContactId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveThru { get; set; }

    }
}