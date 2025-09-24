using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StajMVC.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnection") { }

        public DbSet<Students> Students { get; set; }
    }
}