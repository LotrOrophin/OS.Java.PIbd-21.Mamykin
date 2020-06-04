using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabSUBD.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        public string SpecialtyName { get; set; }
        [ForeignKey("SpecialtyId")]
        public virtual List<EmployeeInformation> EmployeeInformations { get; set; }

    }
}
