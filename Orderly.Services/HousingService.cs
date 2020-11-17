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
            var entity = new Housing()
            {
                PersonnelId = model.PersonnelId,
                Personnel = model.Personnel,
                Address = model.Address,
                Room = model.Room,
                CreatedBy = _userId,
                CreatedUtc = DateTimeOffset.Now,
                ModifiedLast = Guid.Empty
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.HousingDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<HousingListItem> GetHousing()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .HousingDbSet
                    .Select(
                        e =>
                        new HousingListItem
                        {
                            Id = e.Id,
                            PersonnelId = e.PersonnelId,
                            Personnel = e.Personnel,
                            Address = e.Address,
                            Room = e.Room,
                            CreatedBy = e.CreatedBy,
                            CreatedUtc = e.CreatedUtc,
                            ModifiedLast = e.ModifiedLast,
                            ModifiedUtc = e.ModifiedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public HousingDetail GetHousingByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .HousingDbSet
                    .Single(e => e.PersonnelId == id);
                return
                    new HousingDetail
                    {
                        Id = entity.Id,
                        PersonnelId = entity.PersonnelId,
                        Personnel = entity.Personnel,
                        Address = entity.Address,
                        Room = entity.Room,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateHousing(HousingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .HousingDbSet
                    .Single(e => e.Id == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;
                entity.Address = model.Address;
                entity.Room = model.Room;
                entity.CreatedBy = model.CreatedBy;
                entity.CreatedUtc = model.CreatedUtc;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
