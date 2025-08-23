using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name Must be less than 100 ")]
    
        public string Name { get; set; }
        public int? Ins_ID { get; set; }
        [Required]
        
        public DateTime HiringDate { get; set; }
    }
}
