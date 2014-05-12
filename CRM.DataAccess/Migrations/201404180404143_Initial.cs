namespace CRM.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ImageRef", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ImageRef");
        }
    }
}
