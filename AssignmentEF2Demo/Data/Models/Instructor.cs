using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name Must be less than 100 ")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        [MaxLength(150, ErrorMessage = "Address Must be less than 150 ")]
        public string? Address { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal HourRateBouns { get; set; }
        [Required]
        public int Dept_ID { get;set; }

        #region Many To Many [instructors have many courses]
        public ICollection<Course_Inst> Course_Inst { get; set; } = new HashSet<Course_Inst>();
        #endregion
        #region One To Many [department have many instructor]
        public int Dep_Id { get; set; }
        public Department Department { get; set; } = null!;
        #endregion
        #region One To One [instructor Manage Department]
      
        public Department? ManageDepartment { get; set; } 
        #endregion
    }
}
