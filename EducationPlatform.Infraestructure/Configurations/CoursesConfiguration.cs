using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Configurations
{
    public class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.Modules).
                WithOne(x=> x.Course).HasForeignKey(x=>x.CourseId).
                OnDelete(DeleteBehavior.Restrict);
           
        }
    }
}
