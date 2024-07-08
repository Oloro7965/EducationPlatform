using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetSignaturePayment
{
    public class GetSignaturePaymentQueryHandler : IRequestHandler<GetSignaturePaymentQuery, SignaturePaymentViewModel>
    {
        private readonly ISignaturePaymentRepository _signaturePaymentRepository;

        public GetSignaturePaymentQueryHandler(ISignaturePaymentRepository signaturePaymentRepository)
        {
            _signaturePaymentRepository = signaturePaymentRepository;
        }

        public async Task<SignaturePaymentViewModel> Handle(GetSignaturePaymentQuery request, CancellationToken cancellationToken)
        {
            var signaturePayment = await _signaturePaymentRepository.GetByIdAsync(request.Id);

            var SignaturePaymentDetailViewModel = new SignaturePaymentViewModel(signaturePayment.PaymentStatus, signaturePayment.Amount, signaturePayment.PaymentLink,signaturePayment.DueDate);

            return SignaturePaymentDetailViewModel;
        }
    }
}
