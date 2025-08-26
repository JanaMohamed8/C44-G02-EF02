using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    public class Student
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

        #region One To Many [department have many students]
        [ForeignKey(nameof(Department))]
        public int Dep_Id { get; set; }
        public Department Department { get; set; } = null!;
        #endregion
        #region Many To Many [Students have Many Courses]
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();
        #endregion

    }
}
