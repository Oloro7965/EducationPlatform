using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreatePaymentSignatureCommand
{
    public class CreateSignaturePaymentCommand : IRequest<Guid>
    {
        public string Message { get; set; }
        public Decimal Amount { get; set; }
        public Guid UserSignatureId { get; set; }
        public string PaymentLink { get; set; }
        public string IdExternalPayment { get; set; }
        public DateTime DueDate { get; set; }

    }
}