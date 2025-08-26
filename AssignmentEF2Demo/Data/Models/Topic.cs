using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    public class Topic
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name Must be less than 100 ")]
        public string Name { get; set; }

        #region One To Many[topic have many courses]
      
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        #endregion
    }
}
