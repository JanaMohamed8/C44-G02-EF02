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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.HiringDate)
                .HasDefaultValueSql("GETDATE()");
            builder.HasIndex(d => d.Name)
              .IsUnique();

            #region One To One [instructor Manage Department]
            builder.HasOne(d => d.Manager)
               .WithOne(i => i.ManageDepartment)
               .HasForeignKey<Department>(d => d.ManagerId)
               .OnDelete(DeleteBehavior.NoAction);
             #endregion
    }
}
}
