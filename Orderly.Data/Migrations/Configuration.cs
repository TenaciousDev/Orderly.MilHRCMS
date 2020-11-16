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
        }
    }
}
