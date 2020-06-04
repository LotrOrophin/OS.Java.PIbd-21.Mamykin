using LabSUBD.Interface;
using LabSUBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class DepartamentLogic: ILogic<Departament>
    {
        private static OfficeDataBase db = Program.db;

        public void Create(Departament model)
        {
            var user = db.Departaments.FirstOrDefault(c => c.Id == model.Id);
            if (user != null)
            {
                throw new Exception("Такой отдел уже есть");
            }
            db.Departaments.Add(model);
            db.SaveChanges();
        }

        public void Delete(Departament model)
        {
            var user = db.Departaments.FirstOrDefault(c => c.Id == model.Id);
            if (user == null)
            {
                throw new Exception("Такого отдела нет");
            }
            db.Departaments.Remove(user);
            db.SaveChanges();
        }

        public void Update(Departament model)
        {
            var user = db.Departaments.FirstOrDefault(c => c.Id == model.Id);
            if (user == null)
            {
                throw new Exception("Такого отдела нет");
            }
            user.DepartamentName = model.DepartamentName;
            db.SaveChanges();
        }
        public List<Departament> Read()
        {
            return db.Departaments.ToList();
        }

        public Departament Get(int Id)
        {
            return db.Departaments.FirstOrDefault(c => c.Id == Id);
        }        
    }
}
