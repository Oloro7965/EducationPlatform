using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Enums;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetSignaturePayments
{
    public class GetSignaturePaymentsQueryHandler : IRequestHandler<GetSignaturePaymentsQuery, List<SignaturePaymentViewModel>>
    {
        private readonly ISignaturePaymentRepository _signaturePaymentRepository;

        public GetSignaturePaymentsQueryHandler(ISignaturePaymentRepository signaturePaymentRepository)
        {
            _signaturePaymentRepository = signaturePaymentRepository;
        }

        public async Task<List<SignaturePaymentViewModel>> Handle(GetSignaturePaymentsQuery request, CancellationToken cancellationToken)
        {
            var SignaturePayments = await _signaturePaymentRepository.GetAllAsync();

            var SignaturesPaymentyViewModel = SignaturePayments.Select(b => new SignaturePaymentViewModel(b.PaymentStatus,b.Amount,b.PaymentLink,b.DueDate))
            .ToList();

            return SignaturesPaymentyViewModel;
        }
    }
}
