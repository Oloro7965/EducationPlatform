using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Configurations
{
    public class FinishedClassConfiguration : IEntityTypeConfiguration<UserFinishedClass>
    {

        public void Configure(EntityTypeBuilder<UserFinishedClass> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
