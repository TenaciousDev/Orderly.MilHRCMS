namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Orderly.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Orderly.Data.ApplicationDbContext";
        }

        protected override void Seed(Orderly.Data.ApplicationDbContext context)
        {
            //return;   // <-- Toggle: Seed Data
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //  Seed Platoons
            context.PlatoonDbSet.AddOrUpdate(x => x.Id,
            new Platoon()
            {
                Id = 1,
                Name = "First Platoon",
                Familiar = "Death Dealers",

            },
            new Platoon()
            {
                Id = 2,
                Name = "Second Platoon",
                Familiar = "Maniacs",

            },
            new Platoon()
            {
                Id = 3,
                Name = "Third Platoon",
                Familiar = "Punishers",

            },
            new Platoon()
            {
                Id = 4,
                Name = "Headquarters",
                Familiar = "HQ",

            }
            );
            //  Seed Squads
            context.SquadDbSet.AddOrUpdate(x => x.Id,
                new Squad()
                {
                    Id = 1,
                    PlatoonId = 1,
                    Name = "First Squad",
                },
                new Squad()
                {
                    Id = 2,
                    PlatoonId = 1,
                    Name = "Second Squad",
                },
                new Squad()
                {
                    Id = 3,
                    PlatoonId = 1,
                    Name = "Third Squad",
                },
                new Squad()
                {
                    Id = 4,
                    PlatoonId = 1,
                    Name = "Weapons Squad",
                },
                new Squad()
                {
                    Id = 5,
                    PlatoonId = 2,
                    Name = "First Squad",
                },
                new Squad()
                {
                    Id = 6,
                    PlatoonId = 2,
                    Name = "Second Squad",
                },
                new Squad()
                {
                    Id = 7,
                    PlatoonId = 2,
                    Name = "Third Squad",
                },
                new Squad()
                {
                    Id = 8,
                    PlatoonId = 2,
                    Name = "Weapons Squad",
                },
                new Squad()
                {
                    Id = 9,
                    PlatoonId = 3,
                    Name = "First Squad",
                },
                new Squad()
                {
                    Id = 10,
                    PlatoonId = 3,
                    Name = "Second Squad",
                },
                new Squad()
                {
                    Id = 11,
                    PlatoonId = 3,
                    Name = "Third Squad",
                },
                new Squad()
                {
                    Id = 12,
                    PlatoonId = 3,
                    Name = "Weapons Squad",
                },
                new Squad()
                {
                    Id = 13,
                    PlatoonId = 4,
                    Name = "Headquarters",
                    Familiar = "HQ"
                }
                );
            //  Seed Teams
            context.TeamDbSet.AddOrUpdate(x => x.Id,
                new Team()
                {
                    Id = 1,
                    SquadId = 1,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 2,
                    SquadId = 1,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 3,
                    SquadId = 2,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 4,
                    SquadId = 2,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 5,
                    SquadId = 3,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 6,
                    SquadId = 3,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 7,
                    SquadId = 4,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 8,
                    SquadId = 4,
                    Name = "Team B"
                }, new Team()
                {
                    Id = 9,
                    SquadId = 5,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 10,
                    SquadId = 5,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 11,
                    SquadId = 6,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 12,
                    SquadId = 6,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 13,
                    SquadId = 7,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 14,
                    SquadId = 7,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 15,
                    SquadId = 8,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 16,
                    SquadId = 8,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 17,
                    SquadId = 9,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 18,
                    SquadId = 9,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 19,
                    SquadId = 10,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 20,
                    SquadId = 10,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 21,
                    SquadId = 11,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 22,
                    SquadId = 11,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 23,
                    SquadId = 12,
                    Name = "Team A"
                },
                new Team()
                {
                    Id = 24,
                    SquadId = 12,
                    Name = "Team B"
                },
                new Team()
                {
                    Id = 25,
                    SquadId = 13,
                    Name = "Command Staff",
                    Familiar = "Command"
                },
                new Team()
                {
                    Id = 26,
                    SquadId = 13,
                    Name = "Orderly Room",
                    Familiar = "Training Room"
                },
                new Team()
                {
                    Id = 27,
                    SquadId = 13,
                    Name = "Supply Room",
                    Familiar = "Supply"
                },
                new Team()
                {
                    Id = 28,
                    SquadId = 13,
                    Name = "Communications Room",
                    Familiar = "Commo"
                }
                );
            //  Seed Personnel
            context.PersonnelDbSet.AddOrUpdate(x => x.PersonnelId,
                new Personnel() { PersonnelId = 1, Rank = Grade.E4, FirstName = "Noel", LastName = "Shellard", MiddleName = "Gilberte", Sex = BioSex.Male, SSN = "292-65-7523", DOD = "3479685692", DOB = new DateTime(1999, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 12, 05, 33, 0) },
                new Personnel() { PersonnelId = 2, Rank = Grade.E2, FirstName = "Tamarra", LastName = "Halworth", Sex = BioSex.Male, SSN = "862-31-9490", DOD = "4235212168", DOB = new DateTime(1997, 01, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 10, 02, 31, 0) },
                new Personnel() { PersonnelId = 3, Rank = Grade.E6, FirstName = "Genna", LastName = "Zini", MiddleName = "Lynn", Sex = BioSex.Male, SSN = "849-33-5232", DOD = "4760084398", DOB = new DateTime(1990, 11, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 17, 03, 34, 0) },
                new Personnel() { PersonnelId = 4, Rank = Grade.E5, FirstName = "Carrie", LastName = "Signe", Sex = BioSex.Female, SSN = "135-72-9598", DOD = "8182936276", DOB = new DateTime(1996, 12, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 16, 00, 30, 0) },
                new Personnel() { PersonnelId = 5, Rank = Grade.E4, FirstName = "Erena", LastName = "Petroff", MiddleName = "Hale", Sex = BioSex.Male, SSN = "332-98-7237", DOD = "2712854055", DOB = new DateTime(1977, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 00, 39, 0) },
                new Personnel() { PersonnelId = 6, Rank = Grade.E2, FirstName = "Gerome", LastName = "Harriott", MiddleName = "Karlyn", SSN = "489-08-6981", DOD = "8566145704", DOB = new DateTime(1985, 01, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 17, 09, 36, 0) },
                new Personnel() { PersonnelId = 7, Rank = Grade.O1, FirstName = "Merilyn", LastName = "Dugood", MiddleName = "Lela", Sex = BioSex.Male, SSN = "301-06-7002", DOD = "0038180898", DOB = new DateTime(1988, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 17, 06, 33, 0) },
                new Personnel() { PersonnelId = 8, Rank = Grade.E4, FirstName = "Gaylor", LastName = "Casella", MiddleName = "Colin", Sex = BioSex.Male, SSN = "721-32-9316", DOD = "1968385517", DOB = new DateTime(1992, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 14, 05, 30, 0) },
                new Personnel() { PersonnelId = 9, Rank = Grade.E7, FirstName = "Ilyse", LastName = "Dargan", MiddleName = "Leanna", Sex = BioSex.Male, SSN = "450-94-0306", DOD = "2037844786", DOB = new DateTime(1998, 12, 27, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 05, 39, 0) },
                new Personnel() { PersonnelId = 10, Rank = Grade.E5, FirstName = "Idaline", LastName = "Yoakley", MiddleName = "Shirline", Sex = BioSex.Male, SSN = "794-66-2530", DOD = "7284404043", DOB = new DateTime(1975, 02, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 08, 36, 0) },
                new Personnel() { PersonnelId = 11, Rank = Grade.E2, FirstName = "Marve", LastName = "Limprecht", MiddleName = "Normand", Sex = BioSex.Male, SSN = "386-38-0832", DOD = "8290047592", DOB = new DateTime(1990, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 19, 07, 34, 0) },
                new Personnel() { PersonnelId = 12, Rank = Grade.E6, FirstName = "Cathe", LastName = "Fleckney", Sex = BioSex.Male, SSN = "342-81-2342", DOD = "9333005331", DOB = new DateTime(1990, 12, 27, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 10, 08, 36, 0) },
                new Personnel() { PersonnelId = 13, Rank = Grade.E7, FirstName = "Nickolas", LastName = "Coldridge", MiddleName = "Aylmer", Sex = BioSex.Female, SSN = "301-76-3078", DOD = "6139534798", DOB = new DateTime(1987, 01, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 19, 04, 38, 0) },
                new Personnel() { PersonnelId = 14, Rank = Grade.O2, FirstName = "Glen", LastName = "Ilchenko", Sex = BioSex.Male, SSN = "757-18-8413", DOD = "7888703070", DOB = new DateTime(1997, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 17, 08, 35, 0) },
                new Personnel() { PersonnelId = 15, Rank = Grade.E4, FirstName = "Flin", LastName = "Inston", MiddleName = "Tris", Sex = BioSex.Female, SSN = "266-98-6271", DOD = "6446349114", DOB = new DateTime(1996, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 03, 34, 0) },
                new Personnel() { PersonnelId = 16, Rank = Grade.E6, FirstName = "Nathanael", LastName = "Gricewood", MiddleName = "Lanny", Sex = BioSex.Other, SSN = "407-52-1791", DOD = "4482032018", DOB = new DateTime(1976, 01, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 13, 00, 30, 0) },
                new Personnel() { PersonnelId = 17, Rank = Grade.E5, FirstName = "Inger", LastName = "Sprouls", MiddleName = "Kerr", Sex = BioSex.Other, SSN = "453-11-0399", DOD = "8380907922", DOB = new DateTime(1993, 11, 07, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 11, 04, 33, 0) },
                new Personnel() { PersonnelId = 18, Rank = Grade.E1, FirstName = "Nissie", LastName = "Ayars", MiddleName = "Bryana", Sex = BioSex.Male, SSN = "592-07-7891", DOD = "7780837882", DOB = new DateTime(1952, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 10, 08, 30, 0) },
                new Personnel() { PersonnelId = 19, Rank = Grade.E2, FirstName = "Felita", LastName = "Rosenboim", MiddleName = "Chryste", Sex = BioSex.Male, SSN = "253-01-5041", DOD = "8578913094", DOB = new DateTime(1968, 02, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 17, 09, 30, 0) },
                new Personnel() { PersonnelId = 20, Rank = Grade.E6, FirstName = "Marsh", LastName = "Stokey", MiddleName = "Nara", Sex = BioSex.Male, SSN = "598-57-3532", DOD = "8191341603", DOB = new DateTime(1988, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 18, 01, 30, 0) },
                new Personnel() { PersonnelId = 21, Rank = Grade.E5, FirstName = "Morganica", LastName = "Stote", MiddleName = "Minne", Sex = BioSex.Male, SSN = "334-45-3656", DOD = "1909375322", DOB = new DateTime(1970, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 17, 00, 30, 0) },
                new Personnel() { PersonnelId = 22, Rank = Grade.E5, FirstName = "Karina", LastName = "Angric", MiddleName = "Josselyn", Sex = BioSex.Male, SSN = "413-29-8779", DOD = "4124686102", DOB = new DateTime(1989, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 12, 08, 32, 0) },
                new Personnel() { PersonnelId = 23, Rank = Grade.E3, FirstName = "Maryjane", LastName = "Maynard", Sex = BioSex.Female, SSN = "297-72-0826", DOD = "4793115373", DOB = new DateTime(1989, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 13, 00, 30, 0) },
                new Personnel() { PersonnelId = 24, Rank = Grade.E2, FirstName = "Karin", LastName = "Sabathe", Sex = BioSex.Male, SSN = "382-14-8630", DOD = "7228155017", DOB = new DateTime(1991, 02, 27, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 11, 05, 34, 0) },
                new Personnel() { PersonnelId = 25, Rank = Grade.W2, FirstName = "Kirsten", LastName = "Kolakowski", MiddleName = "Laurens", Sex = BioSex.Male, SSN = "896-02-7040", DOD = "8131360237", DOB = new DateTime(1997, 02, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 17, 07, 38, 0) },
                new Personnel() { PersonnelId = 26, Rank = Grade.E1, FirstName = "Philippa", LastName = "Murrell", MiddleName = "Angel", Sex = BioSex.Male, SSN = "618-40-2108", DOD = "2729983813", DOB = new DateTime(1995, 11, 27, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 16, 06, 37, 0) },
                new Personnel() { PersonnelId = 27, Rank = Grade.E4, FirstName = "Lissy", LastName = "Hinze", MiddleName = "Pauli", Sex = BioSex.Female, SSN = "497-83-0211", DOD = "4763967460", DOB = new DateTime(1954, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 10, 08, 33, 0) },
                new Personnel() { PersonnelId = 28, Rank = Grade.E1, FirstName = "Brande", LastName = "Wetherhead", MiddleName = "Alaster", Sex = BioSex.Male, SSN = "612-85-6577", DOD = "1506456472", DOB = new DateTime(1992, 01, 06, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 11, 04, 33, 0) },
                new Personnel() { PersonnelId = 29, Rank = Grade.E2, FirstName = "Denise", LastName = "Blaze", Sex = BioSex.Female, SSN = "490-33-0480", DOD = "2182839119", DOB = new DateTime(1971, 01, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 15, 05, 36, 0) },
                new Personnel() { PersonnelId = 30, Rank = Grade.E2, FirstName = "Roana", LastName = "Glasspool", MiddleName = "Gamaliel", Sex = BioSex.Other, SSN = "520-29-6778", DOD = "0691576475", DOB = new DateTime(1992, 01, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 12, 03, 39, 0) },
                new Personnel() { PersonnelId = 31, Rank = Grade.E4, FirstName = "Myrilla", LastName = "Steffans", MiddleName = "Marney", Sex = BioSex.Male, SSN = "789-37-1079", DOD = "6439934406", DOB = new DateTime(1987, 12, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 10, 07, 38, 0) },
                new Personnel() { PersonnelId = 32, Rank = Grade.E5, FirstName = "Egan", LastName = "Struther", MiddleName = "Bard", Sex = BioSex.Male, SSN = "151-45-4925", DOD = "1048221628", DOB = new DateTime(1990, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 14, 01, 31, 0) },
                new Personnel() { PersonnelId = 33, Rank = Grade.E5, FirstName = "Derrek", LastName = "Stone", Sex = BioSex.Female, SSN = "852-76-4527", DOD = "7548423969", DOB = new DateTime(1976, 12, 07, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 18, 03, 31, 0) },
                new Personnel() { PersonnelId = 34, Rank = Grade.O1, FirstName = "Glynnis", LastName = "Kiljan", MiddleName = "Jacinda", SSN = "834-26-8310", DOD = "0255335504", DOB = new DateTime(1995, 02, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 12, 09, 38, 0) },
                new Personnel() { PersonnelId = 35, Rank = Grade.E4, FirstName = "Noel", LastName = "McQuaid", MiddleName = "Gianni", Sex = BioSex.Other, SSN = "156-68-6743", DOD = "1144898889", DOB = new DateTime(1973, 11, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 14, 01, 39, 0) },
                new Personnel() { PersonnelId = 36, Rank = Grade.E4, FirstName = "Ezequiel", LastName = "Gadsdon", MiddleName = "Janela", Sex = BioSex.Male, SSN = "329-48-3070", DOD = "9438623175", DOB = new DateTime(1995, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 10, 09, 31, 0) },
                new Personnel() { PersonnelId = 37, Rank = Grade.E5, FirstName = "Reilly", LastName = "Vero", MiddleName = "Briny", Sex = BioSex.Male, SSN = "880-01-7439", DOD = "1723783277", DOB = new DateTime(1994, 01, 07, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 11, 02, 32, 0) },
                new Personnel() { PersonnelId = 38, Rank = Grade.E4, FirstName = "Lila", LastName = "Tax", MiddleName = "Wald", Sex = BioSex.Male, SSN = "160-32-1025", DOD = "5668839400", DOB = new DateTime(1992, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 10, 06, 32, 0) },
                new Personnel() { PersonnelId = 39, Rank = Grade.E4, FirstName = "Kleon", LastName = "Vasilov", MiddleName = "Bordy", Sex = BioSex.Male, SSN = "431-61-7162", DOD = "3520887703", DOB = new DateTime(1992, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 11, 09, 30, 0) },
                new Personnel() { PersonnelId = 40, Rank = Grade.O1, FirstName = "Michele", LastName = "Bullough", MiddleName = "Rosabella", Sex = BioSex.Male, SSN = "550-80-5668", DOD = "6044630358", DOB = new DateTime(1998, 01, 19, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 12, 08, 39, 0) },
                new Personnel() { PersonnelId = 41, Rank = Grade.E3, FirstName = "Jackqueline", LastName = "Rosengart", MiddleName = "Moreen", Sex = BioSex.Male, SSN = "171-71-4483", DOD = "8546941815", DOB = new DateTime(1951, 02, 27, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 10, 08, 39, 0) },
                new Personnel() { PersonnelId = 42, Rank = Grade.E4, FirstName = "Alayne", LastName = "Travis", Sex = BioSex.Female, SSN = "174-88-1823", DOD = "2073107494", DOB = new DateTime(1993, 11, 05, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 17, 01, 30, 0) },
                new Personnel() { PersonnelId = 43, Rank = Grade.E4, FirstName = "Brendon", LastName = "Kemetz", Sex = BioSex.Female, SSN = "762-77-9185", DOD = "5771193550", DOB = new DateTime(1987, 02, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 19, 03, 30, 0) },
                new Personnel() { PersonnelId = 44, Rank = Grade.E3, FirstName = "Nady", LastName = "Oldale", MiddleName = "Lidia", Sex = BioSex.Male, SSN = "391-61-0430", DOD = "2544868295", DOB = new DateTime(1973, 02, 08, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 19, 01, 30, 0) },
                new Personnel() { PersonnelId = 45, Rank = Grade.E4, FirstName = "Maddy", LastName = "Troth", MiddleName = "Gabrielle", Sex = BioSex.Male, SSN = "516-14-4010", DOD = "5253545646", DOB = new DateTime(1983, 12, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 10, 00, 37, 0) },
                new Personnel() { PersonnelId = 46, Rank = Grade.E7, FirstName = "Montgomery", LastName = "Alyokhin", MiddleName = "Helsa", Sex = BioSex.Female, SSN = "182-67-8644", DOD = "8857138690", DOB = new DateTime(1998, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 16, 03, 38, 0) },
                new Personnel() { PersonnelId = 47, Rank = Grade.E2, FirstName = "Jennine", LastName = "Middlemass", Sex = BioSex.Male, SSN = "882-35-2766", DOD = "6310867059", DOB = new DateTime(1976, 02, 17, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 12, 09, 30, 0) },
                new Personnel() { PersonnelId = 48, Rank = Grade.E6, FirstName = "Tobi", LastName = "Kiltie", Sex = BioSex.Male, SSN = "671-98-4579", DOD = "1337677507", DOB = new DateTime(1991, 01, 05, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 13, 07, 33, 0) },
                new Personnel() { PersonnelId = 49, Rank = Grade.E2, FirstName = "Bee", LastName = "Butland", MiddleName = "Major", Sex = BioSex.Male, SSN = "665-94-1794", DOD = "6499397636", DOB = new DateTime(1995, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 11, 08, 38, 0) },
                new Personnel() { PersonnelId = 50, Rank = Grade.E5, FirstName = "Josiah", LastName = "Clowton", MiddleName = "Mora", Sex = BioSex.Male, SSN = "888-83-0807", DOD = "2702170323", DOB = new DateTime(1995, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 00, 35, 0) },
                new Personnel() { PersonnelId = 51, Rank = Grade.E2, FirstName = "Cassius", LastName = "Orviss", MiddleName = "Noelani", Sex = BioSex.Female, SSN = "348-23-3259", DOD = "9514970551", DOB = new DateTime(1951, 02, 27, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 13, 06, 33, 0) },
                new Personnel() { PersonnelId = 52, Rank = Grade.E4, FirstName = "Tannie", LastName = "Tansley", MiddleName = "Sigvard", Sex = BioSex.Male, SSN = "132-13-0950", DOD = "3664798228", DOB = new DateTime(1986, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 14, 07, 31, 0) },
                new Personnel() { PersonnelId = 53, Rank = Grade.E6, FirstName = "Derron", LastName = "Pandie", MiddleName = "Gabriela", Sex = BioSex.Male, SSN = "819-49-6367", DOD = "5081320897", DOB = new DateTime(1958, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 15, 07, 31, 0) },
                new Personnel() { PersonnelId = 54, Rank = Grade.E5, FirstName = "Biddie", LastName = "Rice", MiddleName = "Marje", Sex = BioSex.Male, SSN = "324-21-2040", DOD = "6013026653", DOB = new DateTime(1998, 01, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 07, 37, 0) },
                new Personnel() { PersonnelId = 55, Rank = Grade.E4, FirstName = "Dorette", LastName = "McCaighey", MiddleName = "Albertina", Sex = BioSex.Male, SSN = "683-37-5764", DOD = "4529269116", DOB = new DateTime(1978, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 15, 09, 35, 0) },
                new Personnel() { PersonnelId = 56, Rank = Grade.E1, FirstName = "Orran", LastName = "Brilleman", Sex = BioSex.Female, SSN = "808-33-8393", DOD = "1373354208", DOB = new DateTime(1995, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 06, 32, 0) },
                new Personnel() { PersonnelId = 57, Rank = Grade.E2, FirstName = "Malachi", LastName = "Udden", MiddleName = "Clywd", Sex = BioSex.Male, SSN = "430-73-3677", DOD = "4785517107", DOB = new DateTime(1999, 01, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 11, 08, 35, 0) },
                new Personnel() { PersonnelId = 58, Rank = Grade.E8, FirstName = "Wheeler", LastName = "Hearnshaw", MiddleName = "Bourke", Sex = BioSex.Male, SSN = "348-82-8894", DOD = "7418990987", DOB = new DateTime(1987, 02, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 15, 05, 34, 0) },
                new Personnel() { PersonnelId = 59, Rank = Grade.E4, FirstName = "Dotti", LastName = "Gehrels", MiddleName = "Phylys", Sex = BioSex.Male, SSN = "889-81-2940", DOD = "5250514286", DOB = new DateTime(1987, 02, 21, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 01, 35, 0) },
                new Personnel() { PersonnelId = 60, Rank = Grade.E2, FirstName = "Hortensia", LastName = "Hassen", Sex = BioSex.Male, SSN = "871-38-4851", DOD = "3610736666", DOB = new DateTime(1971, 01, 17, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 19, 05, 31, 0) },
                new Personnel() { PersonnelId = 61, Rank = Grade.E4, FirstName = "Friederike", LastName = "Stairmand", Sex = BioSex.Male, SSN = "126-98-4673", DOD = "6291653745", DOB = new DateTime(1994, 02, 07, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 14, 08, 33, 0) },
                new Personnel() { PersonnelId = 62, Rank = Grade.E8, FirstName = "Quentin", LastName = "Simoncelli", MiddleName = "Gavra", Sex = BioSex.Male, SSN = "179-92-3687", DOD = "5473028071", DOB = new DateTime(1990, 11, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 17, 09, 34, 0) },
                new Personnel() { PersonnelId = 63, Rank = Grade.E1, FirstName = "Suki", LastName = "Bonus", Sex = BioSex.Female, SSN = "128-16-9459", DOD = "1629764957", DOB = new DateTime(1974, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 13, 03, 30, 0) },
                new Personnel() { PersonnelId = 64, Rank = Grade.W2, FirstName = "Mae", LastName = "Dunkley", MiddleName = "Lotta", Sex = BioSex.Male, SSN = "185-04-4392", DOD = "8967356927", DOB = new DateTime(1981, 02, 07, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 18, 08, 33, 0) },
                new Personnel() { PersonnelId = 65, Rank = Grade.E4, FirstName = "Deana", LastName = "Jeffry", Sex = BioSex.Other, SSN = "415-51-0422", DOD = "4564721968", DOB = new DateTime(1994, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 12, 04, 38, 0) },
                new Personnel() { PersonnelId = 66, Rank = Grade.E5, FirstName = "Basia", LastName = "Baszniak", MiddleName = "Shena", Sex = BioSex.Male, SSN = "325-56-5009", DOD = "9328327504", DOB = new DateTime(1994, 02, 27, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 11, 02, 35, 0) },
                new Personnel() { PersonnelId = 67, Rank = Grade.E1, FirstName = "Danika", LastName = "Reuven", MiddleName = "Waverly", Sex = BioSex.Male, SSN = "644-38-1865", DOD = "1310955123", DOB = new DateTime(1994, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 07, 34, 0) },
                new Personnel() { PersonnelId = 68, Rank = Grade.E1, FirstName = "Guillaume", LastName = "Judron", Sex = BioSex.Other, SSN = "853-23-5205", DOD = "7671913766", DOB = new DateTime(1950, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 14, 07, 31, 0) },
                new Personnel() { PersonnelId = 69, Rank = Grade.E2, FirstName = "Linnet", LastName = "Snookes", MiddleName = "Karlee", Sex = BioSex.Female, SSN = "772-76-2989", DOD = "8121474469", DOB = new DateTime(1990, 11, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 17, 03, 37, 0) },
                new Personnel() { PersonnelId = 70, Rank = Grade.E4, FirstName = "Maison", LastName = "Hoppner", MiddleName = "Layney", Sex = BioSex.Male, SSN = "737-40-7335", DOD = "5887568895", DOB = new DateTime(1993, 12, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 17, 00, 38, 0) },
                new Personnel() { PersonnelId = 71, Rank = Grade.E3, FirstName = "Lydon", LastName = "Batalini", MiddleName = "Bab", Sex = BioSex.Male, SSN = "180-27-5343", DOD = "1171961693", DOB = new DateTime(1971, 02, 23, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 15, 04, 39, 0) },
                new Personnel() { PersonnelId = 72, Rank = Grade.E7, FirstName = "Julio", LastName = "Bellord", MiddleName = "Parke", Sex = BioSex.Male, SSN = "790-65-2495", DOD = "0339553480", DOB = new DateTime(1980, 01, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 19, 05, 33, 0) },
                new Personnel() { PersonnelId = 73, Rank = Grade.E1, FirstName = "Hally", LastName = "Spatarul", MiddleName = "Hetti", Sex = BioSex.Male, SSN = "631-09-0158", DOD = "9955237791", DOB = new DateTime(1980, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 18, 02, 31, 0) },
                new Personnel() { PersonnelId = 74, Rank = Grade.E2, FirstName = "Terrence", LastName = "Roseburgh", MiddleName = "Karola", Sex = BioSex.Female, SSN = "266-90-2224", DOD = "3048886893", DOB = new DateTime(1992, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 16, 08, 33, 0) },
                new Personnel() { PersonnelId = 75, Rank = Grade.E5, FirstName = "Wendye", LastName = "Waltering", Sex = BioSex.Male, SSN = "215-11-6840", DOD = "9968614734", DOB = new DateTime(1965, 01, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 17, 06, 33, 0) },
                new Personnel() { PersonnelId = 76, Rank = Grade.E4, FirstName = "Ursola", LastName = "Hamblen", MiddleName = "Man", Sex = BioSex.Male, SSN = "153-77-9471", DOD = "4256539387", DOB = new DateTime(1984, 02, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 10, 05, 31, 0) },
                new Personnel() { PersonnelId = 77, Rank = Grade.E2, FirstName = "Bobbie", LastName = "Clulow", MiddleName = "Emilee", Sex = BioSex.Male, SSN = "400-34-4748", DOD = "7120119788", DOB = new DateTime(1986, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 15, 00, 36, 0) },
                new Personnel() { PersonnelId = 78, Rank = Grade.E2, FirstName = "Yanaton", LastName = "Manthorpe", MiddleName = "Cosetta", Sex = BioSex.Male, SSN = "537-05-4267", DOD = "8572778993", DOB = new DateTime(1991, 12, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 10, 00, 39, 0) },
                new Personnel() { PersonnelId = 79, Rank = Grade.E6, FirstName = "Paulina", LastName = "Files", Sex = BioSex.Male, SSN = "694-74-6484", DOD = "4496888432", DOB = new DateTime(1983, 11, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 18, 02, 37, 0) },
                new Personnel() { PersonnelId = 80, Rank = Grade.E5, FirstName = "Marilin", LastName = "Severns", MiddleName = "Worthington", Sex = BioSex.Female, SSN = "720-13-5896", DOD = "5256962922", DOB = new DateTime(1993, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 11, 02, 34, 0) },
                new Personnel() { PersonnelId = 81, Rank = Grade.E4, FirstName = "Duane", LastName = "Eathorne", MiddleName = "Nataniel", Sex = BioSex.Male, SSN = "485-94-9250", DOD = "0175951608", DOB = new DateTime(1998, 12, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 15, 09, 34, 0) },
                new Personnel() { PersonnelId = 82, Rank = Grade.E1, FirstName = "Ara", LastName = "Phillcock", MiddleName = "Griffin", Sex = BioSex.Male, SSN = "239-28-4668", DOD = "1247834123", DOB = new DateTime(1992, 01, 18, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 14, 08, 33, 0) },
                new Personnel() { PersonnelId = 83, Rank = Grade.E3, FirstName = "Caritta", LastName = "Urquhart", MiddleName = "Lissa", Sex = BioSex.Male, SSN = "433-48-6484", DOD = "3008231837", DOB = new DateTime(1997, 12, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 19, 00, 33, 0) },
                new Personnel() { PersonnelId = 84, Rank = Grade.E7, FirstName = "Wolfgang", LastName = "Blackburn", MiddleName = "Delila", Sex = BioSex.Male, SSN = "775-25-4269", DOD = "1969594241", DOB = new DateTime(1989, 12, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 10, 05, 31, 0) },
                new Personnel() { PersonnelId = 85, Rank = Grade.E4, FirstName = "Curran", LastName = "Eydel", MiddleName = "Shandee", Sex = BioSex.Female, SSN = "589-66-7831", DOD = "1931864241", DOB = new DateTime(1993, 12, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 11, 00, 36, 0) },
                new Personnel() { PersonnelId = 86, Rank = Grade.E4, FirstName = "Verge", LastName = "Klaassens", Sex = BioSex.Male, SSN = "492-53-8910", DOD = "5824673772", DOB = new DateTime(1960, 01, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 14, 03, 30, 0) },
                new Personnel() { PersonnelId = 87, Rank = Grade.E5, FirstName = "Lorita", LastName = "Hallas", Sex = BioSex.Male, SSN = "831-11-5943", DOD = "2778206906", DOB = new DateTime(1987, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 14, 05, 36, 0) },
                new Personnel() { PersonnelId = 88, Rank = Grade.O1, FirstName = "Cris", LastName = "Bredgeland", MiddleName = "Kayle", Sex = BioSex.Male, SSN = "896-82-4495", DOD = "7421722734", DOB = new DateTime(1973, 02, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 14, 05, 38, 0) },
                new Personnel() { PersonnelId = 89, Rank = Grade.E2, FirstName = "Teriann", LastName = "Stonehouse", MiddleName = "Corny", Sex = BioSex.Male, SSN = "504-92-4277", DOD = "1641109556", DOB = new DateTime(1979, 12, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 12, 01, 32, 0) },
                new Personnel() { PersonnelId = 90, Rank = Grade.E5, FirstName = "Garrard", LastName = "Roskrug", MiddleName = "Melody", Sex = BioSex.Male, SSN = "190-10-7901", DOD = "5002987370", DOB = new DateTime(1984, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 12, 08, 34, 0) },
                new Personnel() { PersonnelId = 91, Rank = Grade.E2, FirstName = "Donnie", LastName = "Aggis", MiddleName = "Findley", Sex = BioSex.Female, SSN = "832-76-4580", DOD = "5715324815", DOB = new DateTime(1977, 01, 17, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 12, 07, 38, 0) },
                new Personnel() { PersonnelId = 92, Rank = Grade.E3, FirstName = "Marsh", LastName = "Sandeman", MiddleName = "Seymour", Sex = BioSex.Other, SSN = "803-60-2090", DOD = "4810472841", DOB = new DateTime(1993, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 18, 09, 30, 0) },
                new Personnel() { PersonnelId = 93, Rank = Grade.O1, FirstName = "Fonzie", LastName = "Sandercock", MiddleName = "Brynn", Sex = BioSex.Male, SSN = "384-01-8020", DOD = "5094570463", DOB = new DateTime(1956, 02, 24, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 13, 04, 30, 0) },
                new Personnel() { PersonnelId = 94, Rank = Grade.E2, FirstName = "Liane", LastName = "Heinsh", MiddleName = "Rutger", Sex = BioSex.Male, SSN = "191-03-0896", DOD = "0166819484", DOB = new DateTime(1988, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 17, 08, 36, 0) },
                new Personnel() { PersonnelId = 95, Rank = Grade.E1, FirstName = "Kerry", LastName = "Georgeon", Sex = BioSex.Female, SSN = "395-31-3533", DOD = "7155436232", DOB = new DateTime(1997, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 11, 01, 36, 0) },
                new Personnel() { PersonnelId = 96, Rank = Grade.E6, FirstName = "Karin", LastName = "Mothersdale", MiddleName = "Essie", Sex = BioSex.Other, SSN = "486-42-7962", DOD = "0086050281", DOB = new DateTime(1991, 12, 16, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 15, 08, 39, 0) },
                new Personnel() { PersonnelId = 97, Rank = Grade.E5, FirstName = "Jess", LastName = "Heathcote", Sex = BioSex.Male, SSN = "459-89-9583", DOD = "5724741512", DOB = new DateTime(1998, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 16, 05, 34, 0) },
                new Personnel() { PersonnelId = 98, Rank = Grade.E1, FirstName = "Johann", LastName = "Kuscha", MiddleName = "Kayne", Sex = BioSex.Male, SSN = "327-06-1341", DOD = "6820526202", DOB = new DateTime(1988, 01, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 12, 03, 34, 0) },
                new Personnel() { PersonnelId = 99, Rank = Grade.E2, FirstName = "Sadye", LastName = "Sherston", Sex = BioSex.Male, SSN = "486-21-9416", DOD = "0784977267", DOB = new DateTime(1999, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 12, 05, 39, 0) },
                new Personnel() { PersonnelId = 100, Rank = Grade.E4, FirstName = "Tamiko", LastName = "Pales", Sex = BioSex.Female, SSN = "551-91-7188", DOD = "9384088145", DOB = new DateTime(1988, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 11, 00, 35, 0) },
                new Personnel() { PersonnelId = 101, Rank = Grade.E3, FirstName = "Selina", LastName = "Acuna", MiddleName = "Tim", Sex = BioSex.Other, SSN = "484-80-0443", DOD = "2486829970", DOB = new DateTime(1963, 02, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 00, 30, 0) },
                new Personnel() { PersonnelId = 102, Rank = Grade.E5, FirstName = "Rene", LastName = "Burtonwood", MiddleName = "Jaclyn", Sex = BioSex.Female, SSN = "302-03-2706", DOD = "8556652344", DOB = new DateTime(1981, 02, 23, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 02, 31, 0) },
                new Personnel() { PersonnelId = 103, Rank = Grade.E2, FirstName = "Basile", LastName = "Sperski", MiddleName = "Ario", Sex = BioSex.Male, SSN = "193-67-0244", DOD = "6262636625", DOB = new DateTime(1995, 01, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 10, 03, 34, 0) },
                new Personnel() { PersonnelId = 104, Rank = Grade.E1, FirstName = "Brandea", LastName = "Grewer", MiddleName = "Vick", Sex = BioSex.Male, SSN = "561-24-5933", DOD = "9964102623", DOB = new DateTime(1990, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 19, 06, 37, 0) },
                new Personnel() { PersonnelId = 105, Rank = Grade.W2, FirstName = "Dara", LastName = "Clowser", Sex = BioSex.Female, SSN = "584-85-1419", DOD = "5093323527", DOB = new DateTime(1996, 02, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 19, 09, 31, 0) },
                new Personnel() { PersonnelId = 106, Rank = Grade.E7, FirstName = "Natalie", LastName = "Canavan", MiddleName = "Meridel", Sex = BioSex.Male, SSN = "225-68-5730", DOD = "8024034786", DOB = new DateTime(1952, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 13, 07, 32, 0) },
                new Personnel() { PersonnelId = 107, Rank = Grade.E6, FirstName = "Dev", LastName = "Rough", MiddleName = "Merissa", Sex = BioSex.Male, SSN = "326-78-6526", DOD = "7116696652", DOB = new DateTime(1995, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 12, 01, 36, 0) },
                new Personnel() { PersonnelId = 108, Rank = Grade.E5, FirstName = "Lorelei", LastName = "Humpherson", MiddleName = "Tierney", Sex = BioSex.Female, SSN = "823-20-0008", DOD = "0846209322", DOB = new DateTime(1969, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 13, 03, 32, 0) },
                new Personnel() { PersonnelId = 109, Rank = Grade.O1, FirstName = "Ewen", LastName = "Waldocke", Sex = BioSex.Female, SSN = "435-88-8752", DOD = "9537052346", DOB = new DateTime(1977, 12, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 16, 02, 38, 0) },
                new Personnel() { PersonnelId = 110, Rank = Grade.E4, FirstName = "Sherm", LastName = "Ciobutaro", MiddleName = "Christel", Sex = BioSex.Male, SSN = "241-87-6326", DOD = "5350293818", DOB = new DateTime(1987, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 03, 34, 0) },
                new Personnel() { PersonnelId = 111, Rank = Grade.E8, FirstName = "Benedict", LastName = "Standish-Brooks", MiddleName = "Silvio", Sex = BioSex.Male, SSN = "157-10-2736", DOD = "9916341842", DOB = new DateTime(1951, 12, 19, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 15, 00, 35, 0) },
                new Personnel() { PersonnelId = 112, Rank = Grade.E3, FirstName = "Clarance", LastName = "Sandever", MiddleName = "Phip", Sex = BioSex.Female, SSN = "269-94-1763", DOD = "6892343368", DOB = new DateTime(1956, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 15, 04, 32, 0) },
                new Personnel() { PersonnelId = 113, Rank = Grade.E6, FirstName = "Karlis", LastName = "Fidelli", Sex = BioSex.Male, SSN = "613-37-2129", DOD = "1696667429", DOB = new DateTime(1994, 01, 05, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 10, 03, 30, 0) },
                new Personnel() { PersonnelId = 114, Rank = Grade.E4, FirstName = "Allianora", LastName = "Becken", MiddleName = "Zebulon", Sex = BioSex.Male, SSN = "543-04-9487", DOD = "8731709117", DOB = new DateTime(1998, 01, 07, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 12, 05, 30, 0) },
                new Personnel() { PersonnelId = 115, Rank = Grade.E2, FirstName = "Rosalynd", LastName = "Blandamere", MiddleName = "Farlie", Sex = BioSex.Male, SSN = "408-06-8116", DOD = "1963555791", DOB = new DateTime(1999, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 14, 00, 30, 0) },
                new Personnel() { PersonnelId = 116, Rank = Grade.E2, FirstName = "Kerwinn", LastName = "Oselton", MiddleName = "Max", Sex = BioSex.Male, SSN = "782-51-4271", DOD = "7409740787", DOB = new DateTime(1989, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 14, 08, 31, 0) },
                new Personnel() { PersonnelId = 117, Rank = Grade.E1, FirstName = "Alvy", LastName = "Plevin", Sex = BioSex.Female, SSN = "276-36-3262", DOD = "8529702271", DOB = new DateTime(1999, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 11, 01, 34, 0) },
                new Personnel() { PersonnelId = 118, Rank = Grade.E1, FirstName = "Joceline", LastName = "Dybbe", MiddleName = "Loraine", Sex = BioSex.Male, SSN = "619-73-9111", DOD = "1938990846", DOB = new DateTime(1998, 11, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 12, 08, 39, 0) },
                new Personnel() { PersonnelId = 119, Rank = Grade.E4, FirstName = "Leonid", LastName = "Keher", MiddleName = "Daffy", Sex = BioSex.Female, SSN = "473-43-1958", DOD = "3177246807", DOB = new DateTime(1966, 02, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 12, 03, 39, 0) },
                new Personnel() { PersonnelId = 120, Rank = Grade.E2, FirstName = "Katheryn", LastName = "Mole", MiddleName = "Hortense", Sex = BioSex.Male, SSN = "895-82-6213", DOD = "6160636219", DOB = new DateTime(1997, 02, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 14, 06, 36, 0) },
                new Personnel() { PersonnelId = 121, Rank = Grade.W2, FirstName = "Alonso", LastName = "Trustie", MiddleName = "Maurine", Sex = BioSex.Male, SSN = "335-74-5227", DOD = "1769210466", DOB = new DateTime(1984, 11, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 15, 03, 30, 0) },
                new Personnel() { PersonnelId = 122, Rank = Grade.E6, FirstName = "Barbra", LastName = "Joskowitz", MiddleName = "Spike", Sex = BioSex.Male, SSN = "279-03-8598", DOD = "2963901046", DOB = new DateTime(1988, 02, 16, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 18, 09, 36, 0) },
                new Personnel() { PersonnelId = 123, Rank = Grade.E4, FirstName = "Netty", LastName = "Yewen", MiddleName = "Susanna", Sex = BioSex.Male, SSN = "595-37-1179", DOD = "9053729550", DOB = new DateTime(1959, 02, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 05, 38, 0) },
                new Personnel() { PersonnelId = 124, Rank = Grade.E2, FirstName = "Dorise", LastName = "Cousen", Sex = BioSex.Male, SSN = "347-55-8700", DOD = "4799906291", DOB = new DateTime(1980, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 17, 02, 33, 0) },
                new Personnel() { PersonnelId = 125, Rank = Grade.E5, FirstName = "Nadiya", LastName = "Serrier", MiddleName = "Ted", Sex = BioSex.Female, SSN = "292-85-6624", DOD = "8965935059", DOB = new DateTime(1986, 11, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 08, 39, 0) },
                new Personnel() { PersonnelId = 126, Rank = Grade.E5, FirstName = "Powell", LastName = "Mousdall", MiddleName = "Iseabal", Sex = BioSex.Female, SSN = "760-86-2293", DOD = "6433741746", DOB = new DateTime(1999, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 10, 08, 39, 0) },
                new Personnel() { PersonnelId = 127, Rank = Grade.W2, FirstName = "Verena", LastName = "Hugonnet", MiddleName = "Olympia", Sex = BioSex.Male, SSN = "684-61-6577", DOD = "7859900351", DOB = new DateTime(1993, 01, 28, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 06, 32, 0) },
                new Personnel() { PersonnelId = 128, Rank = Grade.E2, FirstName = "Latrina", LastName = "Pimblotte", MiddleName = "Josselyn", Sex = BioSex.Other, SSN = "747-95-2175", DOD = "0705827976", DOB = new DateTime(1974, 12, 09, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 15, 00, 35, 0) },
                new Personnel() { PersonnelId = 129, Rank = Grade.E2, FirstName = "Angeline", LastName = "Tuny", Sex = BioSex.Male, SSN = "562-20-2674", DOD = "7692753148", DOB = new DateTime(1954, 11, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 16, 04, 36, 0) },
                new Personnel() { PersonnelId = 130, Rank = Grade.E1, FirstName = "Lora", LastName = "Handrek", MiddleName = "Abbi", Sex = BioSex.Female, SSN = "134-47-9095", DOD = "5888755966", DOB = new DateTime(1956, 12, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 10, 03, 34, 0) },
                new Personnel() { PersonnelId = 131, Rank = Grade.E1, FirstName = "Edgardo", LastName = "Fassbender", Sex = BioSex.Male, SSN = "688-98-9546", DOD = "5377969863", DOB = new DateTime(1991, 01, 25, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 10, 03, 37, 0) },
                new Personnel() { PersonnelId = 132, Rank = Grade.O2, FirstName = "Vivianna", LastName = "Brayley", MiddleName = "Sonni", Sex = BioSex.Other, SSN = "330-90-6685", DOD = "8781985703", DOB = new DateTime(1966, 02, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 12, 02, 34, 0) },
                new Personnel() { PersonnelId = 133, Rank = Grade.E4, FirstName = "Hall", LastName = "Ramberg", Sex = BioSex.Male, SSN = "412-59-4314", DOD = "0965863557", DOB = new DateTime(1957, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 13, 09, 31, 0) },
                new Personnel() { PersonnelId = 134, Rank = Grade.E4, FirstName = "Gan", LastName = "Van der Hoven", Sex = BioSex.Female, SSN = "245-17-6764", DOD = "8421732595", DOB = new DateTime(1971, 02, 06, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 13, 06, 39, 0) },
                new Personnel() { PersonnelId = 135, Rank = Grade.E6, FirstName = "Kizzie", LastName = "De Blase", MiddleName = "Sal", Sex = BioSex.Female, SSN = "187-86-9282", DOD = "9445539826", DOB = new DateTime(1990, 01, 06, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 19, 02, 36, 0) },
                new Personnel() { PersonnelId = 136, Rank = Grade.E3, FirstName = "Graehme", LastName = "Yedy", MiddleName = "Angelle", Sex = BioSex.Male, SSN = "693-38-3028", DOD = "0503478148", DOB = new DateTime(1953, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 19, 01, 30, 0) },
                new Personnel() { PersonnelId = 137, Rank = Grade.E2, FirstName = "Ford", LastName = "Filippone", MiddleName = "Hatty", Sex = BioSex.Male, SSN = "296-34-8694", DOD = "1463927770", DOB = new DateTime(1990, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 19, 06, 38, 0) },
                new Personnel() { PersonnelId = 138, Rank = Grade.O2, FirstName = "Elmore", LastName = "Lindsay", Sex = BioSex.Male, SSN = "134-42-5597", DOD = "2888744244", DOB = new DateTime(1994, 01, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Personnel() { PersonnelId = 139, Rank = Grade.E4, FirstName = "Francklin", LastName = "Seyffert", MiddleName = "Corrinne", Sex = BioSex.Male, SSN = "533-17-9154", DOD = "5402600872", DOB = new DateTime(1992, 02, 17, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 19, 03, 33, 0) },
                new Personnel() { PersonnelId = 140, Rank = Grade.E4, FirstName = "Renado", LastName = "Marston", MiddleName = "Aridatha", Sex = BioSex.Male, SSN = "167-45-6329", DOD = "7581744396", DOB = new DateTime(1991, 12, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 18, 04, 34, 0) },
                new Personnel() { PersonnelId = 141, Rank = Grade.E5, FirstName = "Marrilee", LastName = "Gaitskell", MiddleName = "Leann", Sex = BioSex.Male, SSN = "690-21-3582", DOD = "7189522700", DOB = new DateTime(1992, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 19, 09, 37, 0) },
                new Personnel() { PersonnelId = 142, Rank = Grade.E2, FirstName = "Gerhardine", LastName = "Carloni", MiddleName = "Verine", SSN = "599-84-8931", DOD = "9469374541", DOB = new DateTime(1988, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 02, 34, 0) },
                new Personnel() { PersonnelId = 143, Rank = Grade.O1, FirstName = "Nerty", LastName = "Spight", Sex = BioSex.Male, SSN = "776-23-8756", DOD = "3239742160", DOB = new DateTime(1994, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 10, 08, 39, 0) },
                new Personnel() { PersonnelId = 144, Rank = Grade.E4, FirstName = "Talbot", LastName = "Nason", Sex = BioSex.Female, SSN = "381-84-2699", DOD = "7614985877", DOB = new DateTime(1991, 12, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 12, 00, 37, 0) },
                new Personnel() { PersonnelId = 145, Rank = Grade.E8, FirstName = "Norrie", LastName = "Rudall", MiddleName = "Minerva", Sex = BioSex.Male, SSN = "762-44-5471", DOD = "2399144619", DOB = new DateTime(1999, 12, 26, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 17, 01, 36, 0) },
                new Personnel() { PersonnelId = 146, Rank = Grade.E4, FirstName = "Savina", LastName = "Payze", MiddleName = "Kenn", Sex = BioSex.Male, SSN = "659-90-3369", DOD = "9665139452", DOB = new DateTime(1980, 11, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 14, 00, 36, 0) },
                new Personnel() { PersonnelId = 147, Rank = Grade.E3, FirstName = "Kizzie", LastName = "Waulker", MiddleName = "Osgood", Sex = BioSex.Male, SSN = "171-91-2628", DOD = "0787886009", DOB = new DateTime(1992, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 15, 02, 37, 0) },
                new Personnel() { PersonnelId = 148, Rank = Grade.E2, FirstName = "Sallyann", LastName = "Bremmell", MiddleName = "Stephani", Sex = BioSex.Female, SSN = "224-09-2136", DOD = "2170341676", DOB = new DateTime(1988, 11, 16, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 14, 00, 37, 0) },
                new Personnel() { PersonnelId = 149, Rank = Grade.E4, FirstName = "Emlynn", LastName = "L'Episcopio", MiddleName = "Kit", Sex = BioSex.Male, SSN = "567-82-0662", DOD = "5732837531", DOB = new DateTime(1985, 01, 08, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 10, 05, 39, 0) },
                new Personnel() { PersonnelId = 150, Rank = Grade.E4, FirstName = "Elianore", LastName = "Lennie", MiddleName = "Brocky", Sex = BioSex.Male, SSN = "253-54-5134", DOD = "8891096776", DOB = new DateTime(1955, 12, 18, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 15, 06, 32, 0) },
                new Personnel() { PersonnelId = 151, Rank = Grade.E8, FirstName = "Mohandis", LastName = "Emmott", MiddleName = "Pancho", Sex = BioSex.Male, SSN = "774-14-6294", DOD = "4982240272", DOB = new DateTime(1993, 02, 08, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 18, 05, 31, 0) },
                new Personnel() { PersonnelId = 152, Rank = Grade.E4, FirstName = "Micky", LastName = "Maidment", MiddleName = "Adora", Sex = BioSex.Female, SSN = "242-15-4363", DOD = "8349825111", DOB = new DateTime(1992, 11, 23, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 15, 09, 37, 0) },
                new Personnel() { PersonnelId = 153, Rank = Grade.E4, FirstName = "Beauregard", LastName = "Mateiko", MiddleName = "Jena", Sex = BioSex.Male, SSN = "665-68-3867", DOD = "2071303873", DOB = new DateTime(1997, 02, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Estranged, CreatedUtc = new DateTime(2020, 11, 14, 03, 30, 0) },
                new Personnel() { PersonnelId = 154, Rank = Grade.E5, FirstName = "Cordelie", LastName = "Sante", MiddleName = "Sloan", Sex = BioSex.Male, SSN = "799-32-0528", DOD = "4941755030", DOB = new DateTime(1990, 11, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 15, 04, 36, 0) },
                new Personnel() { PersonnelId = 155, Rank = Grade.E3, FirstName = "Mikael", LastName = "Thumnel", Sex = BioSex.Female, SSN = "288-96-1802", DOD = "4334597203", DOB = new DateTime(1964, 01, 17, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 16, 08, 30, 0) },
                new Personnel() { PersonnelId = 156, Rank = Grade.E4, FirstName = "Adelle", LastName = "Medwell", Sex = BioSex.Female, SSN = "230-57-4911", DOD = "2137930439", DOB = new DateTime(1996, 12, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 19, 03, 35, 0) },
                new Personnel() { PersonnelId = 157, Rank = Grade.E2, FirstName = "Stacee", LastName = "Wilkisson", MiddleName = "Faina", Sex = BioSex.Male, SSN = "186-48-9856", DOD = "3698438046", DOB = new DateTime(1977, 12, 09, 0, 0, 0), MaritalStatus = MaritalStatus.Married, CreatedUtc = new DateTime(2020, 11, 16, 03, 32, 0) },
                new Personnel() { PersonnelId = 158, Rank = Grade.E4, FirstName = "Danyelle", LastName = "Walder", Sex = BioSex.Female, SSN = "711-39-1195", DOD = "0291385982", DOB = new DateTime(1956, 12, 18, 0, 0, 0), MaritalStatus = MaritalStatus.Divorced, CreatedUtc = new DateTime(2020, 11, 12, 00, 30, 0) },
                new Personnel() { PersonnelId = 159, Rank = Grade.E4, FirstName = "Arturo", LastName = "Peschke", MiddleName = "Linzy", Sex = BioSex.Male, SSN = "547-87-6906", DOD = "4134094909", DOB = new DateTime(1973, 11, 28, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 15, 05, 30, 0) },
                new Personnel() { PersonnelId = 160, Rank = Grade.W2, FirstName = "Gregor", LastName = "Hupe", MiddleName = "Ermanno", Sex = BioSex.Male, SSN = "508-61-0496", DOD = "6418688287", DOB = new DateTime(1997, 11, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 10, 03, 35, 0) },
                new Personnel() { PersonnelId = 161, Rank = Grade.E1, FirstName = "Isabeau", LastName = "Neles", SSN = "234-93-4375", DOD = "1184263817", DOB = new DateTime(1984, 11, 08, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 10, 06, 33, 0) },
                new Personnel() { PersonnelId = 162, Rank = Grade.E3, FirstName = "Melly", LastName = "Snawdon", Sex = BioSex.Male, SSN = "417-69-5005", DOD = "0389412767", DOB = new DateTime(1983, 02, 24, 0, 0, 0), MaritalStatus = MaritalStatus.Widowed, CreatedUtc = new DateTime(2020, 11, 13, 02, 34, 0) },
                new Personnel() { PersonnelId = 163, Rank = Grade.E1, FirstName = "Arie", LastName = "Rennenbach", MiddleName = "Wadsworth", Sex = BioSex.Male, SSN = "799-27-6696", DOD = "8422916606", DOB = new DateTime(1981, 01, 29, 0, 0, 0), MaritalStatus = MaritalStatus.NeverMarried, CreatedUtc = new DateTime(2020, 11, 11, 01, 33, 0) },
                new Personnel() { PersonnelId = 164, Rank = Grade.E5, FirstName = "Nannette", LastName = "Thake", MiddleName = "Wheeler", Sex = BioSex.Male, SSN = "807-52-0560", DOD = "9653210580", DOB = new DateTime(1987, 01, 19, 0, 0, 0), MaritalStatus = MaritalStatus.Other, CreatedUtc = new DateTime(2020, 11, 17, 06, 36, 0) }
                );
            //Seed Contact
            context.ContactDbSet.AddOrUpdate(x => x.Id,
                new Contact() { Id = 1, PersonnelId = 1, PhoneNumber = "(031) 101-8533", PersonalEmail = "tedmeads0@intel.com", HasDriversLicense = true, VehicleMake = "Volkswagen", VehicleModel = "Cabriolet", VehiclePlate = "AYBJ34", VehicleYear = 1989, CreatedUtc = new DateTime(2020, 11, 19, 08, 32, 0) },
                new Contact() { Id = 2, PersonnelId = 2, PhoneNumber = "(738) 919-3175", PersonalEmail = "slytlle1@cbslocal.com", HasDriversLicense = true, VehicleMake = "Cadillac", VehicleModel = "CTS", VehiclePlate = "BG9494", VehicleYear = 2010, CreatedUtc = new DateTime(2020, 11, 19, 03, 32, 0) },
                new Contact() { Id = 3, PersonnelId = 3, PhoneNumber = "(711) 896-7090", PersonalEmail = "mcallaway2@ifeng.com", HasDriversLicense = false, VehicleMake = "Audi", VehicleModel = "Q7", VehicleColor = "Puce", VehiclePlate = "RHQX67", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 04, 39, 0) },
                new Contact() { Id = 4, PersonnelId = 4, PersonalEmail = "gthurlow3@latimes.com", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "APV", VehiclePlate = "SPL588", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 07, 37, 0) },
                new Contact() { Id = 5, PersonnelId = 5, PhoneNumber = "(610) 797-3161", HasDriversLicense = false, VehicleMake = "Infiniti", VehicleModel = "J", VehicleColor = "Teal", VehiclePlate = "BEMF35", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 08, 39, 0) },
                new Contact() { Id = 6, PersonnelId = 6, PhoneNumber = "(796) 649-3351", HasDriversLicense = false, VehicleMake = "Austin", VehicleModel = "Mini Cooper", VehiclePlate = "AGJT59", VehicleYear = 1964, CreatedUtc = new DateTime(2020, 11, 19, 01, 30, 0) },
                new Contact() { Id = 7, PersonnelId = 7, PhoneNumber = "(204) 704-1851", PersonalEmail = "sdenison6@dell.com", MilEmail = "Deann.s.Harvey.mil@mail.mil", HasDriversLicense = false, VehicleMake = "BMW", VehicleModel = "M Roadster", VehiclePlate = "BC3G42", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 07, 38, 0) },
                new Contact() { Id = 8, PersonnelId = 8, PhoneNumber = "(291) 136-7923", PersonalEmail = "rkingwell7@buzzfeed.com", HasDriversLicense = true, VehicleMake = "Chrysler", VehicleModel = "Town & Country", VehicleColor = "Khaki", VehiclePlate = "CZ4981", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 01, 38, 0) },
                new Contact() { Id = 9, PersonnelId = 9, PhoneNumber = "(017) 094-2289", PersonalEmail = "lmedlin8@soundcloud.com", HasDriversLicense = false, VehicleMake = "Acura", VehicleModel = "TSX", VehicleColor = "Violet", VehiclePlate = "NXMP83", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 03, 35, 0) },
                new Contact() { Id = 10, PersonnelId = 10, PhoneNumber = "(949) 161-3661", PersonalEmail = "gmcharry9@mayoclinic.com", HasDriversLicense = false, VehicleMake = "Mazda", VehicleModel = "MX-5", VehiclePlate = "CW5H40", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 02, 32, 0) },
                new Contact() { Id = 11, PersonnelId = 11, PhoneNumber = "(134) 877-4383", PersonalEmail = "wmccoida@printfriendly.com", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Express 3500", VehicleColor = "Aquamarine", VehiclePlate = "XKS584", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 03, 37, 0) },
                new Contact() { Id = 12, PersonnelId = 12, PhoneNumber = "(876) 158-2626", PersonalEmail = "jmaclavertyb@spotify.com", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "Pajero", VehicleColor = "Mauv", VehiclePlate = "FZXB20", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 05, 32, 0) },
                new Contact() { Id = 13, PersonnelId = 13, PhoneNumber = "(855) 688-1335", PersonalEmail = "ianstyc@guardian.co.uk", HasDriversLicense = false, VehicleMake = "Volkswagen", VehicleModel = "Touareg", VehicleColor = "Green", VehiclePlate = "NGXM25", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 04, 32, 0) },
                new Contact() { Id = 14, PersonnelId = 14, PhoneNumber = "(657) 528-6871", PersonalEmail = "odalrympled@virginia.edu", HasDriversLicense = false, VehicleMake = "Buick", VehicleModel = "Regal", VehicleColor = "Blue", VehiclePlate = "LM6E81", VehicleYear = 1999, CreatedUtc = new DateTime(2020, 11, 19, 06, 39, 0) },
                new Contact() { Id = 15, PersonnelId = 15, PhoneNumber = "(275) 115-3406", PersonalEmail = "mtumbeltye@gizmodo.com", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "Thunderbird", VehicleColor = "Teal", VehiclePlate = "OI9T27", VehicleYear = 1983, CreatedUtc = new DateTime(2020, 11, 19, 09, 37, 0) },
                new Contact() { Id = 16, PersonnelId = 16, PhoneNumber = "(854) 671-9093", PersonalEmail = "cfaulksf@uiuc.edu", MilEmail = "Russ.s.Doyle.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "Mirage", VehicleColor = "Yellow", VehiclePlate = "UWMP62", VehicleYear = 1991, CreatedUtc = new DateTime(2020, 11, 19, 04, 34, 0) },
                new Contact() { Id = 17, PersonnelId = 17, PhoneNumber = "(825) 777-9807", PersonalEmail = "shecksg@cornell.edu", HasDriversLicense = true, VehicleMake = "Nissan", VehicleModel = "Pathfinder Armada", VehiclePlate = "VO0V83", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 02, 38, 0) },
                new Contact() { Id = 18, PersonnelId = 18, PhoneNumber = "(024) 411-8123", PersonalEmail = "echapiroh@dedecms.com", HasDriversLicense = true, VehicleMake = "Mitsubishi", VehicleModel = "Eclipse", VehicleColor = "Maroon", VehiclePlate = "LID107", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 09, 31, 0) },
                new Contact() { Id = 19, PersonnelId = 19, PhoneNumber = "(149) 782-6578", PersonalEmail = "mkibbyi@edublogs.org", HasDriversLicense = true, VehicleMake = "Nissan", VehicleModel = "350Z", VehicleColor = "Indigo", VehiclePlate = "HWIB47", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 06, 35, 0) },
                new Contact() { Id = 20, PersonnelId = 20, PhoneNumber = "(829) 218-6774", PersonalEmail = "metheredgej@g.co", HasDriversLicense = false, VehicleMake = "Hyundai", VehicleModel = "Scoupe", VehiclePlate = "YJOH65", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 00, 36, 0) },
                new Contact() { Id = 21, PersonnelId = 21, PhoneNumber = "(892) 296-5284", PersonalEmail = "apaddenk@japanpost.jp", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "Diamante", VehicleColor = "Orange", VehiclePlate = "EJU985", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 06, 37, 0) },
                new Contact() { Id = 22, PersonnelId = 22, PhoneNumber = "(365) 286-6511", PersonalEmail = "mrydingl@woothemes.com", HasDriversLicense = true, VehicleMake = "Lexus", VehicleModel = "IS-F", VehicleColor = "Fuscia", VehiclePlate = "SD2V13", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 02, 36, 0) },
                new Contact() { Id = 23, PersonnelId = 23, PhoneNumber = "(141) 418-1912", PersonalEmail = "ajoninm@ning.com", HasDriversLicense = false, VehicleMake = "BMW", VehicleModel = "M6", VehiclePlate = "PYIY44", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 09, 35, 0) },
                new Contact() { Id = 24, PersonnelId = 24, PhoneNumber = "(213) 143-6573", PersonalEmail = "gskipponn@over-blog.com", HasDriversLicense = false, VehicleMake = "Toyota", VehicleModel = "Highlander", VehicleColor = "Purple", VehiclePlate = "ZUGC24", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 03, 30, 0) },
                new Contact() { Id = 25, PersonnelId = 25, PhoneNumber = "(846) 759-7506", PersonalEmail = "aaldwicho@mediafire.com", HasDriversLicense = true, VehicleMake = "Chevrolet", VehicleModel = "Corvette", VehicleColor = "Turquoise", VehiclePlate = "TSXU69", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 01, 35, 0) },
                new Contact() { Id = 26, PersonnelId = 26, PhoneNumber = "(971) 872-7462", PersonalEmail = "umcbeanp@alibaba.com", MilEmail = "Geraldine.m.Hansen.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Ford", VehicleModel = "Bronco", VehicleColor = "Blue", VehiclePlate = "OHBT56", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 02, 35, 0) },
                new Contact() { Id = 27, PersonnelId = 27, PhoneNumber = "(164) 315-8538", PersonalEmail = "pprinnq@nhs.uk", MilEmail = "Marva.t.Ondricka.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "Sunbird", VehiclePlate = "NAG937", VehicleYear = 1987, CreatedUtc = new DateTime(2020, 11, 19, 04, 33, 0) },
                new Contact() { Id = 28, PersonnelId = 28, PhoneNumber = "(778) 332-5285", HasDriversLicense = false, VehicleColor = "Puce", VehicleYear = 2011, CreatedUtc = new DateTime(2020, 11, 19, 08, 37, 0) },
                new Contact() { Id = 29, PersonnelId = 29, PhoneNumber = "(472) 730-1499", PersonalEmail = "dpitrassos@marriott.com", HasDriversLicense = true, VehicleMake = "Lincoln", VehicleModel = "Town Car", VehiclePlate = "BBHF68", VehicleYear = 1987, CreatedUtc = new DateTime(2020, 11, 19, 00, 35, 0) },
                new Contact() { Id = 30, PersonnelId = 30, PhoneNumber = "(864) 902-7554", PersonalEmail = "hruckmant@bbb.org", HasDriversLicense = false, VehicleMake = "Infiniti", VehicleModel = "QX", VehicleColor = "Puce", VehiclePlate = "PEJK44", VehicleYear = 1999, CreatedUtc = new DateTime(2020, 11, 19, 00, 31, 0) },
                new Contact() { Id = 31, PersonnelId = 31, PhoneNumber = "(149) 626-2848", PersonalEmail = "jparamoreu@go.com", HasDriversLicense = false, VehicleMake = "Lamborghini", VehicleModel = "Gallardo", VehicleColor = "Red", VehiclePlate = "BX3P40", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 09, 35, 0) },
                new Contact() { Id = 32, PersonnelId = 32, PhoneNumber = "(438) 614-9885", HasDriversLicense = true, VehicleMake = "Mitsubishi", VehicleModel = "Starion", VehicleColor = "Indigo", VehiclePlate = "EHCA25", VehicleYear = 1987, CreatedUtc = new DateTime(2020, 11, 19, 02, 34, 0) },
                new Contact() { Id = 33, PersonnelId = 33, PhoneNumber = "(978) 557-0442", HasDriversLicense = false, VehicleMake = "Mazda", VehicleModel = "B-Series", VehiclePlate = "PLKT00", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 06, 30, 0) },
                new Contact() { Id = 34, PersonnelId = 34, PhoneNumber = "(053) 481-4455", PersonalEmail = "efernex@moonfruit.com", HasDriversLicense = true, VehicleMake = "Acura", VehicleModel = "Vigor", VehiclePlate = "IY0N31", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 07, 36, 0) },
                new Contact() { Id = 35, PersonnelId = 35, PhoneNumber = "(137) 690-7625", PersonalEmail = "rarmatidgey@smugmug.com", MilEmail = "Angel.o.Schmidt.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Bentley", VehicleModel = "Continental", VehicleColor = "Blue", VehiclePlate = "SAG697", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 07, 37, 0) },
                new Contact() { Id = 36, PersonnelId = 36, PhoneNumber = "(370) 274-8389", PersonalEmail = "aburrasz@sbwire.com", MilEmail = "Ivory.c.McDermott.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "LeMans", VehicleColor = "Puce", VehiclePlate = "AZ2783", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 07, 38, 0) },
                new Contact() { Id = 37, PersonnelId = 37, PhoneNumber = "(795) 088-6579", HasDriversLicense = true, VehicleMake = "Scion", VehicleModel = "xB", VehiclePlate = "JK5N39", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 03, 38, 0) },
                new Contact() { Id = 38, PersonnelId = 38, PhoneNumber = "(789) 306-7353", PersonalEmail = "jsidlow11@google.de", HasDriversLicense = true, VehicleMake = "Volkswagen", VehicleModel = "Cabriolet", VehicleColor = "Aquamarine", VehiclePlate = "IBCD21", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 05, 33, 0) },
                new Contact() { Id = 39, PersonnelId = 39, PhoneNumber = "(919) 710-5929", PersonalEmail = "tjerzycowski12@ibm.com", MilEmail = "Laraine.a.Will.mil@mail.mil", HasDriversLicense = false, VehicleMake = "GMC", VehicleModel = "Suburban 1500", VehiclePlate = "NMJS78", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 07, 38, 0) },
                new Contact() { Id = 40, PersonnelId = 40, PhoneNumber = "(014) 662-8472", PersonalEmail = "jfalkus13@digg.com", HasDriversLicense = false, VehicleMake = "Jaguar", VehicleModel = "S-Type", VehicleColor = "Turquoise", VehiclePlate = "YB6G72", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 02, 39, 0) },
                new Contact() { Id = 41, PersonnelId = 41, PhoneNumber = "(228) 432-8328", PersonalEmail = "rpalek14@nasa.gov", HasDriversLicense = false, VehicleMake = "Toyota", VehicleModel = "Sienna", VehiclePlate = "YO9X29", VehicleYear = 2005, CreatedUtc = new DateTime(2020, 11, 19, 06, 39, 0) },
                new Contact() { Id = 42, PersonnelId = 42, PhoneNumber = "(998) 098-9358", PersonalEmail = "lygo15@google.com.br", MilEmail = "Azzie.r.Jerde.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Porsche", VehicleModel = "Cayman", VehiclePlate = "SZL779", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 06, 32, 0) },
                new Contact() { Id = 43, PersonnelId = 43, PhoneNumber = "(652) 715-1448", PersonalEmail = "hgilgryst16@va.gov", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "Festiva", VehicleColor = "Red", VehiclePlate = "AIEC78", VehicleYear = 1988, CreatedUtc = new DateTime(2020, 11, 19, 04, 31, 0) },
                new Contact() { Id = 44, PersonnelId = 44, PhoneNumber = "(880) 321-1495", PersonalEmail = "tchevolleau17@omniture.com", MilEmail = "Marcy.n.Hessel.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Plymouth", VehicleModel = "Grand Voyager", VehicleColor = "Puce", VehiclePlate = "PHM662", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 09, 37, 0) },
                new Contact() { Id = 45, PersonnelId = 45, PhoneNumber = "(852) 184-2970", PersonalEmail = "mlightbown18@cdbaby.com", HasDriversLicense = false, VehicleMake = "Acura", VehicleModel = "RL", VehicleColor = "Yellow", VehiclePlate = "IMIW41", VehicleYear = 2010, CreatedUtc = new DateTime(2020, 11, 19, 00, 39, 0) },
                new Contact() { Id = 46, PersonnelId = 46, PhoneNumber = "(313) 490-7119", PersonalEmail = "yaudsley19@weather.com", HasDriversLicense = false, VehicleMake = "GMC", VehicleModel = "Vandura G3500", VehicleColor = "Violet", VehiclePlate = "GMOH61", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 06, 36, 0) },
                new Contact() { Id = 47, PersonnelId = 47, PhoneNumber = "(336) 640-7625", PersonalEmail = "tripley1a@umich.edu", HasDriversLicense = true, VehicleMake = "Subaru", VehicleModel = "Outback", VehicleColor = "Mauv", VehiclePlate = "GYDL15", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 00, 36, 0) },
                new Contact() { Id = 48, PersonnelId = 48, PhoneNumber = "(346) 512-1366", PersonalEmail = "ttroak1b@smugmug.com", HasDriversLicense = true, VehicleMake = "Chevrolet", VehicleModel = "Prizm", VehicleColor = "Aquamarine", VehiclePlate = "OBTH04", VehicleYear = 1998, CreatedUtc = new DateTime(2020, 11, 19, 02, 34, 0) },
                new Contact() { Id = 49, PersonnelId = 49, PhoneNumber = "(838) 529-7506", PersonalEmail = "dedridge1c@washington.edu", HasDriversLicense = true, VehicleMake = "Chevrolet", VehicleModel = "1500", VehicleColor = "Khaki", VehiclePlate = "RCSS94", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 07, 31, 0) },
                new Contact() { Id = 50, PersonnelId = 50, PhoneNumber = "(473) 331-5365", PersonalEmail = "pbuntin1d@unblog.fr", HasDriversLicense = false, VehicleMake = "Maybach", VehicleModel = "62", VehicleColor = "Indigo", VehiclePlate = "NNJM21", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 01, 38, 0) },
                new Contact() { Id = 51, PersonnelId = 51, PhoneNumber = "(117) 602-1125", PersonalEmail = "dguilliatt1e@chron.com", HasDriversLicense = false, VehicleMake = "Toyota", VehicleModel = "Celica", VehicleColor = "Blue", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 05, 31, 0) },
                new Contact() { Id = 52, PersonnelId = 52, PersonalEmail = "rdrake1f@ask.com", HasDriversLicense = false, VehicleMake = "Jaguar", VehicleModel = "XK", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 05, 36, 0) },
                new Contact() { Id = 53, PersonnelId = 53, PhoneNumber = "(463) 739-2905", PersonalEmail = "rkelledy1g@parallels.com", HasDriversLicense = false, VehicleMake = "Daewoo", VehicleModel = "Lanos", VehicleColor = "Red", VehiclePlate = "FJZ653", VehicleYear = 2000, CreatedUtc = new DateTime(2020, 11, 19, 00, 33, 0) },
                new Contact() { Id = 54, PersonnelId = 54, PhoneNumber = "(569) 810-5386", PersonalEmail = "bcaltun1h@yandex.ru", MilEmail = "Raymon.g.D'Amore.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "Grand Am", VehicleColor = "Orange", VehiclePlate = "DWW681", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Contact() { Id = 55, PersonnelId = 55, PhoneNumber = "(843) 193-6352", PersonalEmail = "rmacaless1i@clickbank.net", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Tahoe", VehicleColor = "Turquoise", VehiclePlate = "ICXD68", VehicleYear = 2013, CreatedUtc = new DateTime(2020, 11, 19, 05, 37, 0) },
                new Contact() { Id = 56, PersonnelId = 56, PhoneNumber = "(902) 910-7345", PersonalEmail = "efillimore1j@twitter.com", HasDriversLicense = false, VehicleMake = "Hummer", VehicleModel = "H3", VehicleColor = "Yellow", VehiclePlate = "JC6Z32", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 08, 39, 0) },
                new Contact() { Id = 57, PersonnelId = 57, PhoneNumber = "(613) 883-1603", PersonalEmail = "tcurston1k@shutterfly.com", HasDriversLicense = true, VehicleMake = "Saab", VehicleModel = "9000", VehicleColor = "Puce", VehiclePlate = "HDRD75", VehicleYear = 1991, CreatedUtc = new DateTime(2020, 11, 19, 08, 34, 0) },
                new Contact() { Id = 58, PersonnelId = 58, PhoneNumber = "(766) 843-3451", PersonalEmail = "mselcraig1l@disqus.com", HasDriversLicense = true, VehicleMake = "Ford", VehicleModel = "Explorer Sport", VehiclePlate = "OOP061", VehicleYear = 2000, CreatedUtc = new DateTime(2020, 11, 19, 02, 30, 0) },
                new Contact() { Id = 59, PersonnelId = 59, PhoneNumber = "(935) 847-9647", PersonalEmail = "wvlasyev1m@oakley.com", MilEmail = "Zaida.b.Macejkovic.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "Transit Connect", VehicleColor = "Aquamarine", VehiclePlate = "XL7726", VehicleYear = 2013, CreatedUtc = new DateTime(2020, 11, 19, 01, 33, 0) },
                new Contact() { Id = 60, PersonnelId = 60, PhoneNumber = "(693) 707-3157", PersonalEmail = "mhallan1n@gizmodo.com", HasDriversLicense = false, VehicleMake = "Audi", VehicleModel = "TT", VehiclePlate = "YKCI77", VehicleYear = 2010, CreatedUtc = new DateTime(2020, 11, 19, 06, 39, 0) },
                new Contact() { Id = 61, PersonnelId = 61, PhoneNumber = "(461) 724-4324", PersonalEmail = "ntorricina1o@miitbeian.gov.cn", HasDriversLicense = true, VehicleMake = "Volvo", VehicleModel = "S40", VehiclePlate = "GH5F49", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 08, 39, 0) },
                new Contact() { Id = 62, PersonnelId = 62, PhoneNumber = "(261) 310-8051", PersonalEmail = "cchamp1p@washington.edu", HasDriversLicense = true, VehicleMake = "Oldsmobile", VehicleModel = "88", VehicleColor = "Blue", VehiclePlate = "RGN492", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 09, 32, 0) },
                new Contact() { Id = 63, PersonnelId = 63, PhoneNumber = "(941) 818-9905", PersonalEmail = "labrahmson1q@indiegogo.com", HasDriversLicense = true, VehicleMake = "Mercury", VehicleModel = "Mountaineer", VehiclePlate = "GXAY95", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 02, 33, 0) },
                new Contact() { Id = 64, PersonnelId = 64, PhoneNumber = "(512) 608-3155", PersonalEmail = "nboutton1r@networksolutions.com", MilEmail = "Gary.e.Marvin.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "LeMans", VehicleColor = "Turquoise", VehiclePlate = "GI4S17", VehicleYear = 1965, CreatedUtc = new DateTime(2020, 11, 19, 06, 36, 0) },
                new Contact() { Id = 65, PersonnelId = 65, PhoneNumber = "(095) 238-9277", PersonalEmail = "vwildsmith1s@so-net.ne.jp", MilEmail = "Cristen.n.Wilderman.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "Sunfire", VehicleColor = "Mauv", VehiclePlate = "ID3I38", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 03, 31, 0) },
                new Contact() { Id = 66, PersonnelId = 66, PhoneNumber = "(393) 160-2887", PersonalEmail = "geicheler1t@oaic.gov.au", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "GTO", VehiclePlate = "ZK8S11", VehicleYear = 1991, CreatedUtc = new DateTime(2020, 11, 19, 01, 35, 0) },
                new Contact() { Id = 67, PersonnelId = 67, PhoneNumber = "(715) 228-9075", PersonalEmail = "jbrockhurst1u@cbsnews.com", HasDriversLicense = false, VehicleMake = "Buick", VehicleModel = "Skylark", VehicleColor = "Green", VehiclePlate = "YEG885", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 02, 35, 0) },
                new Contact() { Id = 68, PersonnelId = 68, PhoneNumber = "(951) 144-9419", PersonalEmail = "ahaswall1v@webmd.com", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Malibu", VehicleColor = "Indigo", VehiclePlate = "XNYZ53", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 07, 36, 0) },
                new Contact() { Id = 69, PersonnelId = 69, PhoneNumber = "(972) 652-4913", PersonalEmail = "mdalinder1w@smh.com.au", HasDriversLicense = false, VehicleMake = "Mazda", VehicleModel = "Mazda6", VehicleColor = "Crimson", VehiclePlate = "BAQK96", VehicleYear = 2013, CreatedUtc = new DateTime(2020, 11, 19, 09, 38, 0) },
                new Contact() { Id = 70, PersonnelId = 70, PhoneNumber = "(050) 810-7245", PersonalEmail = "fkoles1x@domainmarket.com", HasDriversLicense = true, VehicleMake = "GMC", VehicleModel = "Canyon", VehicleColor = "Goldenrod", VehiclePlate = "ADCK50", VehicleYear = 2005, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Contact() { Id = 71, PersonnelId = 71, PhoneNumber = "(009) 388-5022", PersonalEmail = "sballingal1y@t-online.de", HasDriversLicense = false, VehicleMake = "BMW", VehicleModel = "530", VehiclePlate = "HIYZ83", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 02, 30, 0) },
                new Contact() { Id = 72, PersonnelId = 72, PhoneNumber = "(817) 324-3075", PersonalEmail = "ylefevre1z@tuttocitta.it", HasDriversLicense = true, VehicleMake = "Lexus", VehicleModel = "LS", VehicleColor = "Red", VehiclePlate = "VIDB50", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 07, 34, 0) },
                new Contact() { Id = 73, PersonnelId = 73, PhoneNumber = "(283) 803-9322", PersonalEmail = "vgaliford20@macromedia.com", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "Raider", VehicleColor = "Aquamarine", VehiclePlate = "MFVY37", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Contact() { Id = 74, PersonnelId = 74, PhoneNumber = "(820) 734-3580", PersonalEmail = "wpouton21@bandcamp.com", MilEmail = "Otelia.t.Considine.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Mazda", VehicleModel = "Tribute", VehiclePlate = "HYBK85", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 05, 32, 0) },
                new Contact() { Id = 75, PersonnelId = 75, PhoneNumber = "(889) 794-3230", PersonalEmail = "stinman22@tuttocitta.it", HasDriversLicense = true, VehicleMake = "Audi", VehicleModel = "S4", VehicleColor = "Red", VehiclePlate = "BKJ322", VehicleYear = 2005, CreatedUtc = new DateTime(2020, 11, 19, 00, 31, 0) },
                new Contact() { Id = 76, PersonnelId = 76, PhoneNumber = "(152) 773-1258", PersonalEmail = "bdonkersley23@drupal.org", HasDriversLicense = false, VehicleMake = "Nissan", VehicleModel = "240SX", VehicleColor = "Turquoise", VehiclePlate = "SSNW20", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 04, 33, 0) },
                new Contact() { Id = 77, PersonnelId = 77, PhoneNumber = "(702) 122-8530", PersonalEmail = "cbaxter24@so-net.ne.jp", HasDriversLicense = false, VehicleMake = "Dodge", VehicleModel = "D250", VehicleColor = "Goldenrod", VehiclePlate = "EZYL96", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 03, 37, 0) },
                new Contact() { Id = 78, PersonnelId = 78, PhoneNumber = "(611) 228-0143", PersonalEmail = "bdelamar25@reverbnation.com", HasDriversLicense = false, VehicleMake = "Infiniti", VehicleModel = "Q", VehicleColor = "Indigo", VehiclePlate = "JP7618", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 09, 38, 0) },
                new Contact() { Id = 79, PersonnelId = 79, PhoneNumber = "(807) 913-5551", PersonalEmail = "rclipson26@weebly.com", HasDriversLicense = true, VehicleMake = "Mitsubishi", VehicleModel = "Lancer", VehiclePlate = "XFAQ01", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 09, 31, 0) },
                new Contact() { Id = 80, PersonnelId = 80, PhoneNumber = "(908) 524-5505", PersonalEmail = "ijarret27@indiatimes.com", HasDriversLicense = false, VehicleMake = "Toyota", VehicleModel = "Sienna", VehiclePlate = "XBH893", VehicleYear = 2000, CreatedUtc = new DateTime(2020, 11, 19, 08, 38, 0) },
                new Contact() { Id = 81, PersonnelId = 81, PhoneNumber = "(408) 889-8368", HasDriversLicense = true, VehicleMake = "Mercury", VehicleModel = "Grand Marquis", VehicleColor = "Teal", VehiclePlate = "UFLL43", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 08, 36, 0) },
                new Contact() { Id = 82, PersonnelId = 82, PhoneNumber = "(128) 978-7068", PersonalEmail = "dmacgillreich29@nationalgeographic.com", MilEmail = "Ollie.b.Kozey.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Rolls-Royce", VehicleModel = "Phantom", VehicleColor = "Pink", VehiclePlate = "VCWM29", VehicleYear = 2013, CreatedUtc = new DateTime(2020, 11, 19, 05, 39, 0) },
                new Contact() { Id = 83, PersonnelId = 83, PhoneNumber = "(750) 386-3648", PersonalEmail = "lburgwin2a@webeden.co.uk", HasDriversLicense = true, VehicleMake = "Lexus", VehicleModel = "RX", VehicleColor = "Puce", VehiclePlate = "WTP595", VehicleYear = 2010, CreatedUtc = new DateTime(2020, 11, 19, 03, 32, 0) },
                new Contact() { Id = 84, PersonnelId = 84, PhoneNumber = "(983) 504-7250", PersonalEmail = "walpe2b@mit.edu", HasDriversLicense = false, VehicleMake = "Lexus", VehicleModel = "CT", VehicleColor = "Violet", VehiclePlate = "PFFJ78", VehicleYear = 2011, CreatedUtc = new DateTime(2020, 11, 19, 02, 35, 0) },
                new Contact() { Id = 85, PersonnelId = 85, PhoneNumber = "(807) 465-2159", PersonalEmail = "agreenlees2c@g.co", HasDriversLicense = true, VehicleMake = "Chevrolet", VehicleModel = "Caprice Classic", VehicleColor = "Mauv", VehiclePlate = "CTLW19", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 08, 37, 0) },
                new Contact() { Id = 86, PersonnelId = 86, PhoneNumber = "(690) 497-0250", PersonalEmail = "scrannis2d@cbsnews.com", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "F350", VehiclePlate = "MOGR97", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 03, 39, 0) },
                new Contact() { Id = 87, PersonnelId = 87, PhoneNumber = "(761) 263-2221", PersonalEmail = "jkilmister2e@craigslist.org", HasDriversLicense = true, VehicleMake = "Buick", VehicleModel = "Regal", VehiclePlate = "KVDE01", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Contact() { Id = 88, PersonnelId = 88, PhoneNumber = "(930) 131-9410", HasDriversLicense = true, VehicleMake = "Geo", VehicleModel = "Tracker", VehiclePlate = "VEW463", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 01, 31, 0) },
                new Contact() { Id = 89, PersonnelId = 89, PhoneNumber = "(811) 577-8236", HasDriversLicense = false, VehicleMake = "Honda", VehicleModel = "Prelude", VehiclePlate = "PSY266", VehicleYear = 1999, CreatedUtc = new DateTime(2020, 11, 19, 01, 30, 0) },
                new Contact() { Id = 90, PersonnelId = 90, PhoneNumber = "(918) 634-4632", PersonalEmail = "csimoncelli2h@ibm.com", HasDriversLicense = false, VehicleMake = "Lexus", VehicleModel = "SC", VehicleColor = "Fuscia", VehicleYear = 2003, CreatedUtc = new DateTime(2020, 11, 19, 01, 37, 0) },
                new Contact() { Id = 91, PersonnelId = 91, PhoneNumber = "(846) 448-5615", PersonalEmail = "ddavana2i@jiathis.com", HasDriversLicense = true, VehicleMake = "Nissan", VehicleModel = "Xterra", VehicleColor = "Turquoise", VehiclePlate = "HIJB36", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 09, 35, 0) },
                new Contact() { Id = 92, PersonnelId = 92, PhoneNumber = "(185) 896-1051", PersonalEmail = "mponter2j@apple.com", HasDriversLicense = true, VehicleMake = "Lincoln", VehicleModel = "Town Car", VehiclePlate = "OXI303", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 01, 39, 0) },
                new Contact() { Id = 93, PersonnelId = 93, PersonalEmail = "agonoude2k@apache.org", HasDriversLicense = false, VehicleMake = "Geo", VehicleModel = "Storm", VehiclePlate = "KBC360", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 03, 38, 0) },
                new Contact() { Id = 94, PersonnelId = 94, PhoneNumber = "(199) 108-0715", PersonalEmail = "mstein2l@merriam-webster.com", HasDriversLicense = false, VehicleMake = "Toyota", VehicleModel = "Sequoia", VehicleColor = "Pink", VehiclePlate = "UCCL92", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 03, 31, 0) },
                new Contact() { Id = 95, PersonnelId = 95, PhoneNumber = "(779) 963-7373", MilEmail = "Fritz.b.Hyatt.mil@mail.mil", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Cavalier", VehiclePlate = "HJE677", VehicleYear = 2000, CreatedUtc = new DateTime(2020, 11, 19, 01, 39, 0) },
                new Contact() { Id = 96, PersonnelId = 96, PhoneNumber = "(345) 188-5259", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "TrailBlazer", VehiclePlate = "VHLP97", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 07, 36, 0) },
                new Contact() { Id = 97, PersonnelId = 97, PhoneNumber = "(016) 215-4594", PersonalEmail = "ckennagh2o@storify.com", MilEmail = "Easter.z.Runolfsson.mil@mail.mil", HasDriversLicense = true, VehicleMake = "GMC", VehicleModel = "Canyon", VehiclePlate = "KN6M71", VehicleYear = 2011, CreatedUtc = new DateTime(2020, 11, 19, 03, 33, 0) },
                new Contact() { Id = 98, PersonnelId = 98, PhoneNumber = "(329) 945-6637", HasDriversLicense = true, VehicleMake = "Toyota", VehicleModel = "Corolla", VehicleColor = "Teal", VehiclePlate = "LD8M46", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 07, 36, 0) },
                new Contact() { Id = 99, PersonnelId = 99, PhoneNumber = "(154) 726-8928", PersonalEmail = "kpreator2q@tripod.com", HasDriversLicense = false, VehicleMake = "Mercedes-Benz", VehicleModel = "SLK-Class", VehiclePlate = "XA7U66", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 08, 35, 0) },
                new Contact() { Id = 100, PersonnelId = 100, PhoneNumber = "(425) 443-2393", PersonalEmail = "wyeldon2r@friendfeed.com", HasDriversLicense = true, VehicleMake = "Mazda", VehicleModel = "MPV", VehicleColor = "Pink", VehiclePlate = "FIA626", VehicleYear = 1989, CreatedUtc = new DateTime(2020, 11, 19, 04, 36, 0) },
                new Contact() { Id = 101, PersonnelId = 101, PhoneNumber = "(555) 482-1557", PersonalEmail = "soller2s@posterous.com", HasDriversLicense = true, VehicleMake = "Pontiac", VehicleModel = "Bonneville", VehicleColor = "Red", VehiclePlate = "HIQO08", VehicleYear = 1965, CreatedUtc = new DateTime(2020, 11, 19, 02, 38, 0) },
                new Contact() { Id = 102, PersonnelId = 102, PhoneNumber = "(248) 492-9426", HasDriversLicense = false, VehicleMake = "Audi", VehicleModel = "A5", VehiclePlate = "UJQZ86", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 01, 37, 0) },
                new Contact() { Id = 103, PersonnelId = 103, PhoneNumber = "(067) 328-6031", PersonalEmail = "eclarson2u@mysql.com", HasDriversLicense = false, VehicleMake = "Volvo", VehicleModel = "V70", VehiclePlate = "KOOD05", VehicleYear = 1998, CreatedUtc = new DateTime(2020, 11, 19, 01, 37, 0) },
                new Contact() { Id = 104, PersonnelId = 104, PhoneNumber = "(660) 222-1358", PersonalEmail = "pflannigan2v@umich.edu", HasDriversLicense = true, VehicleMake = "Jaguar", VehicleModel = "S-Type", VehicleColor = "Fuscia", VehiclePlate = "YX1N55", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 00, 36, 0) },
                new Contact() { Id = 105, PersonnelId = 105, PhoneNumber = "(165) 463-3205", PersonalEmail = "jpeert2w@gov.uk", HasDriversLicense = true, VehicleMake = "Chevrolet", VehicleModel = "Tahoe", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 09, 33, 0) },
                new Contact() { Id = 106, PersonnelId = 106, PhoneNumber = "(099) 526-5676", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Suburban 1500", VehicleColor = "Violet", VehiclePlate = "CT6I95", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 05, 34, 0) },
                new Contact() { Id = 107, PersonnelId = 107, PhoneNumber = "(483) 437-2651", PersonalEmail = "kportsmouth2y@unicef.org", HasDriversLicense = false, VehicleMake = "Oldsmobile", VehicleModel = "Aurora", VehiclePlate = "JCZA90", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 06, 32, 0) },
                new Contact() { Id = 108, PersonnelId = 108, PhoneNumber = "(959) 076-4768", PersonalEmail = "elorence2z@digg.com", HasDriversLicense = false, VehicleMake = "Ferrari", VehicleModel = "430 Scuderia", VehicleColor = "Goldenrod", VehiclePlate = "OKY080", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 05, 31, 0) },
                new Contact() { Id = 109, PersonnelId = 109, PhoneNumber = "(843) 207-5444", PersonalEmail = "mcarass30@squarespace.com", MilEmail = "Sherita.o.Langworth.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Mercury", VehicleModel = "Cougar", VehicleColor = "Fuscia", VehiclePlate = "AL6N74", VehicleYear = 1987, CreatedUtc = new DateTime(2020, 11, 19, 03, 32, 0) },
                new Contact() { Id = 110, PersonnelId = 110, PhoneNumber = "(580) 234-8089", PersonalEmail = "mstening31@bizjournals.com", HasDriversLicense = true, VehicleMake = "Lexus", VehicleModel = "IS", VehicleColor = "Yellow", VehiclePlate = "PGRY78", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 07, 33, 0) },
                new Contact() { Id = 111, PersonnelId = 111, PhoneNumber = "(903) 171-6186", PersonalEmail = "dcrannell32@who.int", HasDriversLicense = false, VehicleMake = "Buick", VehicleModel = "Roadmaster", VehiclePlate = "XNQM68", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 05, 37, 0) },
                new Contact() { Id = 112, PersonnelId = 112, PhoneNumber = "(648) 922-5519", PersonalEmail = "mlegging33@wisc.edu", HasDriversLicense = true, VehicleMake = "Acura", VehicleModel = "TSX", VehicleColor = "Aquamarine", VehiclePlate = "UCKB02", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 02, 33, 0) },
                new Contact() { Id = 113, PersonnelId = 113, PhoneNumber = "(872) 968-4272", PersonalEmail = "rvarley34@mapquest.com", HasDriversLicense = false, VehicleMake = "Hyundai", VehicleModel = "Sonata", VehicleColor = "Teal", VehiclePlate = "DHH799", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 09, 36, 0) },
                new Contact() { Id = 114, PersonnelId = 114, PhoneNumber = "(903) 227-0357", PersonalEmail = "msymes35@typepad.com", HasDriversLicense = true, VehicleMake = "Pontiac", VehicleModel = "LeMans", VehicleColor = "Khaki", VehiclePlate = "ISE712", VehicleYear = 1989, CreatedUtc = new DateTime(2020, 11, 19, 01, 33, 0) },
                new Contact() { Id = 115, PersonnelId = 115, PhoneNumber = "(419) 232-0905", PersonalEmail = "sspurrier36@oaic.gov.au", HasDriversLicense = false, VehicleMake = "Dodge", VehicleModel = "Dakota", VehicleColor = "Orange", VehiclePlate = "VSVV80", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 02, 36, 0) },
                new Contact() { Id = 116, PersonnelId = 116, PhoneNumber = "(879) 859-3774", PersonalEmail = "dnovotni37@instagram.com", HasDriversLicense = true, VehicleMake = "Cadillac", VehicleModel = "Seville", VehicleColor = "Purple", VehiclePlate = "WO3X69", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 09, 31, 0) },
                new Contact() { Id = 117, PersonnelId = 117, PhoneNumber = "(875) 657-9068", PersonalEmail = "vchalcroft38@usda.gov", HasDriversLicense = true, VehicleMake = "Toyota", VehicleModel = "4Runner", VehicleColor = "Teal", VehiclePlate = "DSF216", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 07, 39, 0) },
                new Contact() { Id = 118, PersonnelId = 118, PhoneNumber = "(025) 984-6950", HasDriversLicense = true, VehicleMake = "Ford", VehicleModel = "Econoline E150", VehicleColor = "Goldenrod", VehiclePlate = "RZSG75", VehicleYear = 1999, CreatedUtc = new DateTime(2020, 11, 19, 06, 32, 0) },
                new Contact() { Id = 119, PersonnelId = 119, PhoneNumber = "(009) 215-8310", PersonalEmail = "jiglesia3a@house.gov", HasDriversLicense = false, VehicleMake = "Mitsubishi", VehicleModel = "Mirage", VehicleColor = "Yellow", VehiclePlate = "LWV416", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 05, 38, 0) },
                new Contact() { Id = 120, PersonnelId = 120, PhoneNumber = "(082) 168-9920", PersonalEmail = "mendacott3b@netvibes.com", HasDriversLicense = true, VehicleMake = "Volkswagen", VehicleModel = "Passat", VehicleColor = "Teal", VehiclePlate = "IY4D53", VehicleYear = 1987, CreatedUtc = new DateTime(2020, 11, 19, 00, 31, 0) },
                new Contact() { Id = 121, PersonnelId = 121, PhoneNumber = "(159) 468-3933", PersonalEmail = "mmanvell3c@shop-pro.jp", HasDriversLicense = false, VehicleMake = "Acura", VehicleModel = "CL", VehicleColor = "Puce", VehiclePlate = "MYHU05", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 03, 38, 0) },
                new Contact() { Id = 122, PersonnelId = 122, PhoneNumber = "(367) 823-3809", HasDriversLicense = false, VehicleMake = "Spyker", VehicleModel = "C8 Spyder Wide Body", VehicleColor = "Aquamarine", VehiclePlate = "VGFK36", VehicleYear = 2004, CreatedUtc = new DateTime(2020, 11, 19, 01, 37, 0) },
                new Contact() { Id = 123, PersonnelId = 123, PhoneNumber = "(123) 755-8897", PersonalEmail = "srunnalls3e@lulu.com", HasDriversLicense = true, VehicleMake = "Hyundai", VehicleModel = "Excel", VehicleColor = "Green", VehiclePlate = "KH0502", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 07, 35, 0) },
                new Contact() { Id = 124, PersonnelId = 124, PhoneNumber = "(269) 571-1966", HasDriversLicense = true, VehicleMake = "Toyota", VehicleModel = "Camry Hybrid", VehicleColor = "Blue", VehiclePlate = "MP8U13", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 03, 35, 0) },
                new Contact() { Id = 125, PersonnelId = 125, PhoneNumber = "(428) 128-2718", HasDriversLicense = true, VehicleMake = "Ford", VehicleModel = "F-Series", VehicleColor = "Indigo", VehiclePlate = "ND1W00", VehicleYear = 2007, CreatedUtc = new DateTime(2020, 11, 19, 04, 37, 0) },
                new Contact() { Id = 126, PersonnelId = 126, PhoneNumber = "(266) 687-7094", HasDriversLicense = true, VehicleMake = "Honda", VehicleModel = "Odyssey", VehiclePlate = "WKV689", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 07, 31, 0) },
                new Contact() { Id = 127, PersonnelId = 127, PhoneNumber = "(289) 964-0743", PersonalEmail = "packenhead3i@nsw.gov.au", HasDriversLicense = false, VehicleMake = "Dodge", VehicleModel = "Ram 3500", VehicleColor = "Maroon", VehiclePlate = "BLRW13", VehicleYear = 1998, CreatedUtc = new DateTime(2020, 11, 19, 03, 39, 0) },
                new Contact() { Id = 128, PersonnelId = 128, PhoneNumber = "(990) 454-6603", PersonalEmail = "ewiggett3j@boston.com", HasDriversLicense = false, VehicleMake = "Jaguar", VehicleModel = "XK", VehiclePlate = "OESL79", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 03, 36, 0) },
                new Contact() { Id = 129, PersonnelId = 129, PhoneNumber = "(207) 180-5248", HasDriversLicense = false, VehicleMake = "Acura", VehicleModel = "NSX", VehicleColor = "Fuscia", VehiclePlate = "ECP577", VehicleYear = 2003, CreatedUtc = new DateTime(2020, 11, 19, 08, 36, 0) },
                new Contact() { Id = 130, PersonnelId = 130, PhoneNumber = "(211) 034-6783", PersonalEmail = "cstaintonskinn3l@businessweek.com", MilEmail = "Shon.e.Quigley.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Audi", VehicleModel = "A8", VehiclePlate = "GM8O48", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 03, 35, 0) },
                new Contact() { Id = 131, PersonnelId = 131, PhoneNumber = "(857) 231-1002", HasDriversLicense = false, VehicleMake = "Audi", VehicleModel = "Coupe GT", VehiclePlate = "CP0Q91", VehicleYear = 1986, CreatedUtc = new DateTime(2020, 11, 19, 00, 33, 0) },
                new Contact() { Id = 132, PersonnelId = 132, PhoneNumber = "(698) 443-0455", PersonalEmail = "drehme3n@yolasite.com", HasDriversLicense = true, VehicleMake = "Chrysler", VehicleModel = "LeBaron", VehicleColor = "Turquoise", VehiclePlate = "EU1706", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 08, 37, 0) },
                new Contact() { Id = 133, PersonnelId = 133, PhoneNumber = "(952) 828-7625", PersonalEmail = "kjarrard3o@amazon.de", HasDriversLicense = false, VehicleMake = "Pontiac", VehicleModel = "Sunfire", VehicleColor = "Violet", VehiclePlate = "ED6457", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 08, 36, 0) },
                new Contact() { Id = 134, PersonnelId = 134, PhoneNumber = "(358) 296-9725", HasDriversLicense = true, VehicleMake = "Toyota", VehicleModel = "Celica", VehicleColor = "Aquamarine", VehiclePlate = "GE9547", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 07, 30, 0) },
                new Contact() { Id = 135, PersonnelId = 135, PhoneNumber = "(732) 766-9022", PersonalEmail = "mlitster3q@slideshare.net", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "1500", VehicleColor = "Fuscia", VehiclePlate = "DO1Q88", VehicleYear = 1994, CreatedUtc = new DateTime(2020, 11, 19, 09, 39, 0) },
                new Contact() { Id = 136, PersonnelId = 136, PhoneNumber = "(773) 286-4862", PersonalEmail = "sretallack3r@elegantthemes.com", HasDriversLicense = true, VehicleMake = "BMW", VehicleModel = "5 Series", VehicleColor = "Teal", VehicleYear = 2008, CreatedUtc = new DateTime(2020, 11, 19, 06, 39, 0) },
                new Contact() { Id = 137, PersonnelId = 137, PhoneNumber = "(299) 633-9517", PersonalEmail = "iheiss3s@tiny.cc", HasDriversLicense = true, VehicleMake = "Volkswagen", VehicleModel = "New Beetle", VehicleColor = "Purple", VehiclePlate = "ECOZ33", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 03, 32, 0) },
                new Contact() { Id = 138, PersonnelId = 138, PhoneNumber = "(095) 138-8307", PersonalEmail = "tboykett3t@diigo.com", HasDriversLicense = false, VehicleMake = "Subaru", VehicleModel = "Leone", VehiclePlate = "HQQ436", VehicleYear = 1989, CreatedUtc = new DateTime(2020, 11, 19, 03, 34, 0) },
                new Contact() { Id = 139, PersonnelId = 139, PhoneNumber = "(070) 688-1619", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "E250", VehiclePlate = "IRK054", VehicleYear = 1984, CreatedUtc = new DateTime(2020, 11, 19, 00, 39, 0) },
                new Contact() { Id = 140, PersonnelId = 140, PhoneNumber = "(518) 581-6276", PersonalEmail = "cpawle3v@usa.gov", HasDriversLicense = false, VehicleMake = "Subaru", VehicleModel = "Impreza", VehicleColor = "Indigo", VehiclePlate = "NYLA34", VehicleYear = 1997, CreatedUtc = new DateTime(2020, 11, 19, 06, 35, 0) },
                new Contact() { Id = 141, PersonnelId = 141, PhoneNumber = "(534) 906-6109", PersonalEmail = "fdensie3w@goo.gl", HasDriversLicense = true, VehicleMake = "Mercury", VehicleModel = "Mountaineer", VehicleColor = "Violet", VehiclePlate = "PF0V94", VehicleYear = 2003, CreatedUtc = new DateTime(2020, 11, 19, 07, 34, 0) },
                new Contact() { Id = 142, PersonnelId = 142, PhoneNumber = "(188) 226-6801", PersonalEmail = "trichardeau3x@cloudflare.com", HasDriversLicense = true, VehicleMake = "Dodge", VehicleModel = "Grand Caravan", VehicleColor = "Indigo", VehiclePlate = "PYKY44", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 05, 30, 0) },
                new Contact() { Id = 143, PersonnelId = 143, PhoneNumber = "(896) 244-9608", PersonalEmail = "jfullun3y@upenn.edu", HasDriversLicense = false, VehicleMake = "Suzuki", VehicleModel = "Swift", VehicleColor = "Yellow", VehiclePlate = "CJJW25", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 05, 37, 0) },
                new Contact() { Id = 144, PersonnelId = 144, PhoneNumber = "(091) 867-0444", PersonalEmail = "pold3z@google.es", HasDriversLicense = true, VehicleMake = "Acura", VehicleModel = "TL", VehicleColor = "Fuscia", VehiclePlate = "TBO642", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 02, 38, 0) },
                new Contact() { Id = 145, PersonnelId = 145, PhoneNumber = "(888) 831-4917", PersonalEmail = "ngirton40@youtube.com", HasDriversLicense = true, VehicleMake = "Lotus", VehicleModel = "Esprit", VehiclePlate = "GKOK81", VehicleYear = 2003, CreatedUtc = new DateTime(2020, 11, 19, 08, 33, 0) },
                new Contact() { Id = 146, PersonnelId = 146, PhoneNumber = "(218) 227-0072", PersonalEmail = "mraiston41@ox.ac.uk", HasDriversLicense = false, VehicleMake = "Chevrolet", VehicleModel = "Avalanche 2500", VehicleColor = "Goldenrod", VehiclePlate = "JBGG28", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 09, 34, 0) },
                new Contact() { Id = 147, PersonnelId = 147, PhoneNumber = "(893) 394-7851", PersonalEmail = "zlusgdin42@redcross.org", HasDriversLicense = true, VehicleMake = "GMC", VehicleModel = "Savana 2500", VehiclePlate = "CDD004", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 04, 32, 0) },
                new Contact() { Id = 148, PersonnelId = 148, PhoneNumber = "(867) 013-1491", PersonalEmail = "dbernardini43@myspace.com", HasDriversLicense = true, VehicleMake = "Nissan", VehicleModel = "Altima", VehicleColor = "Violet", VehiclePlate = "UY4Q22", VehicleYear = 1998, CreatedUtc = new DateTime(2020, 11, 19, 00, 36, 0) },
                new Contact() { Id = 149, PersonnelId = 149, PhoneNumber = "(645) 259-1385", PersonalEmail = "hfiorentino44@163.com", HasDriversLicense = false, VehicleMake = "Honda", VehicleModel = "Insight", VehiclePlate = "YO8W99", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 02, 34, 0) },
                new Contact() { Id = 150, PersonnelId = 150, PhoneNumber = "(232) 445-6185", PersonalEmail = "cvonderdell45@gravatar.com", HasDriversLicense = true, VehicleMake = "Acura", VehicleModel = "TL", VehicleColor = "Yellow", VehiclePlate = "ED7B56", VehicleYear = 2001, CreatedUtc = new DateTime(2020, 11, 19, 06, 35, 0) },
                new Contact() { Id = 151, PersonnelId = 151, PhoneNumber = "(960) 105-0834", PersonalEmail = "alubbock46@over-blog.com", HasDriversLicense = true, VehicleMake = "Toyota", VehicleModel = "Venza", VehiclePlate = "FRIN03", VehicleYear = 2012, CreatedUtc = new DateTime(2020, 11, 19, 03, 34, 0) },
                new Contact() { Id = 152, PersonnelId = 152, PhoneNumber = "(547) 126-0150", PersonalEmail = "fmclewd47@admin.ch", HasDriversLicense = true, VehicleMake = "Honda", VehicleModel = "Prelude", VehicleColor = "Goldenrod", VehiclePlate = "CCG732", VehicleYear = 1985, CreatedUtc = new DateTime(2020, 11, 19, 04, 30, 0) },
                new Contact() { Id = 153, PersonnelId = 153, PhoneNumber = "(197) 612-4101", PersonalEmail = "acolnet48@ed.gov", HasDriversLicense = true, VehicleMake = "BMW", VehicleModel = "525", VehicleColor = "Mauv", VehiclePlate = "YC2F73", VehicleYear = 2006, CreatedUtc = new DateTime(2020, 11, 19, 00, 35, 0) },
                new Contact() { Id = 154, PersonnelId = 154, PhoneNumber = "(947) 461-5726", PersonalEmail = "jthreader49@amazon.co.uk", HasDriversLicense = false, VehicleMake = "Suzuki", VehicleModel = "Cultus", VehicleColor = "Aquamarine", VehiclePlate = "FGE597", VehicleYear = 1985, CreatedUtc = new DateTime(2020, 11, 19, 00, 36, 0) },
                new Contact() { Id = 155, PersonnelId = 155, PhoneNumber = "(399) 662-4047", PersonalEmail = "tcorcoran4a@xinhuanet.com", HasDriversLicense = false, VehicleMake = "Ford", VehicleModel = "F250", VehicleColor = "Goldenrod", VehiclePlate = "KD9J67", VehicleYear = 1992, CreatedUtc = new DateTime(2020, 11, 19, 03, 37, 0) },
                new Contact() { Id = 156, PersonnelId = 156, PhoneNumber = "(741) 296-7044", PersonalEmail = "mmoller4b@state.tx.us", HasDriversLicense = true, VehicleMake = "Saab", VehicleModel = "9000", VehicleColor = "Aquamarine", VehiclePlate = "AKYJ48", VehicleYear = 1998, CreatedUtc = new DateTime(2020, 11, 19, 03, 31, 0) },
                new Contact() { Id = 157, PersonnelId = 157, PhoneNumber = "(769) 480-0421", PersonalEmail = "ndovey4c@t.co", HasDriversLicense = true, VehicleMake = "Mitsubishi", VehicleModel = "Chariot", VehicleColor = "Teal", VehiclePlate = "PTUM42", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 00, 37, 0) },
                new Contact() { Id = 158, PersonnelId = 158, PhoneNumber = "(632) 578-4052", PersonalEmail = "mbrailsford4d@bbc.co.uk", HasDriversLicense = true, VehicleMake = "Dodge", VehicleModel = "Dakota", VehicleColor = "Goldenrod", VehiclePlate = "CCBI11", VehicleYear = 2005, CreatedUtc = new DateTime(2020, 11, 19, 05, 31, 0) },
                new Contact() { Id = 159, PersonnelId = 159, PhoneNumber = "(365) 138-6062", PersonalEmail = "sdehooge4e@google.nl", HasDriversLicense = true, VehicleMake = "Volkswagen", VehicleModel = "Jetta", VehicleColor = "Maroon", VehiclePlate = "HSXD82", VehicleYear = 1996, CreatedUtc = new DateTime(2020, 11, 19, 05, 31, 0) },
                new Contact() { Id = 160, PersonnelId = 160, PhoneNumber = "(672) 758-3470", PersonalEmail = "bmaccaughey4f@virginia.edu", HasDriversLicense = true, VehicleMake = "Isuzu", VehicleModel = "Rodeo", VehicleColor = "Mauv", VehiclePlate = "MBG676", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 03, 34, 0) },
                new Contact() { Id = 161, PersonnelId = 161, PhoneNumber = "(767) 710-5161", PersonalEmail = "mmatusov4g@nbcnews.com", HasDriversLicense = true, VehicleMake = "Pontiac", VehicleModel = "Firebird", VehicleColor = "Violet", VehiclePlate = "IB2O32", VehicleYear = 2002, CreatedUtc = new DateTime(2020, 11, 19, 03, 34, 0) },
                new Contact() { Id = 162, PersonnelId = 162, PhoneNumber = "(133) 185-7993", PersonalEmail = "lmeeke4h@usa.gov", MilEmail = "Clarissa.j.Torphy.mil@mail.mil", HasDriversLicense = true, VehicleMake = "Mazda", VehicleModel = "Mazdaspeed 3", VehicleColor = "Orange", VehiclePlate = "CA6Y17", VehicleYear = 2009, CreatedUtc = new DateTime(2020, 11, 19, 05, 30, 0) },
                new Contact() { Id = 163, PersonnelId = 163, PhoneNumber = "(454) 905-0485", PersonalEmail = "myewen4i@businesswire.com", HasDriversLicense = true, VehicleMake = "Cadillac", VehicleModel = "DeVille", VehiclePlate = "QO4P98", VehicleYear = 1995, CreatedUtc = new DateTime(2020, 11, 19, 00, 37, 0) },
                new Contact() { Id = 164, PersonnelId = 164, PhoneNumber = "(452) 722-1360", PersonalEmail = "bbuard4j@squarespace.com", HasDriversLicense = false, VehicleMake = "Audi", VehicleModel = "S4", VehicleColor = "Pink", VehiclePlate = "KP3089", VehicleYear = 1993, CreatedUtc = new DateTime(2020, 11, 19, 03, 31, 0) }
                );
            //Seed Housing
            //Seed UnitInfo
        }
    }
}
