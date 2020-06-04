using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabSUBD.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public int Salary { get; set; }
        [ForeignKey("PostId")]
        public virtual List<EmployeeInformation> EmployeeInformations { get; set; }

    }
}
