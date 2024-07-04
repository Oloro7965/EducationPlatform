using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Configurations
{
    public class UserSignatureConfiguration : IEntityTypeConfiguration<UserSignature>
    {
        public void Configure(EntityTypeBuilder<UserSignature> builder)
        {

            builder.HasKey(x => x.Id);

        }

    }

}
