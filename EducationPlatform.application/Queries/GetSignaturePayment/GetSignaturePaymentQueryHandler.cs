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
    public class GetSignaturePaymentQueryHandler : IRequestHandler<GetSignaturePaymentQuery, ResultViewModel<SignaturePaymentViewModel>>
    {
        private readonly ISignaturePaymentRepository _signaturePaymentRepository;

        public GetSignaturePaymentQueryHandler(ISignaturePaymentRepository signaturePaymentRepository)
        {
            _signaturePaymentRepository = signaturePaymentRepository;
        }

        public async Task<ResultViewModel<SignaturePaymentViewModel>> Handle(GetSignaturePaymentQuery request, CancellationToken cancellationToken)
        {
            var signaturePayment = await _signaturePaymentRepository.GetByIdAsync(request.Id);

            if(signaturePayment is null)
            {
                return ResultViewModel<SignaturePaymentViewModel>.Error("Este Pagamento não existe");
            }
            var SignaturePaymentDetailViewModel = new SignaturePaymentViewModel(signaturePayment.PaymentStatus, signaturePayment.Amount, signaturePayment.PaymentLink,signaturePayment.DueDate);

            return ResultViewModel<SignaturePaymentViewModel>.Success(SignaturePaymentDetailViewModel);
        }
    }
}
