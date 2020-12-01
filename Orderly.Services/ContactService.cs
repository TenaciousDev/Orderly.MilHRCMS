using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class ContactService
    {
        private readonly Guid _userId;
        public ContactService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateContact(ContactCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var newEntry = ctx.PersonnelDbSet.OrderByDescending(o => o.PersonnelId).FirstOrDefault();
                var newId = newEntry.PersonnelId;

                var entity = new Contact()
                {
                    PersonnelId = newId,
                    Personnel = model.Personnel,
                    PhoneNumber = model.PhoneNumber,
                    PersonalEmail = model.PersonalEmail,
                    MilEmail = model.MilEmail,
                    HasDriversLicense = model.HasDriversLicense,
                    VehicleMake = model.VehicleMake,
                    VehicleModel = model.VehicleModel,
                    VehicleColor = model.VehicleColor,
                    VehiclePlate = model.VehiclePlate,
                    VehicleYear = model.VehicleYear,
                    VehicleInspected = model.VehicleInspected,
                    CreatedBy = _userId,
                    CreatedUtc = DateTimeOffset.Now,
                    ModifiedLast = Guid.Empty
                };
                ctx.ContactDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ContactListItem> GetContacts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from e in ctx.ContactDbSet
                    join u in ctx.Users on
                    e.CreatedBy.ToString() equals u.Id
                    //ctx
                    //.ContactDbSet
                    select new ContactListItem
                    {
                        Id = e.ContactId,
                        PersonnelId = e.PersonnelId,
                        Personnel = e.Personnel,
                        PhoneNumber = e.PhoneNumber,
                        PersonalEmail = e.PersonalEmail,
                        MilEmail = e.MilEmail,
                        HasDriversLicense = e.HasDriversLicense,
                        VehicleMake = e.VehicleMake,
                        VehicleModel = e.VehicleModel,
                        VehicleColor = e.VehicleColor,
                        VehiclePlate = e.VehiclePlate,
                        VehicleYear = e.VehicleYear,
                        VehicleInspected = e.VehicleInspected,
                        CreatedByUserName = u.UserName,
                        CreatedBy = e.CreatedBy,
                        CreatedUtc = e.CreatedUtc,
                        ModifiedLast = e.ModifiedLast,
                        ModifiedUtc = e.ModifiedUtc
                    };
                return query.ToArray();
            }
        }
        public ContactDetail GetContactByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (
                    from entity
                    in ctx.ContactDbSet
                    join u in ctx.Users
                    on entity.CreatedBy.ToString()
                    equals u.Id
                    where entity.PersonnelId == id
                    //ctx
                    //.ContactDbSet
                    //.Single(e => e.PersonnelId == id);
                    //return
                    select new ContactDetail
                    {
                        Id = entity.ContactId,
                        PersonnelId = entity.PersonnelId,
                        Personnel = entity.Personnel,
                        PhoneNumber = entity.PhoneNumber,
                        PersonalEmail = entity.PersonalEmail,
                        MilEmail = entity.MilEmail,
                        HasDriversLicense = entity.HasDriversLicense,
                        VehicleMake = entity.VehicleMake,
                        VehicleModel = entity.VehicleModel,
                        VehicleColor = entity.VehicleColor,
                        VehiclePlate = entity.VehiclePlate,
                        VehicleYear = entity.VehicleYear,
                        VehicleInspected = entity.VehicleInspected,
                        CreatedByUserName = u.UserName,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    }).SingleOrDefault();
                return record;
            }
        }
        public bool UpdateContact(ContactEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var user = ctx.Users.Find(_userId.ToString());
                var userName = user.UserName;
                var entity =
                    ctx
                    .ContactDbSet
                    .Single(e => e.ContactId == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;
                entity.PhoneNumber = model.PhoneNumber;
                entity.PersonalEmail = model.PersonalEmail;
                entity.MilEmail = model.MilEmail;
                entity.HasDriversLicense = model.HasDriversLicense;
                entity.VehicleMake = model.VehicleMake;
                entity.VehicleModel = model.VehicleModel;
                entity.VehicleColor = model.VehicleColor;
                entity.VehicleYear = model.VehicleYear;
                entity.VehicleInspected = model.VehicleInspected;
                entity.ModifiedByUserName = userName;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
