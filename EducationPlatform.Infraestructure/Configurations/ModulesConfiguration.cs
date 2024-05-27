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
    public class ModulesConfiguration : IEntityTypeConfiguration<Modules>
    {
        public void Configure(EntityTypeBuilder<Modules> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.Classes).
                WithOne(x=>x.module).HasForeignKey(x=>x.ModuleId).
                OnDelete(DeleteBehavior.Restrict);
           
        }

    }

}
