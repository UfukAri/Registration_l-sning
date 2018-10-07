namespace Registration_løsning.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Registration_løsning.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Registration_løsning.Models.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Registration_løsning.Models.DB";
        }

        protected override void Seed(Registration_løsning.Models.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
