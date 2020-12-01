namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "VehicleColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "VehicleColor");
        }
    }
}
