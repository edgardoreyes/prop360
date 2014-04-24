using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prop360.web.Models
{
    public class Prop360Db : DbContext
    {
        public Prop360Db() : base("name=DefaultConnection")
        {

        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPost> PropertyPosts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<User> Users { get; set; }

    }
}