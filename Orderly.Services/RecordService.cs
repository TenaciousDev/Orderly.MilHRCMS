using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class RecordService
    {
        private readonly Guid _userId;
        public RecordService(Guid userId)
        {
            _userId = userId;
        }
        //TEST
        /*        public IEnumerable<RecordListItem> GetRecordsTest()
                {
                    using (var ctx = new ApplicationDbContext())
                    {
                        List<RecordListItem> Records = new List<RecordListItem>();

                        var recordList = (
                            from p in ctx.PersonnelDbSet
                            join u in ctx.Users on p.CreatedBy.ToString() equals u.Id
                            join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                            join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                            join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                            //join sqd in ctx.SquadDbSet on ui.Team.Squad.SquadId equals sqd.Id
                            //join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.PlatoonId equals plt.Id
                            select new
                            {
                                //Personnel
                                p.PersonnelId,
                                p.Rank,
                                p.FirstName,
                                p.LastName,
                                p.MiddleName,
                                p.Sex,
                                p.SSN,
                                p.DOD,
                                p.DOB,
                                p.MaritalStatus,
                                //Contact
                                c.ContactId,
                                c.PhoneNumber,
                                c.PersonalEmail,
                                c.MilEmail,
                                c.HasDriversLicense,
                                c.VehicleMake,
                                c.VehicleModel,
                                c.VehicleColor,
                                c.VehiclePlate,
                                c.VehicleYear,
                                c.VehicleInspected,
                                //Housing
                                h.HousingId,
                                h.Address,
                                h.Room,
                                //UnitInfo
                                ui.UnitInfoId,
                                ui.TeamId,
                                //sqd.SquadId,
                                //plt.PlatoonId,
                                ui.Role,
                                ui.Arrived,
                                ui.LossDate,
                                ui.DutyStatus
                            }).ToList();
                        foreach (var model in recordList)
                        {
                            RecordListItem record = new RecordListItem();
                            //Personnel
                            record.PersonnelId = model.PersonnelId;
                            record.Rank = model.Rank;
                            record.FirstName = model.FirstName;
                            record.LastName = model.LastName;
                            record.MiddleName = model.MiddleName;
                            record.Sex = model.Sex;
                            record.SSN = model.SSN;
                            record.DOD = model.DOD;
                            record.DOB = model.DOB;
                            record.MaritalStatus = model.MaritalStatus;
                            //Contact
                            record.PersonnelId = model.PersonnelId;
                            record.PhoneNumber = model.PhoneNumber;
                            record.PersonalEmail = model.PersonalEmail;
                            record.MilEmail = model.MilEmail;
                            record.HasDriversLicense = model.HasDriversLicense;
                            record.VehicleMake = model.VehicleMake;
                            record.VehicleModel = model.VehicleModel;
                            record.VehicleColor = model.VehicleColor;
                            record.VehicleYear = model.VehicleYear;
                            record.VehicleInspected = model.VehicleInspected;
                            //Housing
                            record.PersonnelId = model.PersonnelId;
                            record.Address = model.Address;
                            record.Room = model.Room;
                            //UnitInfo
                            record.PersonnelId = model.PersonnelId;
                            record.TeamId = model.TeamId;
                            record.Role = model.Role;
                            record.Arrived = model.Arrived;
                            record.LossDate = model.LossDate;
                            record.DutyStatus = model.DutyStatus;

                            Records.Add(record);
                        }
                        return Records;
                    }
                }
        */
        public IEnumerable<RecordListItem> GetRecords()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from p in ctx.PersonnelDbSet
                    join u in ctx.Users on p.CreatedBy.ToString() equals u.Id
                    join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                    join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                    join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                    join sqd in ctx.SquadDbSet on ui.Team.Squad.SquadId equals sqd.SquadId
                    join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.PlatoonId equals plt.PlatoonId
                    select new RecordListItem
                    {
                        //Personnel
                        Personnel = p,
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
                        //Contact
                        Contact = c,
                        ContactId = c.ContactId,
                        PhoneNumber = c.PhoneNumber,
                        PersonalEmail = c.PersonalEmail,
                        MilEmail = c.MilEmail,
                        HasDriversLicense = c.HasDriversLicense,
                        VehicleMake = c.VehicleMake,
                        VehicleModel = c.VehicleModel,
                        VehicleColor = c.VehicleColor,
                        VehiclePlate = c.VehiclePlate,
                        VehicleYear = c.VehicleYear,
                        VehicleInspected = c.VehicleInspected,
                        //Housing
                        Housing = h,
                        HousingId = h.HousingId,
                        Address = h.Address,
                        Room = h.Room,
                        //UnitInfo
                        UnitInfo = ui,
                        UnitInfoId = ui.UnitInfoId,
                        TeamId = ui.TeamId,
                        Team = ui.Team,
                        SquadId = sqd.SquadId,
                        Squad = sqd,
                        PlatoonId = plt.PlatoonId,
                        Platoon = plt,
                        Role = ui.Role,
                        Arrived = ui.Arrived,
                        LossDate = ui.LossDate,
                        DutyStatus = ui.DutyStatus
                    };
                return query.ToArray();
            }
        }
        public RecordDetail GetRecordByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (
                    from p in ctx.PersonnelDbSet
                    join u in ctx.Users on p.CreatedBy.ToString() equals u.Id
                    join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                    join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                    join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                    join sqd in ctx.SquadDbSet on ui.Team.Squad.SquadId equals sqd.SquadId
                    join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.PlatoonId equals plt.PlatoonId
                    where p.PersonnelId == id
                    select new RecordDetail
                    {
                        //Personnel
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
                        PersonnelCreatedBy = p.CreatedBy,
                        PersonnelCreatedByUserName = u.UserName,
                        PersonnelCreatedUtc = p.CreatedUtc,
                        PersonnelModifiedByUserName = p.ModifiedByUserName,
                        PersonnelModifiedLast = p.ModifiedLast,
                        PersonnelModifiedUtc = p.ModifiedUtc,

                        //Contact
                        ContactId = c.ContactId,
                        //Personnel = c.Personnel,
                        PhoneNumber = c.PhoneNumber,
                        PersonalEmail = c.PersonalEmail,
                        MilEmail = c.MilEmail,
                        HasDriversLicense = c.HasDriversLicense,
                        VehicleMake = c.VehicleMake,
                        VehicleModel = c.VehicleModel,
                        VehicleColor = c.VehicleColor,
                        VehiclePlate = c.VehiclePlate,
                        VehicleYear = c.VehicleYear,
                        VehicleInspected = c.VehicleInspected,

                        ContactCreatedBy = c.CreatedBy,
                        ContactCreatedByUserName = u.UserName,
                        ContactCreatedUtc = c.CreatedUtc,
                        ContactModifiedByUserName = c.ModifiedByUserName,
                        ContactModifiedLast = c.ModifiedLast,
                        ContactModifiedUtc = c.ModifiedUtc,
                        //Housing
                        HousingId = h.HousingId,
                        Address = h.Address,
                        Room = h.Room,
                        HousingCreatedBy = h.CreatedBy,
                        HousingCreatedByUserName = u.UserName,
                        HousingCreatedUtc = h.CreatedUtc,
                        HousingModifiedByUserName = h.ModifiedByUserName,
                        HousingModifiedLast = h.ModifiedLast,
                        HousingModifiedUtc = h.ModifiedUtc,
                        //UnitInfo
                        UnitInfoId =ui.UnitInfoId,
                        TeamId = ui.TeamId,
                        Team = ui.Team,
                        SquadId = sqd.SquadId,
                        Squad = sqd,
                        PlatoonId = plt.PlatoonId,
                        Platoon = plt,
                        Role = ui.Role,
                        Arrived = ui.Arrived,
                        LossDate = ui.LossDate,
                        DutyStatus = ui.DutyStatus,
                        UnitInfoCreatedBy = ui.CreatedBy,
                        UnitInfoCreatedByUserName = u.UserName,
                        UnitInfoCreatedUtc = ui.CreatedUtc,
                        UnitInfoModifiedLast = ui.ModifiedLast,
                        UnitInfoModifiedByUserName = ui.ModifiedByUserName,
                        UnitInfoModifiedUtc = ui.ModifiedUtc
                    }
                    ).SingleOrDefault();
                return record;
            }
        }
        public bool UpdateRecord(RecordEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var linkedSquad = ctx.UnitInfoDbSet.Find(model.Team.Squad);
                var sqd = ctx.SquadDbSet.Find(linkedSquad.Team.SquadId);
                var linkedPlatoon = ctx.UnitInfoDbSet.Find(model.Team.Squad.Platoon);
                var plt = ctx.PlatoonDbSet.Find(linkedPlatoon.Team.Squad.PlatoonId);
                var user = ctx.Users.Find(_userId.ToString());
                var contact = ctx.ContactDbSet.Find(model.ContactId);
                var housing = ctx.HousingDbSet.Find(model.HousingId);
                var unitInfo = ctx.UnitInfoDbSet.Find(model.UnitInfoId);
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == model.PersonnelId);
                //Personnel
                entity.PersonnelId = model.PersonnelId;
                entity.Rank = model.Rank;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.MiddleName = model.MiddleName;
                entity.Sex = model.Sex;
                entity.SSN = model.SSN;
                entity.DOD = model.DOD;
                entity.DOB = model.DOB;
                entity.MaritalStatus = model.MaritalStatus;
                entity.ModifiedByUserName = user.UserName;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                //Contact
                contact.PersonnelId = model.PersonnelId;
                contact.Personnel = model.Personnel;
                contact.PhoneNumber = model.PhoneNumber;
                contact.PersonalEmail = model.PersonalEmail;
                contact.MilEmail = model.MilEmail;
                contact.HasDriversLicense = model.HasDriversLicense;
                contact.VehicleMake = model.VehicleMake;
                contact.VehicleModel = model.VehicleModel;
                contact.VehicleColor = model.VehicleColor;
                contact.VehicleYear = model.VehicleYear;
                contact.VehicleInspected = model.VehicleInspected;
                contact.ModifiedByUserName = user.UserName;
                contact.ModifiedLast = _userId;
                contact.ModifiedUtc = DateTimeOffset.Now;
                //Housing
                housing.PersonnelId = model.PersonnelId;
                housing.Personnel = model.Personnel;
                housing.Address = model.Address;
                housing.Room = model.Room;
                housing.ModifiedByUserName = user.UserName;
                housing.ModifiedLast = _userId;
                housing.ModifiedUtc = DateTimeOffset.Now;
                //UnitInfo
                unitInfo.PersonnelId = model.PersonnelId;
                unitInfo.Personnel = model.Personnel;
                unitInfo.TeamId = model.TeamId;
                unitInfo.Team = model.Team;
                unitInfo.Team.Squad.SquadId = sqd.SquadId;
                unitInfo.Team.Squad.Platoon.PlatoonId = plt.PlatoonId;
                unitInfo.Role = model.Role;
                unitInfo.Arrived = model.Arrived;
                unitInfo.LossDate = model.LossDate;
                unitInfo.DutyStatus = model.DutyStatus;
                unitInfo.ModifiedByUserName = user.UserName;
                unitInfo.ModifiedLast = _userId;
                unitInfo.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() >= 1;
            }
        }
    }
}