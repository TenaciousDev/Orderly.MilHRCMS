namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnel", "Sex", c => c.Int(nullable: false));
            AddColumn("dbo.Personnel", "MaritalStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personnel", "MaritalStatus");
            DropColumn("dbo.Personnel", "Sex");
        }
    }
}
