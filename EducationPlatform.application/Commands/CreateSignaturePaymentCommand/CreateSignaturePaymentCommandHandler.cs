using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreatePaymentSignatureCommand
{
    public class CreateSignaturePaymentCommandHandler : IRequestHandler<CreateSignaturePaymentCommand, Guid>
    {
        private readonly ISignaturePaymentRepository _signaturePaymentRepository;

        public CreateSignaturePaymentCommandHandler(ISignaturePaymentRepository signaturePaymentRepository)
        {
            _signaturePaymentRepository = signaturePaymentRepository;
        }

        public async Task<Guid> Handle(CreateSignaturePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new SignaturePayment(request.Message,request.Amount,request.UserSignatureId,request.PaymentLink,request.IdExternalPayment,request.DueDate);

            await _signaturePaymentRepository.AddAsync(payment);

            return payment.Id;
        }
    }
}
