using LabSUBD.Interface;
using LabSUBD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class SpecialtyLogic : ILogic<Specialty>
    {
        private static OfficeDataBase db = Program.db;

        public void Create(Specialty model)
        {
            var userEvent = db.Specialties.FirstOrDefault(c => c.SpecialtyName == model.SpecialtyName);
            if (userEvent != null)
            {
                throw new Exception("Такая специальность уже существует");
            }
            db.Specialties.Add(model);
            db.SaveChanges();
        }

        public void Delete(Specialty model)
        {
            var userEvent = db.Specialties.FirstOrDefault(c => c.SpecialtyName == model.SpecialtyName);
            if (userEvent == null)
            {
                throw new Exception("Такой специальности нет");
            }
            db.Specialties.Remove(userEvent);
            db.SaveChanges();
        }

        public void Update(Specialty model)
        {
            var userEvent = db.Specialties.FirstOrDefault(c => c.SpecialtyName == model.SpecialtyName);
            if (userEvent == null)
            {
                throw new Exception("Такой специальности нет");
            }
            userEvent.SpecialtyName = model.SpecialtyName;
            db.SaveChanges();
        }

        public List<Specialty> Read()
        {
            return db.Specialties.ToList();
        }

        public Specialty Get(int Id)
        {
            return db.Specialties.FirstOrDefault(c => c.Id == Id);
        }
        
    }
}
