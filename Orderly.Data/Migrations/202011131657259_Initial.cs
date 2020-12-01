namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonnelId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        PersonalEmail = c.String(),
                        MilEmail = c.String(),
                        HasDriversLicense = c.Boolean(nullable: false),
                        VehicleMake = c.String(),
                        VehicleModel = c.String(),
                        VehiclePlate = c.String(),
                        VehicleYear = c.Int(nullable: false),
                        VehicleInspected = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedLast = c.Guid(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnel", t => t.PersonnelId, cascadeDelete: true)
                .Index(t => t.PersonnelId);
            
            CreateTable(
                "dbo.Personnel",
                c => new
                    {
                        PersonnelId = c.Int(nullable: false, identity: true),
                        Rank = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(),
                        SSN = c.String(nullable: false),
                        DOD = c.String(nullable: false),
                        DOB = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedLast = c.Guid(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                        Platoon_Id = c.Int(),
                        Squad_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.PersonnelId)
                .ForeignKey("dbo.Platoon", t => t.Platoon_Id)
                .ForeignKey("dbo.Squad", t => t.Squad_Id)
                .ForeignKey("dbo.Team", t => t.Team_Id)
                .Index(t => t.Platoon_Id)
                .Index(t => t.Squad_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Housing",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonnelId = c.Int(nullable: false),
                        Address = c.String(),
                        Room = c.String(),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedLast = c.Guid(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnel", t => t.PersonnelId, cascadeDelete: true)
                .Index(t => t.PersonnelId);
            
            CreateTable(
                "dbo.Platoon",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Familiar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Squad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlatoonId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Familiar = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Platoon", t => t.PlatoonId, cascadeDelete: true)
                .Index(t => t.PlatoonId);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SquadId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Familiar = c.String(),
                        Platoon_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Squad", t => t.SquadId, cascadeDelete: true)
                .ForeignKey("dbo.Platoon", t => t.Platoon_Id)
                .Index(t => t.SquadId)
                .Index(t => t.Platoon_Id);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.UnitInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonnelId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        Role = c.String(),
                        Arrived = c.DateTimeOffset(nullable: false, precision: 7),
                        DutyStatus = c.String(),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedLast = c.Guid(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnel", t => t.PersonnelId, cascadeDelete: true)
                .ForeignKey("dbo.Team", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.PersonnelId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.UnitInfo", "TeamId", "dbo.Team");
            DropForeignKey("dbo.UnitInfo", "PersonnelId", "dbo.Personnel");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Team", "Platoon_Id", "dbo.Platoon");
            DropForeignKey("dbo.Team", "SquadId", "dbo.Squad");
            DropForeignKey("dbo.Personnel", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.Squad", "PlatoonId", "dbo.Platoon");
            DropForeignKey("dbo.Personnel", "Squad_Id", "dbo.Squad");
            DropForeignKey("dbo.Personnel", "Platoon_Id", "dbo.Platoon");
            DropForeignKey("dbo.Housing", "PersonnelId", "dbo.Personnel");
            DropForeignKey("dbo.Contact", "PersonnelId", "dbo.Personnel");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UnitInfo", new[] { "TeamId" });
            DropIndex("dbo.UnitInfo", new[] { "PersonnelId" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Team", new[] { "Platoon_Id" });
            DropIndex("dbo.Team", new[] { "SquadId" });
            DropIndex("dbo.Squad", new[] { "PlatoonId" });
            DropIndex("dbo.Housing", new[] { "PersonnelId" });
            DropIndex("dbo.Personnel", new[] { "Team_Id" });
            DropIndex("dbo.Personnel", new[] { "Squad_Id" });
            DropIndex("dbo.Personnel", new[] { "Platoon_Id" });
            DropIndex("dbo.Contact", new[] { "PersonnelId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.UnitInfo");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Team");
            DropTable("dbo.Squad");
            DropTable("dbo.Platoon");
            DropTable("dbo.Housing");
            DropTable("dbo.Personnel");
            DropTable("dbo.Contact");
        }
    }
}
