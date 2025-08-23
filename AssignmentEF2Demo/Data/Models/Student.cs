using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50 , ErrorMessage = "Frist name Must be less than 50 ")]
        public string FName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Last name Must be less than 50 ")]
        public string LName { get; set; }
        [MaxLength(150, ErrorMessage = "Address name Must be less than 50 ")]
        public string? Address { get; set; }
        [Required]
        [Range(18,60)] 
        public int Age { get; set; }
        [Required]
        public int Dep_Id { get; set; }

    }
}
