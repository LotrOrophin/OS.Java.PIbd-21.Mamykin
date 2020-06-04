using LabSUBD.Interface;
using LabSUBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class EmployeeInformationLogic : ILogic<EmployeeInformation>
    {
        private static OfficeDataBase db = Program.db;

        public void Create(EmployeeInformation model)
        {
            var news = db.EmployeeInformations.FirstOrDefault(c => c.FIO == model.FIO);
            if (news != null)
            {
                throw new Exception("Такое работник уже есть");
            }
            db.EmployeeInformations.Add(model);
            db.SaveChanges();
        }

        public void Update(EmployeeInformation model)
        {
            var news = db.EmployeeInformations.FirstOrDefault(c => c.Id == model.Id);
            if (news == null)
            {
                throw new Exception("Такго работника  нет");
            }
            news.FIO = model.FIO;
            db.SaveChanges();
        }

        public void Delete(EmployeeInformation model)
        {
            var news = db.EmployeeInformations.FirstOrDefault(c => c.Id == model.Id);
            if (news == null)
            {
                throw new Exception("Такого работника нет");
            }
            db.EmployeeInformations.Remove(news);
            db.SaveChanges();
        }

        public List<EmployeeInformation> Read()
        {
            return db.EmployeeInformations.ToList();
        }

        public EmployeeInformation Get(int Id)
        {
            return db.EmployeeInformations.FirstOrDefault(c => c.Id == Id);
        }
    }
}
