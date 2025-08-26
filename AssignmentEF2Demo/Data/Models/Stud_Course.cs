using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    [PrimaryKey(nameof(CId), nameof(SId))]
    public class Stud_Course
    {
        [ForeignKey(nameof(Course))]
        public int CId { get; set; }
        public Course Course { get; set; } = null!;
        [ForeignKey(nameof(Student))]
        public int SId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
