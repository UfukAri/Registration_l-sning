using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Registration_løsning.Models
{


    public class dbKunde
    {

        public int Id { get; set; }
        public byte[] Password { get; set; }
    }


    public class OurDbContext : DbContext
    {

        public OurDbContext()
            : base("name=film")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<dbKunde> Brukere { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}