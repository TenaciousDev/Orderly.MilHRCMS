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
        public IEnumerable<RecordListItem> GetRecords()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from p in ctx.PersonnelDbSet
                    join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                    join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                    join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                    join sqd in ctx.SquadDbSet on ui.Team.Squad.Id equals sqd.Id
                    join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.Id equals plt.Id
                    select new RecordListItem
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
                    //Contact
                        ContactId = c.Id,
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
                        //Housing
                        Address = h.Address,
                        Room = h.Room,
                        //UnitInfo
                        TeamId = ui.TeamId,
                        Team = ui.Team,
                        SquadId = sqd.Id,
                        Squad = sqd,
                        PlatoonId = plt.Id,
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
                    join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                    join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                    join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                    join sqd in ctx.SquadDbSet on ui.Team.Squad.Id equals sqd.Id
                    join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.Id equals plt.Id
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
                        //Contact
                        ContactId = c.Id,
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
                        //Housing
                        Address = h.Address,
                        Room = h.Room,
                        //UnitInfo
                        TeamId = ui.TeamId,
                        Team = ui.Team,
                        SquadId = sqd.Id,
                        Squad = sqd,
                        PlatoonId = plt.Id,
                        Platoon = plt,
                        Role = ui.Role,
                        Arrived = ui.Arrived,
                        LossDate = ui.LossDate,
                        DutyStatus = ui.DutyStatus
                    }
                    ).SingleOrDefault();
                return record;
            }
        }
    }
}
