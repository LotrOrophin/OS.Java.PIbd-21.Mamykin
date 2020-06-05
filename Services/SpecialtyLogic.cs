using LabSUBD.Interface;
using LabSUBD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class SpecialtyLogic
    {
        private static OfficeDataBase db = Program.db;

        public void Create(string specialtyName)
        {
            Specialty specialtyModel= new Specialty()
            {
                SpecialtyName = specialtyName,
            };
            var specialty = db.Specialties.FirstOrDefault(c => c.SpecialtyName == specialtyModel.SpecialtyName);
            if (specialty != null)
            {
                throw new Exception("Такая специальность уже существует");
            }
            db.Specialties.Add(specialtyModel);
            db.SaveChanges();
        }

        public void Delete(int Id, string specialtyName)
        {
            Specialty specialtyModel = new Specialty()
            {
                Id = Id,
                SpecialtyName = specialtyName,
            };
            var specialty = db.Specialties.FirstOrDefault(c => c.SpecialtyName == specialtyModel.SpecialtyName);
            if (specialty == null)
            {
                throw new Exception("Такой специальности нет");
            }
            db.Specialties.Remove(specialty);
            db.SaveChanges();
        }

        public void Updateint (int Id, string specialtyName)
        {
            Specialty specialtyModel = new Specialty()
            {
                Id = Id,
                SpecialtyName = specialtyName,
            };
            var specialty = db.Specialties.FirstOrDefault(c => c.SpecialtyName == specialtyModel.SpecialtyName);
            if (specialty == null)
            {
                throw new Exception("Такой специальности нет");
            }
            specialty.SpecialtyName = specialtyModel.SpecialtyName;
            db.SaveChanges();
        }

        public static void Read()
        {
            foreach (var p in db.Specialties.ToList())
            {
                Console.WriteLine("Специальность:  " + p.SpecialtyName);
            }
        }
        public void ReadPage(int StringToSkip, int StringToOutput)
        {
            var specialty = from s in db.Specialties.Skip(StringToSkip).Take(StringToOutput)
                     select new
                     {
                         s.SpecialtyName,
                     };
            foreach (var p in specialty)
            {
                Console.WriteLine(p.SpecialtyName);
            }
        }

        public Specialty Get(int Id)
        {
            return db.Specialties.FirstOrDefault(c => c.Id == Id);
        }
        
    }
}
