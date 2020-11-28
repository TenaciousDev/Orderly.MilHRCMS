namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNamesOfIdProperties : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contact");
            DropPrimaryKey("dbo.Housing");
            DropPrimaryKey("dbo.UnitInfo");
            DropPrimaryKey("dbo.Team");
            DropPrimaryKey("dbo.Squad");
            DropPrimaryKey("dbo.Platoon");
            DropColumn("dbo.Contact", "Id");
            DropColumn("dbo.Housing", "Id");
            DropColumn("dbo.UnitInfo", "Id");
            DropColumn("dbo.Team", "Id");
            DropColumn("dbo.Squad", "Id");
            DropColumn("dbo.Platoon", "Id");
            DropForeignKey("dbo.Personnel", "Platoon_Id", "dbo.Platoon");
            DropForeignKey("dbo.Personnel", "Squad_Id", "dbo.Squad");
            DropForeignKey("dbo.Personnel", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.UnitInfo", "TeamId", "dbo.Team");
            DropForeignKey("dbo.Team", "Platoon_Id", "dbo.Platoon");
            DropForeignKey("dbo.Team", "SquadId", "dbo.Squad");
            DropForeignKey("dbo.Squad", "PlatoonId", "dbo.Platoon");
            RenameColumn(table: "dbo.Personnel", name: "Platoon_Id", newName: "Platoon_PlatoonId");
            RenameColumn(table: "dbo.Team", name: "Platoon_Id", newName: "Platoon_PlatoonId");
            RenameColumn(table: "dbo.Personnel", name: "Squad_Id", newName: "Squad_SquadId");
            RenameColumn(table: "dbo.Personnel", name: "Team_Id", newName: "Team_TeamId");
            RenameIndex(table: "dbo.Personnel", name: "IX_Platoon_Id", newName: "IX_Platoon_PlatoonId");
            RenameIndex(table: "dbo.Personnel", name: "IX_Squad_Id", newName: "IX_Squad_SquadId");
            RenameIndex(table: "dbo.Personnel", name: "IX_Team_Id", newName: "IX_Team_TeamId");
            RenameIndex(table: "dbo.Team", name: "IX_Platoon_Id", newName: "IX_Platoon_PlatoonId");
            AddColumn("dbo.Contact", "ContactId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Housing", "HousingId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Platoon", "PlatoonId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Squad", "SquadId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Team", "TeamId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.UnitInfo", "UnitInfoId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Contact", "ContactId");
            AddPrimaryKey("dbo.Housing", "HousingId");
            AddPrimaryKey("dbo.Platoon", "PlatoonId");
            AddPrimaryKey("dbo.Squad", "SquadId");
            AddPrimaryKey("dbo.Team", "TeamId");
            AddPrimaryKey("dbo.UnitInfo", "UnitInfoId");
            AddForeignKey("dbo.Personnel", "Platoon_PlatoonId", "dbo.Platoon", "PlatoonId");
            AddForeignKey("dbo.Squad", "PlatoonId", "dbo.Platoon", "PlatoonId", cascadeDelete: true);
            AddForeignKey("dbo.Team", "Platoon_PlatoonId", "dbo.Platoon", "PlatoonId");
            AddForeignKey("dbo.Personnel", "Squad_SquadId", "dbo.Squad", "SquadId");
            AddForeignKey("dbo.Team", "SquadId", "dbo.Squad", "SquadId", cascadeDelete: true);
            AddForeignKey("dbo.Personnel", "Team_TeamId", "dbo.Team", "TeamId");
            AddForeignKey("dbo.UnitInfo", "TeamId", "dbo.Team", "TeamId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnitInfo", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Team", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Squad", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Platoon", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Housing", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Contact", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.UnitInfo", "TeamId", "dbo.Team");
            DropForeignKey("dbo.Personnel", "Team_TeamId", "dbo.Team");
            DropForeignKey("dbo.Team", "SquadId", "dbo.Squad");
            DropForeignKey("dbo.Personnel", "Squad_SquadId", "dbo.Squad");
            DropForeignKey("dbo.Team", "Platoon_PlatoonId", "dbo.Platoon");
            DropForeignKey("dbo.Squad", "PlatoonId", "dbo.Platoon");
            DropForeignKey("dbo.Personnel", "Platoon_PlatoonId", "dbo.Platoon");
            DropPrimaryKey("dbo.UnitInfo");
            DropPrimaryKey("dbo.Team");
            DropPrimaryKey("dbo.Squad");
            DropPrimaryKey("dbo.Platoon");
            DropPrimaryKey("dbo.Housing");
            DropPrimaryKey("dbo.Contact");
            DropColumn("dbo.UnitInfo", "UnitInfoId");
            DropColumn("dbo.Team", "TeamId");
            DropColumn("dbo.Squad", "SquadId");
            DropColumn("dbo.Platoon", "PlatoonId");
            DropColumn("dbo.Housing", "HousingId");
            DropColumn("dbo.Contact", "ContactId");
            AddPrimaryKey("dbo.UnitInfo", "Id");
            AddPrimaryKey("dbo.Team", "Id");
            AddPrimaryKey("dbo.Squad", "Id");
            AddPrimaryKey("dbo.Platoon", "Id");
            AddPrimaryKey("dbo.Housing", "Id");
            AddPrimaryKey("dbo.Contact", "Id");
            RenameIndex(table: "dbo.Team", name: "IX_Platoon_PlatoonId", newName: "IX_Platoon_Id");
            RenameIndex(table: "dbo.Personnel", name: "IX_Team_TeamId", newName: "IX_Team_Id");
            RenameIndex(table: "dbo.Personnel", name: "IX_Squad_SquadId", newName: "IX_Squad_Id");
            RenameIndex(table: "dbo.Personnel", name: "IX_Platoon_PlatoonId", newName: "IX_Platoon_Id");
            RenameColumn(table: "dbo.Personnel", name: "Team_TeamId", newName: "Team_Id");
            RenameColumn(table: "dbo.Personnel", name: "Squad_SquadId", newName: "Squad_Id");
            RenameColumn(table: "dbo.Team", name: "Platoon_PlatoonId", newName: "Platoon_Id");
            RenameColumn(table: "dbo.Personnel", name: "Platoon_PlatoonId", newName: "Platoon_Id");
            AddForeignKey("dbo.UnitInfo", "TeamId", "dbo.Team", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Personnel", "Team_Id", "dbo.Team", "Id");
            AddForeignKey("dbo.Team", "SquadId", "dbo.Squad", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Personnel", "Squad_Id", "dbo.Squad", "Id");
            AddForeignKey("dbo.Team", "Platoon_Id", "dbo.Platoon", "Id");
            AddForeignKey("dbo.Squad", "PlatoonId", "dbo.Platoon", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Personnel", "Platoon_Id", "dbo.Platoon", "Id");
        }
    }
}
