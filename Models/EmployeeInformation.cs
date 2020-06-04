using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabSUBD.Models
{
    public class EmployeeInformation
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string FIO { get; set; }
        public DateTime Date { get; set; }
        public string Registration { get; set; }
        public string BirthPlace { get; set; }
        public string Citizenship { get; set; }
        public string MaritalStatus { get; set; }
        public int ProfessionalExpirience { get; set; }
        public int PremiumBonus { get; set; }
        [Required]
        public int DepartamentId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public int SpecialtyId { get; set; }
        public virtual Departament Departament{get;set;}
        public virtual Post Post { get; set; }
        public virtual Specialty Specialty { get; set; }
    }
}
