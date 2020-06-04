using LabSUBD.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LabSUBD
{
    public class OfficeDataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2VLTMI2\SQLEXPRESS;Initial Catalog=OfficeDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Departament> Departaments { set; get; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations  { set; get; }
        public virtual DbSet<Post> Posts  { set; get; }
        public virtual DbSet<Specialty> Specialties  { set; get; }
    }
}
