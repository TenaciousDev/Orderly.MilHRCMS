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
                    from p in ctx.PersonnelDbSet
                    join u in ctx.Users on p.CreatedBy.ToString() equals u.Id
                    select new PersonnelListItem
                    {
                        PersonnelId = p.PersonnelId,
                        Rank = p.Rank,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        MiddleName = p.MiddleName,
                        Sex = p.Sex,
                        SSN = p.SSN,
                        DOD = p.DOD,
                        DOB = p.DOB,
                        MaritalStatus = p.MaritalStatus,
                        CreatedByUserName = u.UserName,
                        CreatedBy = p.CreatedBy,
                        ModifiedLast = p.ModifiedLast,
                        ModifiedByUserName = p.ModifiedByUserName,
                        CreatedUtc = p.CreatedUtc,
                        ModifiedUtc = p.ModifiedUtc
                    };
                return query.ToArray();
            }
        }
        public PersonnelDetail GetPersonnelById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (from entity in ctx.PersonnelDbSet
                              join u in ctx.Users on entity.CreatedBy.ToString() equals u.Id
                              where entity.PersonnelId == id
                              select new PersonnelDetail
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
                                  CreatedByUserName = u.UserName,
                                  CreatedUtc = entity.CreatedUtc,
                                  ModifiedLast = entity.ModifiedLast,
                                  ModifiedUtc = entity.ModifiedUtc
                              }).SingleOrDefault();
                return record;
            }
        }
        public bool UpdatePersonnel(PersonnelEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var user = ctx.Users.Find(_userId.ToString());
                var userName = user.UserName;
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
                entity.ModifiedByUserName = userName;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
