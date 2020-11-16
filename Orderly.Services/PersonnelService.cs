using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class PersonnelService
    {
        private readonly Guid _userId;
        public PersonnelService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePersonnel(PersonnelCreate model)
        {
            var entity = new Personnel()
            {
                Rank = model.Rank,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                Sex = model.Sex,
                SSN = model.SSN,
                DOD = model.DOD,
                DOB = model.DOB,
                MaritalStatus = model.MaritalStatus,
                CreatedBy = _userId,
                CreatedUtc = DateTimeOffset.Now,
                ModifiedLast = Guid.Empty
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.PersonnelDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PersonnelListItem> GetPersonnel()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .PersonnelDbSet
                    .Select(
                        e =>
                        new PersonnelListItem
                        {
                            PersonnelId = e.PersonnelId,
                            Rank = e.Rank,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            MiddleName = e.MiddleName,
                            Sex = e.Sex,
                            SSN = e.SSN,
                            DOD = e.DOD,
                            DOB = e.DOB,
                            MaritalStatus = e.MaritalStatus,
                            CreatedBy = e.CreatedBy,
                            ModifiedLast = e.ModifiedLast,
                            CreatedUtc = e.CreatedUtc,
                            ModifiedUtc = e.ModifiedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public PersonnelDetail GetPersonnelById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == id);
                return
                    new PersonnelDetail
                    {
                        PersonnelId = entity.PersonnelId,
                        Rank = entity.Rank,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        MiddleName = entity.MiddleName,
                        Sex = entity.Sex,
                        SSN = entity.SSN,
                        DOD = entity.DOD,
                        DOB = entity.DOB,
                        MaritalStatus = entity.MaritalStatus,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdatePersonnel(PersonnelEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == model.PersonnelId);
                entity.Rank = model.Rank;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.MiddleName = model.MiddleName;
                entity.Sex = model.Sex;
                entity.SSN = model.SSN;
                entity.DOD = model.DOD;
                entity.DOB = model.DOB;
                entity.MaritalStatus = model.MaritalStatus;
                entity.CreatedBy = model.CreatedBy;
                entity.CreatedUtc = model.CreatedUtc;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
