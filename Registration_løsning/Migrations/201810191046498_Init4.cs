namespace Registration_løsning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admin", "Kunde_Id", "dbo.Kunde");
            DropIndex("dbo.Admin", new[] { "Kunde_Id" });
            DropColumn("dbo.Admin", "Kunde_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admin", "Kunde_Id", c => c.Int());
            CreateIndex("dbo.Admin", "Kunde_Id");
            AddForeignKey("dbo.Admin", "Kunde_Id", "dbo.Kunde", "Id");
        }
    }
}
