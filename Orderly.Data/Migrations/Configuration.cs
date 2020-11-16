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
                new Personnel() { PersonnelId = 1, Rank = Grade.E1, FirstName = "Crystie", LastName = "Minico", MiddleName = "Freedman", Sex = BioSex.Female, SSN = "457-99-1072", DOD = "5462553285", DOB = new DateTime(1982, 12, 27), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 2, Rank = Grade.E4, FirstName = "Laughton", LastName = "Schlagman", MiddleName = "Clarabelle", Sex = BioSex.Male, SSN = "126-66-6015", DOD = "3701512515", DOB = new DateTime(1913, 01, 08), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 3, Rank = Grade.O1, FirstName = "Brnaba", LastName = "Borgnet", Sex = BioSex.Female, SSN = "613-34-7750", DOD = "5656776832", DOB = new DateTime(1987, 12, 01), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 4, Rank = Grade.E1, FirstName = "Elysia", LastName = "Pohlke", MiddleName = "Dwayne", Sex = BioSex.Male, SSN = "432-69-9002", DOD = "9886604603", DOB = new DateTime(1971, 12, 29), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 5, Rank = Grade.E1, FirstName = "Gaston", LastName = "Bertson", Sex = BioSex.Male, SSN = "881-81-6498", DOD = "9490510483", DOB = new DateTime(1999, 02, 13), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 6, Rank = Grade.E4, FirstName = "Helge", LastName = "Atkinson", Sex = BioSex.Male, SSN = "548-77-0752", DOD = "7331635646", DOB = new DateTime(1999, 11, 23), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 7, Rank = Grade.E5, FirstName = "Farica", LastName = "Entwhistle", Sex = BioSex.Male, SSN = "263-06-7061", DOD = "5398088858", DOB = new DateTime(1994, 12, 11), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 8, Rank = Grade.E7, FirstName = "Camellia", LastName = "Tisun", MiddleName = "Alan", Sex = BioSex.Male, SSN = "640-45-5236", DOD = "5768248749", DOB = new DateTime(1989, 11, 27), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 9, Rank = Grade.E4, FirstName = "Patrica", LastName = "Rhoades", MiddleName = "Sophey", Sex = BioSex.Male, SSN = "677-94-2217", DOD = "5207134485", DOB = new DateTime(1985, 11, 28), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 10, Rank = Grade.E4, FirstName = "Ewell", LastName = "Lea", MiddleName = "Terri", Sex = BioSex.Male, SSN = "508-29-4467", DOD = "2296174000", DOB = new DateTime(1983, 01, 29), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 11, Rank = Grade.E5, FirstName = "Eddi", LastName = "Grumble", MiddleName = "Pooh", Sex = BioSex.Female, SSN = "140-87-6354", DOD = "3526919763", DOB = new DateTime(1994, 12, 25), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 12, Rank = Grade.E8, FirstName = "Hilarius", LastName = "Hailey", MiddleName = "Dayle", Sex = BioSex.Female, SSN = "322-54-5876", DOD = "0189003375", DOB = new DateTime(1914, 01, 21), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 13, Rank = Grade.E1, FirstName = "Frederico", LastName = "Melior", Sex = BioSex.Male, SSN = "739-65-7485", DOD = "5184021094", DOB = new DateTime(1956, 02, 04), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 14, Rank = Grade.E2, FirstName = "Marvin", LastName = "Hanscombe", MiddleName = "Rochette", Sex = BioSex.Male, SSN = "792-64-2574", DOD = "9693044185", DOB = new DateTime(1951, 01, 22), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 15, Rank = Grade.E6, FirstName = "Margaux", LastName = "Juliano", MiddleName = "Jacinta", Sex = BioSex.Male, SSN = "680-78-5048", DOD = "3508760456", DOB = new DateTime(1997, 01, 18), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 16, Rank = Grade.E4, FirstName = "Weston", LastName = "Dansken", Sex = BioSex.Male, SSN = "523-88-2041", DOD = "5780661197", DOB = new DateTime(1993, 11, 17), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 17, Rank = Grade.W2, FirstName = "Munmro", LastName = "Saltman", MiddleName = "Vinny", Sex = BioSex.Male, SSN = "789-84-6488", DOD = "3565662832", DOB = new DateTime(1976, 11, 25), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 18, Rank = Grade.E1, FirstName = "Adrian", LastName = "Cafferky", MiddleName = "Heather", Sex = BioSex.Male, SSN = "104-47-8618", DOD = "8020224181", DOB = new DateTime(1963, 01, 04), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 19, Rank = Grade.E5, FirstName = "Pauly", LastName = "Darrington", MiddleName = "Haze", Sex = BioSex.Male, SSN = "131-19-7738", DOD = "8240147607", DOB = new DateTime(1997, 01, 26), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 20, Rank = Grade.E5, FirstName = "Fredia", LastName = "Cawt", MiddleName = "Fredericka", Sex = BioSex.Other, SSN = "602-45-8921", DOD = "5491643068", DOB = new DateTime(1972, 02, 11), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 21, Rank = Grade.E4, FirstName = "Otho", LastName = "Tolcher", MiddleName = "Carr", Sex = BioSex.Male, SSN = "344-14-1396", DOD = "4692867523", DOB = new DateTime(1971, 11, 05), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 22, Rank = Grade.E4, FirstName = "Jesse", LastName = "Spire", MiddleName = "Luci", Sex = BioSex.Male, SSN = "805-03-1441", DOD = "3095229852", DOB = new DateTime(1987, 02, 21), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 23, Rank = Grade.W2, FirstName = "Adoree", LastName = "Minard", MiddleName = "Lorry", Sex = BioSex.Male, SSN = "501-13-8757", DOD = "8590210758", DOB = new DateTime(1987, 02, 28), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 24, Rank = Grade.E5, FirstName = "Odille", LastName = "Woodham", MiddleName = "Zitella", Sex = BioSex.Female, SSN = "568-96-0959", DOD = "0480982996", DOB = new DateTime(1992, 01, 19), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 25, Rank = Grade.E4, FirstName = "Lancelot", LastName = "Fibbens", MiddleName = "Katlin", Sex = BioSex.Male, SSN = "864-96-1843", DOD = "7250422472", DOB = new DateTime(1981, 12, 26), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 26, Rank = Grade.E1, FirstName = "Christalle", LastName = "Clausewitz", MiddleName = "Carilyn", Sex = BioSex.Male, SSN = "838-34-2761", DOD = "7101046940", DOB = new DateTime(1991, 01, 01), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 27, Rank = Grade.E6, FirstName = "Sheffie", LastName = "Josovich", Sex = BioSex.Male, SSN = "705-69-0617", DOD = "5059992837", DOB = new DateTime(1984, 12, 22), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 28, Rank = Grade.E5, FirstName = "Hayes", LastName = "Minnette", MiddleName = "Evanne", Sex = BioSex.Male, SSN = "584-90-8410", DOD = "4856933914", DOB = new DateTime(1977, 12, 04), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 29, Rank = Grade.O1, FirstName = "Saba", LastName = "Zammett", MiddleName = "Zack", Sex = BioSex.Male, SSN = "475-16-7085", DOD = "7192116734", DOB = new DateTime(1969, 02, 25), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 30, Rank = Grade.E8, FirstName = "Guss", LastName = "Jellett", MiddleName = "Caria", Sex = BioSex.Female, SSN = "586-59-5161", DOD = "0459061534", DOB = new DateTime(1984, 11, 20), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 31, Rank = Grade.E1, FirstName = "Gillan", LastName = "McKirton", MiddleName = "Artemas", Sex = BioSex.Male, SSN = "830-08-9957", DOD = "7690501370", DOB = new DateTime(1989, 02, 06), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 32, Rank = Grade.E4, FirstName = "Sianna", LastName = "Baltzar", MiddleName = "Jarid", Sex = BioSex.Other, SSN = "307-88-1891", DOD = "7004733297", DOB = new DateTime(1991, 01, 17), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 33, Rank = Grade.E4, FirstName = "Inigo", LastName = "Maric", MiddleName = "Dalli", Sex = BioSex.Male, SSN = "155-29-0081", DOD = "0607902507", DOB = new DateTime(1976, 11, 02), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 34, Rank = Grade.E5, FirstName = "Alfonso", LastName = "Tigner", Sex = BioSex.Male, SSN = "180-94-2385", DOD = "7279851266", DOB = new DateTime(1994, 01, 07), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 35, Rank = Grade.E1, FirstName = "Grier", LastName = "Iddiens", MiddleName = "Esta", Sex = BioSex.Male, SSN = "724-03-7951", DOD = "6052540044", DOB = new DateTime(1981, 01, 20), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 36, Rank = Grade.E7, FirstName = "Sadye", LastName = "Clegg", Sex = BioSex.Male, SSN = "841-12-1148", DOD = "5343645070", DOB = new DateTime(1995, 12, 13), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 37, Rank = Grade.E1, FirstName = "Gibby", LastName = "Bartomeu", MiddleName = "Nappy", Sex = BioSex.Male, SSN = "106-68-9737", DOD = "2138197565", DOB = new DateTime(1982, 01, 18), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 38, Rank = Grade.E2, FirstName = "Honey", LastName = "Fanthom", MiddleName = "Lorita", Sex = BioSex.Male, SSN = "653-19-4146", DOD = "1585874523", DOB = new DateTime(1990, 02, 18), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 39, Rank = Grade.E5, FirstName = "Rriocard", LastName = "Yanez", MiddleName = "Carmella", Sex = BioSex.Male, SSN = "172-55-2683", DOD = "3819190902", DOB = new DateTime(1976, 11, 26), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 40, Rank = Grade.E1, FirstName = "Andrea", LastName = "Heatly", MiddleName = "Dierdre", Sex = BioSex.Male, SSN = "158-73-7326", DOD = "5351294923", DOB = new DateTime(1973, 12, 28), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 41, Rank = Grade.E1, FirstName = "Conney", LastName = "Duddy", MiddleName = "Helli", Sex = BioSex.Male, SSN = "437-03-0256", DOD = "7720131304", DOB = new DateTime(1975, 11, 13), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 42, Rank = Grade.E1, FirstName = "Pearle", LastName = "Viger", MiddleName = "Welbie", Sex = BioSex.Other, SSN = "144-85-2365", DOD = "2214527060", DOB = new DateTime(1995, 02, 08), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 43, Rank = Grade.E5, FirstName = "Nicolle", LastName = "Butting", Sex = BioSex.Male, SSN = "782-81-8594", DOD = "4148321589", DOB = new DateTime(1980, 12, 26), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 44, Rank = Grade.E4, FirstName = "Verena", LastName = "Hutchence", MiddleName = "Gracie", Sex = BioSex.Male, SSN = "893-98-0585", DOD = "0830554610", DOB = new DateTime(1971, 01, 17), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 45, Rank = Grade.E5, FirstName = "Dov", LastName = "Dixey", Sex = BioSex.Male, SSN = "491-84-7257", DOD = "0579018121", DOB = new DateTime(1993, 12, 24), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 46, Rank = Grade.E3, FirstName = "Bourke", LastName = "Klees", MiddleName = "Odette", Sex = BioSex.Male, SSN = "627-51-2425", DOD = "8083541532", DOB = new DateTime(1979, 11, 04), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 47, Rank = Grade.E1, FirstName = "Robenia", LastName = "Durkin", MiddleName = "Hernando", Sex = BioSex.Female, SSN = "247-77-1779", DOD = "2954858532", DOB = new DateTime(1971, 11, 27), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 48, Rank = Grade.E1, FirstName = "Abagail", LastName = "Rittmeier", MiddleName = "Alma", Sex = BioSex.Female, SSN = "398-96-2392", DOD = "3215738856", DOB = new DateTime(1996, 01, 00), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 49, Rank = Grade.E4, FirstName = "Aluino", LastName = "Koppes", Sex = BioSex.Male, SSN = "778-08-5980", DOD = "2278460609", DOB = new DateTime(1987, 11, 22), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 50, Rank = Grade.E5, FirstName = "Marysa", LastName = "Edsall", MiddleName = "Mag", Sex = BioSex.Male, SSN = "514-76-5848", DOD = "3785526881", DOB = new DateTime(1974, 11, 22), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 51, Rank = Grade.E3, FirstName = "Cyrus", LastName = "Dioniso", Sex = BioSex.Male, SSN = "143-36-2847", DOD = "6029157973", DOB = new DateTime(1991, 02, 27), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 52, Rank = Grade.E4, FirstName = "Gabriello", LastName = "Tolliday", Sex = BioSex.Other, SSN = "638-92-9876", DOD = "2691703304", DOB = new DateTime(1991, 11, 29), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 53, Rank = Grade.E2, FirstName = "Raviv", LastName = "Hemmingway", MiddleName = "Niki", Sex = BioSex.Male, SSN = "844-98-2171", DOD = "6457837077", DOB = new DateTime(1994, 01, 25), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 54, Rank = Grade.E7, FirstName = "Shandeigh", LastName = "Huxster", MiddleName = "Kania", Sex = BioSex.Female, SSN = "198-86-8267", DOD = "3938813652", DOB = new DateTime(1991, 02, 08), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 55, Rank = Grade.E4, FirstName = "Caril", LastName = "Mitrovic", Sex = BioSex.Male, SSN = "631-33-8729", DOD = "1011585626", DOB = new DateTime(1998, 02, 26), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 56, Rank = Grade.E3, FirstName = "Jackquelin", LastName = "Bruneton", Sex = BioSex.Male, SSN = "442-99-6907", DOD = "1826654321", DOB = new DateTime(1990, 12, 23), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 57, Rank = Grade.E4, FirstName = "Louise", LastName = "Jentet", MiddleName = "Nicol", Sex = BioSex.Male, SSN = "545-13-0815", DOD = "8891113522", DOB = new DateTime(1999, 11, 18), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 58, Rank = Grade.E4, FirstName = "Domeniga", LastName = "O'Neal", MiddleName = "Meara", Sex = BioSex.Male, SSN = "308-35-0769", DOD = "6926462240", DOB = new DateTime(1975, 11, 05), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 59, Rank = Grade.E3, FirstName = "Samara", LastName = "Tidd", MiddleName = "Cirstoforo", Sex = BioSex.Male, SSN = "464-72-3129", DOD = "9466000411", DOB = new DateTime(1990, 01, 11), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 60, Rank = Grade.E6, FirstName = "Brandie", LastName = "Sangar", MiddleName = "Marcia", Sex = BioSex.Male, SSN = "718-05-0835", DOD = "4643236086", DOB = new DateTime(1991, 01, 27), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 61, Rank = Grade.E1, FirstName = "Francesca", LastName = "Huddy", Sex = BioSex.Male, SSN = "428-21-7245", DOD = "3234878935", DOB = new DateTime(1994, 01, 20), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 62, Rank = Grade.E1, FirstName = "Ram", LastName = "Petran", MiddleName = "Marissa", Sex = BioSex.Male, SSN = "717-07-9316", DOD = "6460905037", DOB = new DateTime(1995, 11, 07), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 63, Rank = Grade.E3, FirstName = "Paulita", LastName = "Slorance", MiddleName = "Artemus", Sex = BioSex.Female, SSN = "254-42-5143", DOD = "6464306871", DOB = new DateTime(1960, 02, 22), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 64, Rank = Grade.E3, FirstName = "Tanitansy", LastName = "Lyddon", MiddleName = "Dorothy", Sex = BioSex.Male, SSN = "532-04-0210", DOD = "4134029066", DOB = new DateTime(1970, 11, 29), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 65, Rank = Grade.E7, FirstName = "Ashleigh", LastName = "Geeves", Sex = BioSex.Female, SSN = "329-06-3659", DOD = "4782738595", DOB = new DateTime(1980, 12, 11), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 66, Rank = Grade.E2, FirstName = "Berte", LastName = "Biaggiotti", Sex = BioSex.Male, SSN = "439-28-9149", DOD = "0424222760", DOB = new DateTime(1969, 02, 22), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 67, Rank = Grade.E2, FirstName = "Leeanne", LastName = "Hindge", MiddleName = "Curtice", Sex = BioSex.Other, SSN = "212-74-0346", DOD = "9747632756", DOB = new DateTime(1999, 11, 08), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 68, Rank = Grade.E4, FirstName = "Mari", LastName = "Jurn", MiddleName = "Marchall", Sex = BioSex.Male, SSN = "391-97-1777", DOD = "0440572428", DOB = new DateTime(1963, 02, 22), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 69, Rank = Grade.E7, FirstName = "Ricard", LastName = "Castelin", MiddleName = "Mal", Sex = BioSex.Female, SSN = "679-34-7027", DOD = "7406627327", DOB = new DateTime(1962, 02, 13), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 70, Rank = Grade.O2, FirstName = "Guillermo", LastName = "Hawarden", MiddleName = "Lennie", Sex = BioSex.Male, SSN = "547-71-0508", DOD = "2922139514", DOB = new DateTime(1996, 12, 05), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 71, Rank = Grade.E2, FirstName = "Kendra", LastName = "Wenderoth", MiddleName = "Ty", Sex = BioSex.Male, SSN = "465-03-0541", DOD = "4643063998", DOB = new DateTime(1993, 12, 08), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 72, Rank = Grade.E8, FirstName = "Derick", LastName = "Yates", MiddleName = "Abran", Sex = BioSex.Male, SSN = "579-91-8304", DOD = "2917422467", DOB = new DateTime(1911, 01, 01), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 73, Rank = Grade.E4, FirstName = "Stavro", LastName = "Bonner", MiddleName = "Whitney", SSN = "328-49-3265", DOD = "1265843368", DOB = new DateTime(1991, 11, 23), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 74, Rank = Grade.E3, FirstName = "Jayne", LastName = "Sillars", Sex = BioSex.Male, SSN = "249-41-9184", DOD = "9631904342", DOB = new DateTime(1985, 02, 05), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 75, Rank = Grade.E2, FirstName = "Andeee", LastName = "Tzuker", MiddleName = "Lianne", Sex = BioSex.Male, SSN = "255-71-4337", DOD = "2344897003", DOB = new DateTime(1975, 11, 24), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 76, Rank = Grade.E2, FirstName = "Allie", LastName = "Ravel", MiddleName = "Keenan", Sex = BioSex.Male, SSN = "583-75-6546", DOD = "0069891850", DOB = new DateTime(1993, 11, 18), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 77, Rank = Grade.E1, FirstName = "Valry", LastName = "Owthwaite", MiddleName = "Harland", Sex = BioSex.Male, SSN = "104-15-6279", DOD = "6029645455", DOB = new DateTime(1966, 01, 28), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 78, Rank = Grade.E6, FirstName = "Esdras", LastName = "Summerfield", MiddleName = "Fianna", Sex = BioSex.Male, SSN = "156-35-4976", DOD = "6032704076", DOB = new DateTime(1983, 02, 25), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 79, Rank = Grade.E4, FirstName = "Starlene", LastName = "Grainge", MiddleName = "Corbie", Sex = BioSex.Male, SSN = "160-46-0167", DOD = "1308916671", DOB = new DateTime(1916, 01, 25), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 80, Rank = Grade.E1, FirstName = "Margarethe", LastName = "Kintzel", MiddleName = "Bonita", Sex = BioSex.Male, SSN = "118-75-0779", DOD = "3049907738", DOB = new DateTime(1970, 01, 25), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 81, Rank = Grade.E5, FirstName = "Deonne", LastName = "Hobbert", MiddleName = "Mitchell", Sex = BioSex.Male, SSN = "189-85-5230", DOD = "1510522905", DOB = new DateTime(1991, 02, 11), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 82, Rank = Grade.E3, FirstName = "Christoper", LastName = "Dymond", Sex = BioSex.Male, SSN = "366-50-8241", DOD = "0486901718", DOB = new DateTime(1985, 02, 28), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 83, Rank = Grade.E1, FirstName = "Gordan", LastName = "Dyde", MiddleName = "Kirsti", Sex = BioSex.Male, SSN = "687-47-1482", DOD = "9963503306", DOB = new DateTime(1952, 01, 13), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 84, Rank = Grade.E2, FirstName = "Nev", LastName = "Argo", MiddleName = "Marve", Sex = BioSex.Male, SSN = "851-18-6694", DOD = "5368475276", DOB = new DateTime(1915, 02, 06), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 85, Rank = Grade.O1, FirstName = "Ethelbert", LastName = "Stutter", MiddleName = "Robin", Sex = BioSex.Male, SSN = "534-80-1160", DOD = "4670235451", DOB = new DateTime(1999, 12, 24), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 86, Rank = Grade.E4, FirstName = "Sidney", LastName = "Ditts", MiddleName = "De witt", Sex = BioSex.Male, SSN = "243-57-2073", DOD = "4702243357", DOB = new DateTime(1985, 12, 08), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 87, Rank = Grade.E2, FirstName = "Guthrie", LastName = "Coverdale", Sex = BioSex.Male, SSN = "570-07-6480", DOD = "3973121559", DOB = new DateTime(1999, 02, 20), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 88, Rank = Grade.E4, FirstName = "Dorelle", LastName = "Lennie", MiddleName = "Stella", Sex = BioSex.Male, SSN = "480-46-6279", DOD = "5405579246", DOB = new DateTime(1985, 12, 11), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 89, Rank = Grade.E1, FirstName = "Shantee", LastName = "Bigland", MiddleName = "Dinah", SSN = "552-30-6327", DOD = "1033738204", DOB = new DateTime(1998, 11, 11), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 90, Rank = Grade.E4, FirstName = "Tim", LastName = "Heyfield", MiddleName = "Odele", Sex = BioSex.Male, SSN = "538-37-8545", DOD = "6883908013", DOB = new DateTime(1996, 02, 02), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 91, Rank = Grade.E1, FirstName = "Sullivan", LastName = "Reolfo", MiddleName = "Lilllie", SSN = "227-76-9915", DOD = "8131307638", DOB = new DateTime(1987, 02, 27), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 92, Rank = Grade.E2, FirstName = "Puff", LastName = "Joincey", MiddleName = "Ludvig", Sex = BioSex.Male, SSN = "376-72-8630", DOD = "0502609346", DOB = new DateTime(1991, 11, 20), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 93, Rank = Grade.E2, FirstName = "Danica", LastName = "Yurmanovev", MiddleName = "Oates", Sex = BioSex.Male, SSN = "224-25-5781", DOD = "7015146541", DOB = new DateTime(1981, 11, 03), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 94, Rank = Grade.W2, FirstName = "Nanon", LastName = "Dondon", MiddleName = "Gratiana", Sex = BioSex.Male, SSN = "451-76-4884", DOD = "6831347053", DOB = new DateTime(1973, 01, 23), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 95, Rank = Grade.E1, FirstName = "Karlie", LastName = "Linscott", MiddleName = "Erich", Sex = BioSex.Male, SSN = "145-24-7587", DOD = "9694848474", DOB = new DateTime(1988, 12, 11), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 96, Rank = Grade.W2, FirstName = "Babita", LastName = "Vallender", Sex = BioSex.Male, SSN = "372-98-4592", DOD = "7982541135", DOB = new DateTime(1951, 02, 12), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 97, Rank = Grade.E1, FirstName = "Lucky", LastName = "Beebee", MiddleName = "Ernestine", Sex = BioSex.Male, SSN = "140-64-1875", DOD = "0054998158", DOB = new DateTime(1995, 12, 20), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 98, Rank = Grade.E4, FirstName = "Theodosia", LastName = "Gair", MiddleName = "Jess", Sex = BioSex.Male, SSN = "221-96-8946", DOD = "2287549846", DOB = new DateTime(1980, 02, 09), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 99, Rank = Grade.W2, FirstName = "Yank", LastName = "Connealy", Sex = BioSex.Female, SSN = "573-21-5508", DOD = "5981921765", DOB = new DateTime(1970, 02, 01), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 100, Rank = Grade.E1, FirstName = "Chadd", LastName = "McClurg", MiddleName = "Basia", Sex = BioSex.Female, SSN = "211-17-5832", DOD = "4268724893", DOB = new DateTime(1997, 01, 28), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 101, Rank = Grade.E5, FirstName = "Mirabelle", LastName = "Carloni", MiddleName = "Raf", Sex = BioSex.Male, SSN = "585-78-4845", DOD = "6559334112", DOB = new DateTime(1993, 02, 26), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 102, Rank = Grade.E4, FirstName = "Angel", LastName = "Hellsdon", Sex = BioSex.Male, SSN = "270-84-3427", DOD = "7609885444", DOB = new DateTime(1976, 02, 20), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 103, Rank = Grade.E2, FirstName = "Kerry", LastName = "Biford", MiddleName = "Malory", Sex = BioSex.Female, SSN = "183-19-5729", DOD = "2641764288", DOB = new DateTime(1974, 12, 25), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 104, Rank = Grade.E1, FirstName = "Kirstyn", LastName = "Rhelton", MiddleName = "Margery", Sex = BioSex.Female, SSN = "376-78-9886", DOD = "8185131759", DOB = new DateTime(1997, 02, 25), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 105, Rank = Grade.E5, FirstName = "Weider", LastName = "MacGoun", Sex = BioSex.Male, SSN = "127-46-2783", DOD = "2030386960", DOB = new DateTime(1998, 12, 25), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 106, Rank = Grade.O1, FirstName = "Branden", LastName = "Pirelli", MiddleName = "Kendre", Sex = BioSex.Male, SSN = "410-52-8577", DOD = "9337926288", DOB = new DateTime(1978, 01, 29), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 107, Rank = Grade.E1, FirstName = "Karol", LastName = "Lardier", MiddleName = "Chlo", Sex = BioSex.Other, SSN = "339-19-1320", DOD = "6733907356", DOB = new DateTime(1992, 12, 16), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 108, Rank = Grade.E3, FirstName = "Hernando", LastName = "Coughtrey", Sex = BioSex.Male, SSN = "422-81-0952", DOD = "1198183853", DOB = new DateTime(1972, 01, 21), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 109, Rank = Grade.O2, FirstName = "Beryle", LastName = "Bindley", MiddleName = "Vitia", Sex = BioSex.Male, SSN = "612-61-6266", DOD = "5534392436", DOB = new DateTime(1989, 01, 20), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 110, Rank = Grade.E6, FirstName = "Marc", LastName = "Coulthard", Sex = BioSex.Male, SSN = "569-26-8242", DOD = "9798198204", DOB = new DateTime(1999, 02, 08), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 111, Rank = Grade.E6, FirstName = "Denis", LastName = "Southcomb", MiddleName = "Bartolemo", Sex = BioSex.Male, SSN = "228-14-4730", DOD = "6268394593", DOB = new DateTime(1988, 01, 08), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 112, Rank = Grade.E4, FirstName = "Rozalin", LastName = "Martinec", MiddleName = "Brice", Sex = BioSex.Female, SSN = "252-39-8705", DOD = "2725173752", DOB = new DateTime(1984, 12, 26), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 113, Rank = Grade.E4, FirstName = "Winslow", LastName = "Marchello", SSN = "189-35-1525", DOD = "5209615324", DOB = new DateTime(1963, 12, 19), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 114, Rank = Grade.E4, FirstName = "Halsy", LastName = "Sappson", MiddleName = "Albrecht", Sex = BioSex.Male, SSN = "144-31-0215", DOD = "9837038802", DOB = new DateTime(1983, 12, 07), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 115, Rank = Grade.E3, FirstName = "Ibbie", LastName = "Rawnsley", MiddleName = "Carrie", Sex = BioSex.Male, SSN = "748-98-5834", DOD = "0062645951", DOB = new DateTime(1998, 11, 14), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 116, Rank = Grade.E2, FirstName = "Deloria", LastName = "Hanington", MiddleName = "Nikki", Sex = BioSex.Female, SSN = "550-15-7804", DOD = "9292936441", DOB = new DateTime(1960, 12, 20), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 117, Rank = Grade.E2, FirstName = "Margaretta", LastName = "Tuffrey", MiddleName = "Elvina", Sex = BioSex.Female, SSN = "668-97-9973", DOD = "4618683996", DOB = new DateTime(1991, 11, 28), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 118, Rank = Grade.E6, FirstName = "Kaine", LastName = "De Rye Barrett", MiddleName = "Anette", Sex = BioSex.Male, SSN = "877-43-3130", DOD = "2619792207", DOB = new DateTime(1978, 11, 14), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 119, Rank = Grade.E4, FirstName = "Urbain", LastName = "Sibbit", MiddleName = "Shane", Sex = BioSex.Male, SSN = "368-09-8806", DOD = "3341090452", DOB = new DateTime(1982, 11, 06), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 120, Rank = Grade.E3, FirstName = "Balduin", LastName = "Illes", Sex = BioSex.Male, SSN = "592-36-6400", DOD = "7256125143", DOB = new DateTime(1976, 02, 19), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 121, Rank = Grade.E6, FirstName = "Moina", LastName = "Staniford", MiddleName = "Oran", Sex = BioSex.Male, SSN = "268-05-4102", DOD = "7336870414", DOB = new DateTime(1955, 01, 22), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 122, Rank = Grade.E6, FirstName = "Broderick", LastName = "Vauter", MiddleName = "Antin", Sex = BioSex.Other, SSN = "604-37-0704", DOD = "2673033599", DOB = new DateTime(1976, 02, 27), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 123, Rank = Grade.E4, FirstName = "Vikki", LastName = "Binner", MiddleName = "Thomasine", Sex = BioSex.Male, SSN = "433-03-9271", DOD = "6823419172", DOB = new DateTime(1994, 12, 14), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 124, Rank = Grade.E5, FirstName = "Shani", LastName = "Ralphs", MiddleName = "Deane", Sex = BioSex.Female, SSN = "472-42-2612", DOD = "8302159662", DOB = new DateTime(1998, 02, 28), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 125, Rank = Grade.E2, FirstName = "Theda", LastName = "Loyndon", MiddleName = "Frants", Sex = BioSex.Male, SSN = "213-36-0295", DOD = "3056481457", DOB = new DateTime(1979, 02, 20), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 126, Rank = Grade.E4, FirstName = "Bradley", LastName = "Tapp", MiddleName = "Almira", Sex = BioSex.Male, SSN = "636-76-1086", DOD = "4356813723", DOB = new DateTime(1983, 12, 11), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 127, Rank = Grade.E6, FirstName = "Millard", LastName = "Tomini", Sex = BioSex.Male, SSN = "465-26-3973", DOD = "5059375064", DOB = new DateTime(1982, 11, 20), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 128, Rank = Grade.E1, FirstName = "Gerard", LastName = "Milan", MiddleName = "Korey", Sex = BioSex.Male, SSN = "344-53-0456", DOD = "4049157071", DOB = new DateTime(1984, 12, 18), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 129, Rank = Grade.E5, FirstName = "Corabella", LastName = "Dictus", MiddleName = "Muffin", Sex = BioSex.Male, SSN = "322-32-5159", DOD = "5161220465", DOB = new DateTime(1980, 12, 26), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 130, Rank = Grade.E4, FirstName = "Dareen", LastName = "Mammatt", MiddleName = "Owen", Sex = BioSex.Female, SSN = "353-33-7985", DOD = "7083659346", DOB = new DateTime(1992, 11, 19), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 131, Rank = Grade.O2, FirstName = "Mandie", LastName = "Krishtopaittis", MiddleName = "Blair", Sex = BioSex.Male, SSN = "402-01-6330", DOD = "2784421112", DOB = new DateTime(1995, 11, 25), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 132, Rank = Grade.E6, FirstName = "Danella", LastName = "Dunwoody", Sex = BioSex.Other, SSN = "160-59-3933", DOD = "5848859795", DOB = new DateTime(1992, 02, 14), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 133, Rank = Grade.E5, FirstName = "Edgard", LastName = "Niland", MiddleName = "Blithe", Sex = BioSex.Female, SSN = "561-71-4479", DOD = "9230694320", DOB = new DateTime(1962, 01, 26), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 134, Rank = Grade.E7, FirstName = "Astrix", LastName = "Rubie", MiddleName = "Yehudit", Sex = BioSex.Male, SSN = "519-43-5466", DOD = "5044790044", DOB = new DateTime(1999, 02, 04), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 135, Rank = Grade.E3, FirstName = "Jillane", LastName = "Kellington", MiddleName = "Chelsy", Sex = BioSex.Male, SSN = "433-48-0936", DOD = "3488609006", DOB = new DateTime(1992, 02, 13), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 136, Rank = Grade.E6, FirstName = "Trstram", LastName = "Keetch", MiddleName = "Celia", SSN = "841-78-7245", DOD = "8085066602", DOB = new DateTime(1996, 02, 20), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 137, Rank = Grade.E6, FirstName = "Simmonds", LastName = "Dahlman", MiddleName = "Josias", Sex = BioSex.Male, SSN = "367-46-8841", DOD = "2383654744", DOB = new DateTime(1980, 01, 29), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 138, Rank = Grade.E5, FirstName = "Tuesday", LastName = "Pointon", MiddleName = "Laural", Sex = BioSex.Male, SSN = "134-82-6454", DOD = "3957191394", DOB = new DateTime(1989, 02, 13), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 139, Rank = Grade.E1, FirstName = "Maury", LastName = "Ranby", MiddleName = "Elena", Sex = BioSex.Other, SSN = "761-30-0999", DOD = "8884322642", DOB = new DateTime(1999, 11, 16), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 140, Rank = Grade.O2, FirstName = "Morie", LastName = "Brumhead", MiddleName = "Brion", Sex = BioSex.Male, SSN = "174-27-3250", DOD = "4498856600", DOB = new DateTime(1981, 02, 20), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 141, Rank = Grade.E4, FirstName = "Trula", LastName = "Kastel", Sex = BioSex.Male, SSN = "811-22-3655", DOD = "8053498000", DOB = new DateTime(1995, 11, 23), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 142, Rank = Grade.E7, FirstName = "Charity", LastName = "Ong", MiddleName = "Giff", Sex = BioSex.Male, SSN = "279-31-3013", DOD = "2279815281", DOB = new DateTime(1950, 12, 14), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 143, Rank = Grade.E6, FirstName = "Murdoch", LastName = "Dreye", MiddleName = "Aguste", Sex = BioSex.Female, SSN = "203-63-3140", DOD = "3458482318", DOB = new DateTime(1986, 01, 13), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 144, Rank = Grade.E3, FirstName = "Malena", LastName = "Oguz", MiddleName = "Anissa", Sex = BioSex.Other, SSN = "830-50-5289", DOD = "2363509935", DOB = new DateTime(1990, 01, 24), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 145, Rank = Grade.E4, FirstName = "Timothee", LastName = "Blewis", MiddleName = "Dov", Sex = BioSex.Male, SSN = "268-36-0111", DOD = "8413111390", DOB = new DateTime(1974, 11, 12), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 146, Rank = Grade.E7, FirstName = "Katharine", LastName = "Parlot", MiddleName = "Emlyn", Sex = BioSex.Female, SSN = "219-20-8378", DOD = "6923916518", DOB = new DateTime(1974, 01, 19), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 147, Rank = Grade.E5, FirstName = "Jasen", LastName = "Embling", MiddleName = "Veronique", Sex = BioSex.Male, SSN = "231-06-3830", DOD = "8609599620", DOB = new DateTime(1996, 01, 14), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 148, Rank = Grade.E7, FirstName = "Malanie", LastName = "Snoddin", Sex = BioSex.Female, SSN = "113-96-4677", DOD = "4616607613", DOB = new DateTime(1990, 01, 16), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 149, Rank = Grade.E5, FirstName = "Delano", LastName = "Donahue", Sex = BioSex.Male, SSN = "594-46-5927", DOD = "9536871432", DOB = new DateTime(1985, 11, 04), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 150, Rank = Grade.O1, FirstName = "Ingelbert", LastName = "Checo", MiddleName = "Kittie", Sex = BioSex.Male, SSN = "680-05-6250", DOD = "6773197783", DOB = new DateTime(1986, 11, 08), MaritalStatus = MaritalStatus.Estranged },
                new Personnel() { PersonnelId = 151, Rank = Grade.E4, FirstName = "Roseanna", LastName = "Rex", MiddleName = "Carmella", Sex = BioSex.Female, SSN = "489-75-8946", DOD = "6232165985", DOB = new DateTime(1998, 02, 17), MaritalStatus = MaritalStatus.Widowed },
                new Personnel() { PersonnelId = 152, Rank = Grade.E4, FirstName = "Nikolaos", LastName = "Gewer", Sex = BioSex.Female, SSN = "763-59-4416", DOD = "8344618304", DOB = new DateTime(1994, 01, 29), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 153, Rank = Grade.E5, FirstName = "Blithe", LastName = "Rickarsey", MiddleName = "Ber", Sex = BioSex.Female, SSN = "616-23-8419", DOD = "1091551596", DOB = new DateTime(1957, 12, 08), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 154, Rank = Grade.E5, FirstName = "Nickey", LastName = "Mattingley", MiddleName = "Katina", Sex = BioSex.Male, SSN = "149-04-3090", DOD = "5522634715", DOB = new DateTime(1983, 11, 27), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 155, Rank = Grade.E7, FirstName = "Eberhard", LastName = "Dabes", MiddleName = "Rafe", Sex = BioSex.Female, SSN = "373-50-7012", DOD = "2584421909", DOB = new DateTime(1999, 02, 26), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 156, Rank = Grade.E2, FirstName = "Jsandye", LastName = "Allawy", MiddleName = "Lotte", Sex = BioSex.Male, SSN = "789-78-9606", DOD = "2126928543", DOB = new DateTime(1973, 12, 21), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 157, Rank = Grade.E2, FirstName = "Elvina", LastName = "Luxton", MiddleName = "Inesita", Sex = BioSex.Male, SSN = "838-68-5328", DOD = "1356595561", DOB = new DateTime(1992, 01, 06), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 158, Rank = Grade.E5, FirstName = "Phoebe", LastName = "Di Franceschi", MiddleName = "Johnette", Sex = BioSex.Male, SSN = "129-67-5446", DOD = "3010481314", DOB = new DateTime(1984, 01, 26), MaritalStatus = MaritalStatus.Other },
                new Personnel() { PersonnelId = 159, Rank = Grade.E8, FirstName = "Melania", LastName = "Pegler", MiddleName = "Judi", Sex = BioSex.Female, SSN = "162-35-2857", DOD = "6860636416", DOB = new DateTime(1971, 01, 06), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 160, Rank = Grade.E4, FirstName = "Nady", LastName = "Smee", MiddleName = "Janel", Sex = BioSex.Female, SSN = "245-77-2441", DOD = "6715377499", DOB = new DateTime(1993, 02, 12), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 161, Rank = Grade.E4, FirstName = "Darrell", LastName = "Josef", MiddleName = "Derk", Sex = BioSex.Female, SSN = "714-03-1501", DOD = "8617711124", DOB = new DateTime(1977, 11, 21), MaritalStatus = MaritalStatus.NeverMarried },
                new Personnel() { PersonnelId = 162, Rank = Grade.E5, FirstName = "Carolus", LastName = "Gothup", MiddleName = "Nate", Sex = BioSex.Female, SSN = "231-90-7396", DOD = "7922907192", DOB = new DateTime(1995, 01, 00), MaritalStatus = MaritalStatus.Married },
                new Personnel() { PersonnelId = 163, Rank = Grade.E4, FirstName = "Emmi", LastName = "Colbertson", Sex = BioSex.Male, SSN = "285-32-2341", DOD = "0806365706", DOB = new DateTime(1993, 11, 03), MaritalStatus = MaritalStatus.Divorced },
                new Personnel() { PersonnelId = 164, Rank = Grade.E2, FirstName = "Waylon", LastName = "Rieger", Sex = BioSex.Male, SSN = "209-56-6366", DOD = "3084423857", DOB = new DateTime(1984, 11, 23), MaritalStatus = MaritalStatus.Divorced });
        }
    }
}
