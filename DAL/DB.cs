﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB : DbContext
    {
        public DB() : base("name=DB")
        {
            Database.CreateIfNotExists();

            // NB: Må kjøres to ganger (start/stopp/start applikasjonen) når databasen ikke eksisterer
            Database.SetInitializer(new DBInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<dbKunde> Kunder { get; set; }

        public DbSet<Film> Film { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Poststed> Poststed { get; set; }

        public DbSet<OrderLinje> OrderLinjes { get; set; }



    }
}
