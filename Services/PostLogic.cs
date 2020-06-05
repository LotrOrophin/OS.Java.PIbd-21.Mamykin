using LabSUBD.Interface;
using LabSUBD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSUBD.Services
{
    public class PostLogic
    {
        private static OfficeDataBase db = Program.db;

        public void Create(string PostName, int Salary)
        {
            Post postModel = new Post()
            {
                PostName = PostName,
                Salary = Salary
            };
            var post = db.Posts.FirstOrDefault(c => c.PostName == postModel.PostName);
            if (post != null)
            {
                throw new Exception("Такая должность уже есть");
            }
            db.Posts.Add(postModel);
            db.SaveChanges();
        }

        public void Delete(int Id, string PostName, int Salary)
        {
            Post postModel = new Post()
            {
                Id = Id,
                PostName = PostName,
                Salary = Salary
            };
            var post = db.Posts.FirstOrDefault(c => c.PostName == postModel.PostName);
            if (post == null)
            {
                throw new Exception("Такой должности нет");
            }
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Update(int Id, string PostName, int Salary)
        {
            Post postModel = new Post()
            {
                Id = Id,
                PostName = PostName,
                Salary = Salary
            };
            var post = db.Posts.FirstOrDefault(c => c.PostName == postModel.PostName);
            if (post == null)
            {
                throw new Exception("Такой должности нет");
            }
            post.PostName = postModel.PostName;
            db.SaveChanges();
        }

        public void Read()
        {
            foreach (var p in db.Posts.ToList())
            {
                Console.WriteLine(p.PostName + ".  Зарплата:  " + p.Salary);
            }
        }
        public void ReadPage(int StringToSkip, int StringToOutput)
        {
            var posts = from p in db.Posts.Skip(StringToSkip).Take(StringToOutput)
                     select new
                     {
                         p.PostName,
                         p.Salary
                     };
            foreach (var p in posts)
            {
                Console.WriteLine(p.PostName + " Зарплата:" + p.Salary);
            }
        }

        public Post Get(int Id)
        {
            return db.Posts.FirstOrDefault(c => c.Id == Id);
        }
    }
}
