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
    public class SignaturesConfiguration : IEntityTypeConfiguration<Signature>
    {
        public void Configure(EntityTypeBuilder<Signature> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.Courses).
                WithOne(x=>x.Signature).HasForeignKey(x=>x.SignatureId).
                OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
