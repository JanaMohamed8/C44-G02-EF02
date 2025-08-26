using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name Must be less than 100 ")]
    
        public string Name { get; set; }
        public int? Ins_ID { get; set; }
        [Required]
        
        public DateTime HiringDate { get; set; }

        #region One To Many [department have many students]
     
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #endregion
        #region One To Many [department have many instructor]

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion
        #region One To One [instructor Manage Department]
     
        public int ManagerId { get; set; }
        public Instructor Manager { get; set; } = null!;
        #endregion
    }
}
