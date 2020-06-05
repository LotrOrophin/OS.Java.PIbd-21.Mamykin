using LabSUBD.Interface;
using LabSUBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class EmployeeInformationLogic
    {
        private static OfficeDataBase db = Program.db;

        public void Create(string FIO, DateTime date, string Registration, string birthPlace, string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber, int departamentId, int postId, int specialtyId)
        {
            EmployeeInformation eiModel = new EmployeeInformation()
            {
                FIO = FIO,
                Date = date,
                Registration = Registration,
                BirthPlace = birthPlace,
                Citizenship = citizenship,
                MaritalStatus = maritalStatus,
                ProfessionalExpirience = professionalExpirience,
                PremiumBonus = premiumBonus,
                PhoneNumber = phoneNumber,
                DepartamentId = departamentId,
                SpecialtyId = specialtyId,
                PostId = postId
            };
            var ei = db.EmployeeInformations.FirstOrDefault(c => c.FIO == eiModel.FIO);
            if (ei != null)
            {
                throw new Exception("Такое работник уже есть");
            }
            db.EmployeeInformations.Add(eiModel);
            db.SaveChanges();
        }

        public void Update(int Id, string FIO, DateTime date, string Registration, string birthPlace, string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber)
        {
            EmployeeInformation eiModel = new EmployeeInformation()
            {
                Id = Id,
                FIO = FIO,
                Date = date,
                Registration = Registration,
                BirthPlace = birthPlace,
                Citizenship = citizenship,
                MaritalStatus = maritalStatus,
                ProfessionalExpirience = professionalExpirience,
                PremiumBonus = premiumBonus,
                PhoneNumber = phoneNumber
            };
            var ei = db.EmployeeInformations.FirstOrDefault(c => c.Id == eiModel.Id);
            if (ei == null)
            {
                throw new Exception("Такго работника  нет");
            }
            ei.FIO = eiModel.FIO;
            db.SaveChanges();
        }

        public void Delete(int Id, string FIO, DateTime date, string Registration, string birthPlace, string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber)
        {
            EmployeeInformation eiModel = new EmployeeInformation()
            {
                Id = Id,
                FIO = FIO,
                Date = date,
                Registration = Registration,
                BirthPlace = birthPlace,
                Citizenship = citizenship,
                MaritalStatus = maritalStatus,
                ProfessionalExpirience = professionalExpirience,
                PremiumBonus = premiumBonus,
                PhoneNumber = phoneNumber
            };
            var ei = db.EmployeeInformations.FirstOrDefault(c => c.Id == eiModel.Id);
            if (ei == null)
            {
                throw new Exception("Такого работника нет");
            }
            db.EmployeeInformations.Remove(ei);
            db.SaveChanges();
        }

        public void Read()
        {
            var list = db.EmployeeInformations.ToList();
            foreach (var p in list)
            {
                Console.WriteLine(p.Id + " " + p.FIO + " " + p.Date + " " + p.ProfessionalExpirience + " Телефон: " + p.PhoneNumber + " " + p.MaritalStatus);
            }
        }

        public void ReadPage(int StringToSkip, int StringToOutput)
        {
            var ei = from employeeI in db.EmployeeInformations.Skip(StringToSkip).Take(StringToOutput)
                     select new
                     {
                         employeeI.FIO,
                         employeeI.Id,
                         employeeI.PhoneNumber,
                         employeeI.MaritalStatus
                     };
            foreach (var p in ei)
            {
                Console.WriteLine(p.Id + " " + p.FIO + " " + " Телефон: " + p.PhoneNumber + " " + p.MaritalStatus);
            }
        }

        public EmployeeInformation Get(int Id)
        {
            return db.EmployeeInformations.FirstOrDefault(c => c.Id == Id);
        }
    }
}
