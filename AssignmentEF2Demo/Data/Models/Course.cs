using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    internal class Course
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
        public int Top_ID { get; set; }
    }
}
