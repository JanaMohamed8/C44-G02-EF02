using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name Must be less than 100 ")]
        public string Name { get; set; }
        [MaxLength(255, ErrorMessage = "Description Must be less than 255 ")]
        public string? Description { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]

        #region One To Many[topic have many courses]
        [ForeignKey(nameof(Topic))]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; } = null!;
        #endregion
        #region Many To Many [instructors have many courses]
        public ICollection<Course_Inst> Course_Inst { get; set; } = new HashSet<Course_Inst>();
        #endregion
        #region Many To Many [Students have Many Courses]
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();
        #endregion
    }
}
