using LabSUBD.Logic;
using LabSUBD.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LabSUBD
{
    class Program
    {
        public static readonly OfficeDataBase db = new OfficeDataBase();
        static void Main(string[] args)
        {
            MainLogic logic = new MainLogic();
            EmployeeInformationLogic eiLogic = new EmployeeInformationLogic();
            PostLogic postLogic = new PostLogic();
            SpecialtyLogic specialtyLogic = new SpecialtyLogic();
            DepartamentLogic departamentLogic = new DepartamentLogic();
            Insert(logic);
            Stopwatch clock = new Stopwatch();
            clock.Start();
            eiLogic.Read();
            logic.Req1();
            Console.WriteLine("\n");
            logic.Req2();
            clock.Stop();
            Console.WriteLine(clock.ElapsedMilliseconds);
        }
        public static void Insert(MainLogic logic)
        {
            /*logic.CreatePost("Бухгалтер", 7000); //5
            logic.CreatePost("Охранник", 5500); //6
            logic.CreatePost("Начальник отдела", 35000); //7
            logic.CreateSpecialty("Программный инжинер 2-ой категории");
            logic.CreateDepartament("Рекламный отдел", 3, 880055,"Хованский И.А.");//1
            logic.CreateDepartament("Отедл продаж", 2, 880056, "Попов И.А.");//2
            logic.CreateDepartament("Отдел Безопасности", 2, 880056, "Путин В.В.");//3
            logic.CreateSpecialty("Без специальности"); //2
            logic.CreateSpecialty("Инжинер"); //3
            logic.CreateSpecialty("Менеджер"); //4
            logic.CreateEI("Глазков В.И.", DateTime.Parse("1.02.2004"), "Ульяновск, Якурнова 242", "Армения", "Грузия", "Не женат", 0, 1700, 880033, 1, 5, 1);
            logic.CreateEI("Путин В.В.", DateTime.Parse("1.02.1990"), "Ульяновск, Якурнова 242", "Греция", "Герамания", "женат", 15, 170000, 15471134, 3, 7, 2);
            logic.CreateEI("Попов И.А.", DateTime.Parse("1.02.1994"), "Москва, Ульяновский 242", "Греция", "Германия", "женат", 15, 55000, 113514, 2, 7, 4);
            logic.CreateEI("Хованский И.А.", DateTime.Parse("1.02.1967"), "Ульяновск, Мирный 242", "Армения", "Грузия", "женат", 15, 1700, 1233134, 1, 7, 3);
            logic.CreateEI("Иванов И.И.", DateTime.Parse("1.02.1934"), "Москва, Отрадная 242", "Россия", "Россия", "женат", 15, 1700, 1233134, 3, 6, 2);*/
        }
    }
}

