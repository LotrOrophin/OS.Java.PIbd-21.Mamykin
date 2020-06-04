
using LabSUBD.Models;
using LabSUBD.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSUBD.Logic
{
    public class MainLogic
    {
        private readonly DepartamentLogic departamentLogic;
        private readonly PostLogic postLogic;
        private readonly EmployeeInformationLogic employeeInformationLogic;
        private readonly SpecialtyLogic specialtyLogic;
        public MainLogic(DepartamentLogic departamentLogic, PostLogic postLogic, EmployeeInformationLogic employeeInformationLogic, SpecialtyLogic specialtyLogic)
        {
            this.specialtyLogic = specialtyLogic;
            this.employeeInformationLogic = employeeInformationLogic;
            this.postLogic = postLogic;
            this.departamentLogic = departamentLogic;
        }


        public void CreateDepartament(string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            Departament departament = new Departament()
            {
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss,
            };
            departamentLogic.Create(departament);
        }


        public void CreatePost(string PostName, int Salary)
        {
            Post post = new Post()
            {
                PostName = PostName,
                Salary = Salary
            };
            postLogic.Create(post);
        }

        public void CreateEI(string FIO, DateTime date, string Registration, string birthPlace,string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber, int departamentId, int postId, int specialtyId)
        {
            EmployeeInformation ei = new EmployeeInformation()
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
            employeeInformationLogic.Create(ei);
        }

        public void CreateSpecialty(string specialtyName)
        {
            Specialty specialty = new Specialty()
            {
                SpecialtyName = specialtyName,
            };
            specialtyLogic.Create(specialty);
        }

        public void DeleteDepartament(int id, string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            Departament departament = new Departament()
            {
                Id=id,
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss
            };
            departamentLogic.Delete(departament);
        }

        public void UpdateDepartament(int Id, string DepartamentName, int Building, int PhoneNumber, string Boss)
        {
            var list = departamentLogic.Get(Id);
            Departament departament = new Departament()
            {
                Id = list.Id,
                DepartamentName = DepartamentName,
                Building = Building,
                PhoneNumber = PhoneNumber,
                Boss = Boss
            };
            departamentLogic.Update(departament);
        }


        public void DeletePost(int Id, string PostName, int Salary)
        {
            Post post = new Post()
            {
                Id = Id,
                PostName = PostName,
                Salary = Salary
            };
            postLogic.Delete(post);
        }

        public void UpdatePost(int Id, string PostName, int Salary)
        {
            Post post = new Post()
            {
                Id = Id,
                PostName = PostName,
                Salary = Salary
            };
            postLogic.Update(post);
        }

        public void DeleteEI(int Id, string FIO, DateTime date, string Registration, string birthPlace, string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber)
        {
            EmployeeInformation ei = new EmployeeInformation()
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
            employeeInformationLogic.Delete(ei);
        }

        public void UpdateEI(int Id, string FIO, DateTime date, string Registration, string birthPlace, string citizenship, string maritalStatus, int professionalExpirience, int premiumBonus, int phoneNumber)
        {
            EmployeeInformation ei = new EmployeeInformation()
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
            employeeInformationLogic.Update(ei);
        }

        public void DeleteSpecialty(int Id, string specialtyName)
        {
            Specialty specialty= new Specialty()
            {
                Id = Id,
                SpecialtyName = specialtyName,
            };
            specialtyLogic.Create(specialty);
        }

        public void UpdateSpecialty(int Id, string specialtyName)
        {
            Specialty specialty = new Specialty()
            {
                Id = Id,
                SpecialtyName = specialtyName,
            };
            specialtyLogic.Create(specialty);
        }
        public void ReadEI()
        {
            var list = employeeInformationLogic.Read();
            foreach (var p in list)
            {
                Console.WriteLine(p.Id + " " + p.FIO + " " + p.Date + " " + p.ProfessionalExpirience + " " + p.PhoneNumber + " " + p.MaritalStatus);
            }
        }

        public void ReadPost()
        {
            foreach (var p in postLogic.Read())
            {
                Console.WriteLine(p.PostName + ".  Зарплата:  "+p.Salary);
            }
        }

        public void ReadDepartament()
        {
            foreach (var p in departamentLogic.Read())
            {
                Console.WriteLine(p.DepartamentName + ". Босс: " + p.Boss);
            }
        }

        public void ReadSpecialty()
        {
            foreach (var p in specialtyLogic.Read())
            {
                Console.WriteLine("Специальность:  " + p.SpecialtyName);
            }
        }
       public void Post()
        {
            postLogic.Req1();
            Console.WriteLine("\n");
            postLogic.Req2();
        }

    }
}
