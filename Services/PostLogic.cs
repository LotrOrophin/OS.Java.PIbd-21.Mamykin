using LabSUBD.Interface;
using LabSUBD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class PostLogic : ILogic<Post>
    {
        private static OfficeDataBase db = Program.db;

        public void Create(Post model)
        {
            var post = db.Posts.FirstOrDefault(c => c.PostName == model.PostName);
            if (post != null)
            {
                throw new Exception("Такая должность уже есть");
            }
            db.Posts.Add(model);
            db.SaveChanges();
        }

        public void Delete(Post model)
        {
            var post = db.Posts.FirstOrDefault(c => c.PostName == model.PostName);
            if (post == null)
            {
                throw new Exception("Такой должности нет");
            }
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Update(Post model)
        {
            var post = db.Posts.FirstOrDefault(c => c.PostName == model.PostName);
            if (post == null)
            {
                throw new Exception("Такой должности нет");
            }
            post.PostName = model.PostName;
            db.SaveChanges();
        }

        public List<Post> Read()
        {
            return db.Posts.ToList();
        }

        public Post Get(int Id)
        {
            return db.Posts.FirstOrDefault(c => c.Id == Id);
        }
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
                Console.WriteLine(c.DepartamentName + " " + c.FIO + " "+c.SpecialtyName);
            }
        }
    }
}
