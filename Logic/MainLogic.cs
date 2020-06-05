
using LabSUBD.Models;
using LabSUBD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Logic
{
    public class MainLogic
    {
        private static OfficeDataBase db = Program.db;
        public void Req1()
        {
            var note = db.EmployeeInformations
                .Join(db.Posts,
                c => c.PostId,
                s => s.Id,
                (c, s) => new
                {
                    s.PostName,
                    s.Salary,
                    c.FIO
                });
            foreach (var c in note)
            {
                Console.WriteLine(c.PostName + " " + c.Salary + " " + c.FIO);
            }
        }
        public void Req2()
        {
            var user = from u in db.Departaments
                       join un in db.EmployeeInformations on u.Id equals un.DepartamentId
                       join n in db.Specialties on un.SpecialtyId equals n.Id
                       orderby u.DepartamentName
                       select new { u.DepartamentName, un.FIO, n.SpecialtyName };
            foreach (var c in user)
            {
                Console.WriteLine(c.DepartamentName + " " + c.FIO + " " + c.SpecialtyName);
            }
        }

    }
}
