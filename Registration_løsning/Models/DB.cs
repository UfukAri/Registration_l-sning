using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*áÇÒã  äÌíÈåã */
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Registration_løsning.Models
{ 

    public class DB : DbContext
    {


        public DB()
            : base("name =film")
        {
            Database.CreateIfNotExists();

        }

        public DbSet<Kunde> Kunde { get; set; }

        public DbSet<Film> Film { get; set; }

        public DbSet<Order> Order { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}