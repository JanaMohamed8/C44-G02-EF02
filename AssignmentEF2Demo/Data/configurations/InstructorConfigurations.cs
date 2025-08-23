using AssignmentEF2Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF2Demo.Data.configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasCheckConstraint("SalaryIsNot0OrLess", "Salary > 0");
            builder.HasCheckConstraint("HourRateBounsIs0OrMore", "HourRateBouns >= 0");
            builder.Property(I => I.HourRateBouns).HasDefaultValue(0);
        }
    }
}
