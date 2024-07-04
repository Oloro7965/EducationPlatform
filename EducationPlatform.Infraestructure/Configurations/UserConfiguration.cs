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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Ignore(x => x.usersignatures);
            builder.HasMany(x=>x.usersignatures).
                WithOne(x=>x.user).HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }

}
