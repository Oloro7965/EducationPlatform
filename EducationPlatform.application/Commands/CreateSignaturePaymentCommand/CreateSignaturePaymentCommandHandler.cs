using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Enums;
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
    public class CreateSignaturePaymentCommandHandler : IRequestHandler<CreateSignaturePaymentCommand, ResultViewModel<Guid>>
    {
        private readonly ISignaturePaymentRepository _signaturePaymentRepository;
        private readonly IUserSignatureRepository _userSignatureRepository;

        public CreateSignaturePaymentCommandHandler(ISignaturePaymentRepository signaturePaymentRepository, IUserSignatureRepository userSignatureRepository)
        {
            _signaturePaymentRepository = signaturePaymentRepository;
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<ResultViewModel<Guid>> Handle(CreateSignaturePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new SignaturePayment(request.Message,request.Amount,request.UserSignatureId
                ,request.PaymentLink,request.IdExternalPayment,request.DueDate);
            var usersignature=await _userSignatureRepository.GetByIdAsync(request.UserSignatureId);
            if (usersignature is null)
            {
                return ResultViewModel<Guid>.Error("Essa assinatura de usuário não existe");
            }

            await _signaturePaymentRepository.AddAsync(payment);

            return ResultViewModel<Guid>.Success(payment.Id);
            //return payment.Id;
        }
    }
}
