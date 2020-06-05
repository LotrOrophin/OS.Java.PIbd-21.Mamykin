using LabSUBD.Interface;
using LabSUBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class DepartamentLogic
    {
        private static OfficeDataBase db = Program.db;

        public void Create(string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            Departament departamentModel = new Departament()
            {
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss
            };
            var departament = db.Departaments.FirstOrDefault(c => c.Id == departamentModel.Id);
            if (departament != null)
            {
                throw new Exception("Такой отдел уже есть");
            }
            db.Departaments.Add(departamentModel);
            db.SaveChanges();
        }

        public void Delete(int id, string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            Departament departament = new Departament()
            {
                Id = id,
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss
            };
            var user = db.Departaments.FirstOrDefault(c => c.Id == departament.Id);
            if (user == null)
            {
                throw new Exception("Такого отдела нет");
            }
            db.Departaments.Remove(user);
            db.SaveChanges();
        }
        public void Update(int Id, string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            var list = Get(Id);
            Departament departament = new Departament()
            {
                Id = list.Id,
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss
            };
            var user = db.Departaments.FirstOrDefault(c => c.Id == departament.Id);
            if (user == null)
            {
                throw new Exception("Такого отдела нет");
            }
            user.DepartamentName = departament.DepartamentName;
            db.SaveChanges();
        }
        public void Read()
        {
            foreach (var p in db.Departaments.ToList())
            {
                Console.WriteLine(p.DepartamentName + ". Босс: " + p.Boss);
            }
        }
        public void ReadPage(int StringToSkip, int StringToOutput)
        {
            var ei = from d in db.Departaments.Skip(StringToSkip).Take(StringToOutput)
                     select new
                     {
                         d.DepartamentName,
                         d.Boss,
                         d.Building,
                         d.PhoneNumber
                     };
            foreach (var p in ei)
            {
                Console.WriteLine(p.DepartamentName + " Начальник: " + p.Boss + " Корпус: " + p.Building + " Телефон: " + p.PhoneNumber);
            }
        }

            public Departament Get(int Id)
        {
            return db.Departaments.FirstOrDefault(c => c.Id == Id);
        }        
    }
}
