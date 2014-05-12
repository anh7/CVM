namespace CRM.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Website = c.String(maxLength: 30),
                        Description = c.String(maxLength: 1000),
                        DateCreated = c.DateTime(nullable: false),
                        Industry_ID = c.Int(),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Industry", t => t.Industry_ID)
                .ForeignKey("dbo.User", t => t.User_ID, cascadeDelete: true);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Street = c.String(maxLength: 60),
                        City = c.String(maxLength: 60),
                        State_Province = c.String(maxLength: 60),
                        ZipCode = c.String(maxLength: 10),
                        Account_ID = c.Int(),
                        Contact_ID = c.Int(),
                        Country_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.Account_ID)
                .ForeignKey("dbo.Contact", t => t.Contact_ID)
                .ForeignKey("dbo.Country", t => t.Country_ID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Company = c.String(maxLength: 60),
                        JobTile = c.String(maxLength: 30),
                        Phone = c.String(maxLength: 15),
                        Skype = c.String(maxLength: 30),
                        Email = c.String(maxLength: 60),
                        DateCreated = c.DateTime(nullable: false),
                        Account_ID = c.Int(),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.Account_ID)
                .ForeignKey("dbo.User", t => t.User_ID, cascadeDelete: true);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Content = c.String(maxLength: 2000),
                        RefFile = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        Account_ID = c.Int(),
                        Contact_ID = c.Int(),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.Account_ID)
                .ForeignKey("dbo.Contact", t => t.Contact_ID)
                .ForeignKey("dbo.User", t => t.User_ID, cascadeDelete: true);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        UserName = c.String(nullable: false, maxLength: 60),
                        Password = c.String(nullable: false, maxLength: 32),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Industry",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "User_ID", "dbo.User");
            DropForeignKey("dbo.Account", "Industry_ID", "dbo.Industry");
            DropForeignKey("dbo.Address", "Country_ID", "dbo.Country");
            DropForeignKey("dbo.Contact", "User_ID", "dbo.User");
            DropForeignKey("dbo.Note", "User_ID", "dbo.User");
            DropForeignKey("dbo.Note", "Contact_ID", "dbo.Contact");
            DropForeignKey("dbo.Note", "Account_ID", "dbo.Account");
            DropForeignKey("dbo.Address", "Contact_ID", "dbo.Contact");
            DropForeignKey("dbo.Contact", "Account_ID", "dbo.Account");
            DropForeignKey("dbo.Address", "Account_ID", "dbo.Account");
            DropTable("dbo.Industry");
            DropTable("dbo.Country");
            DropTable("dbo.User");
            DropTable("dbo.Note");
            DropTable("dbo.Contact");
            DropTable("dbo.Address");
            DropTable("dbo.Account");
        }
    }
}
