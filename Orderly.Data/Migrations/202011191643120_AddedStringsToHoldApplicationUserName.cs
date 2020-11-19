namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStringsToHoldApplicationUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "CreatedByUserName", c => c.String());
            AddColumn("dbo.Contact", "ModifiedByUserName", c => c.String());
            AddColumn("dbo.Personnel", "CreatedByUserName", c => c.String());
            AddColumn("dbo.Personnel", "ModifiedByUserName", c => c.String());
            AddColumn("dbo.Housing", "CreatedByUserName", c => c.String());
            AddColumn("dbo.Housing", "ModifiedByUserName", c => c.String());
            AddColumn("dbo.UnitInfo", "CreatedByUserName", c => c.String());
            AddColumn("dbo.UnitInfo", "ModifiedByUserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UnitInfo", "ModifiedByUserName");
            DropColumn("dbo.UnitInfo", "CreatedByUserName");
            DropColumn("dbo.Housing", "ModifiedByUserName");
            DropColumn("dbo.Housing", "CreatedByUserName");
            DropColumn("dbo.Personnel", "ModifiedByUserName");
            DropColumn("dbo.Personnel", "CreatedByUserName");
            DropColumn("dbo.Contact", "ModifiedByUserName");
            DropColumn("dbo.Contact", "CreatedByUserName");
        }
    }
}
