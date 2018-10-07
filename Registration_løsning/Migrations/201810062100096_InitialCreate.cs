namespace Registration_løsning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostSted = c.String(),
                        PostNr = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kunde",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Adresse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresse", t => t.Adresse_Id)
                .Index(t => t.Adresse_Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Film_Id = c.Int(),
                        Kunde_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Film", t => t.Film_Id)
                .ForeignKey("dbo.Kunde", t => t.Kunde_Id)
                .Index(t => t.Film_Id)
                .Index(t => t.Kunde_Id);
            
            CreateTable(
                "dbo.Film",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Pris = c.Int(nullable: false),
                        Catrgory = c.String(),
                        Discription = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLinje",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Film_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Film", t => t.Film_Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .Index(t => t.Film_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLinje", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.OrderLinje", "Film_Id", "dbo.Film");
            DropForeignKey("dbo.Order", "Kunde_Id", "dbo.Kunde");
            DropForeignKey("dbo.Order", "Film_Id", "dbo.Film");
            DropForeignKey("dbo.Kunde", "Adresse_Id", "dbo.Adresse");
            DropIndex("dbo.OrderLinje", new[] { "Order_Id" });
            DropIndex("dbo.OrderLinje", new[] { "Film_Id" });
            DropIndex("dbo.Order", new[] { "Kunde_Id" });
            DropIndex("dbo.Order", new[] { "Film_Id" });
            DropIndex("dbo.Kunde", new[] { "Adresse_Id" });
            DropTable("dbo.OrderLinje");
            DropTable("dbo.Film");
            DropTable("dbo.Order");
            DropTable("dbo.Kunde");
            DropTable("dbo.Adresse");
        }
    }
}
