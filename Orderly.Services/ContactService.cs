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
            var entity = new Contact()
            {
                PersonnelId = model.PersonnelId,
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
            using (var ctx = new ApplicationDbContext())
            {
                ctx.ContactDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ContactListItem> GetContacts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .ContactDbSet
                    .Select(
                        e =>
                        new ContactListItem
                        {
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
                            CreatedBy = e.CreatedBy,
                            CreatedUtc = e.CreatedUtc,
                            ModifiedLast = e.ModifiedLast,
                            ModifiedUtc = e.ModifiedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public ContactDetail GetContactByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .ContactDbSet
                    .Single(e => e.PersonnelId == id);
                return
                    new ContactDetail
                    {
                        Id = entity.Id,
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
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateContact(ContactEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .ContactDbSet
                    .Single(e => e.Id == model.Id);
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
                entity.CreatedBy = model.CreatedBy;
                entity.CreatedUtc = model.CreatedUtc;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
