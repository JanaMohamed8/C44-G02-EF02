using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.Models
{
    [PrimaryKey(nameof(inst_ID), nameof(Course_ID))]
    public class Course_Inst
    {
        public int evaluate { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; } = null!;
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; } = null!;

    }
}
