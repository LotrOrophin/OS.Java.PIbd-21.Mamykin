using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabSUBD.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public int Building { get; set; }
        public int PhoneNumber { get; set; }
        public string DepartamentName{ get; set; }
        public string Boss { get; set; } 
        [ForeignKey("DepartamentId")]
        public virtual List<EmployeeInformation> EmployeeInformations { get; set; }

    }
}
