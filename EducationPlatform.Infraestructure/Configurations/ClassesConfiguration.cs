﻿using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Configurations
{
    public class ClassesConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.finishedClasses).
                WithOne(x=>x.Lesson).
                HasForeignKey(x=>x.LessonId).
                OnDelete(DeleteBehavior.Restrict);

        }
    }
}
