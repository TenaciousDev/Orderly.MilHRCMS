using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class HousingService
    {
        private readonly Guid _userId;
        public HousingService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateHousing(HousingCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var newEntry = ctx.PersonnelDbSet.OrderByDescending(o => o.PersonnelId).FirstOrDefault();
                var newId = newEntry.PersonnelId;
                var entity = new Housing()
                {
                    PersonnelId = newId,
                    Personnel = model.Personnel,
                    Address = model.Address,
                    Room = model.Room,
                    CreatedBy = _userId,
                    CreatedUtc = DateTimeOffset.Now,
                    ModifiedLast = Guid.Empty
                };
                ctx.HousingDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<HousingListItem> GetHousing()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from e in ctx.HousingDbSet
                    join u in ctx.Users on e.CreatedBy.ToString() equals u.Id
                    select new HousingListItem
                    {
                        Id = e.HousingId,
                        PersonnelId = e.PersonnelId,
                        Personnel = e.Personnel,
                        Address = e.Address,
                        Room = e.Room,
                        CreatedByUserName = u.UserName,
                        CreatedBy = e.CreatedBy,
                        CreatedUtc = e.CreatedUtc,
                        ModifiedByUserName = e.ModifiedByUserName,
                        ModifiedLast = e.ModifiedLast,
                        ModifiedUtc = e.ModifiedUtc
                    };
                return query.ToArray();
            }
        }
        public HousingDetail GetHousingByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (
                    from entity
                    in ctx.HousingDbSet
                    join u in ctx.Users
                    on entity.CreatedBy.ToString()
                    equals u.Id
                    where entity.PersonnelId == id
                    select new HousingDetail
                    {
                        Id = entity.HousingId,
                        PersonnelId = entity.PersonnelId,
                        Personnel = entity.Personnel,
                        Address = entity.Address,
                        Room = entity.Room,
                        CreatedByUserName = u.UserName,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    }).SingleOrDefault();
                return record;
            }
        }
        public bool UpdateHousing(HousingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var user = ctx.Users.Find(_userId.ToString());
                var userName = user.UserName;
                var entity =
                    ctx
                    .HousingDbSet
                    .Single(e => e.HousingId == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;
                entity.Address = model.Address;
                entity.Room = model.Room;
                entity.ModifiedByUserName = userName;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
