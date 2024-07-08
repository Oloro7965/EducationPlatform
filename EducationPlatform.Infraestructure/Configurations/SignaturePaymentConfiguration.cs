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
    public class SignaturePaymentConfiguration : IEntityTypeConfiguration<SignaturePayment>
    {
        public void Configure(EntityTypeBuilder<SignaturePayment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Amount).HasPrecision(18, 2);
            builder.HasOne(x => x.userSignature).WithOne(x=>x.signaturePayment).HasForeignKey<SignaturePayment>(x=>x.UserSignatureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
