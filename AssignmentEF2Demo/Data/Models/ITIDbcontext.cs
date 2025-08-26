using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssignmentEF2Demo.Data.Models
{
    internal class ITIDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIFromVS;Trusted_Connection=True;trustservercertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        DbSet<Student> Students { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Instructor> Instructors { get; set; } 
        DbSet<Topic> Topics { get; set; }
        DbSet<Course_Inst> course_Inst { get; set; }
    }
}
