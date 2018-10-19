namespace Registration_løsning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Adresse", newName: "Poststed");
            RenameColumn(table: "dbo.Kunde", name: "Adresse_Id", newName: "Poststed_Id");
            RenameIndex(table: "dbo.Kunde", name: "IX_Adresse_Id", newName: "IX_Poststed_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Kunde", name: "IX_Poststed_Id", newName: "IX_Adresse_Id");
            RenameColumn(table: "dbo.Kunde", name: "Poststed_Id", newName: "Adresse_Id");
            RenameTable(name: "dbo.Poststed", newName: "Adresse");
        }
    }
}
