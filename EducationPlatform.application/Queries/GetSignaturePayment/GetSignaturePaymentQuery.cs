using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetSignaturePayment
{
    public class GetSignaturePaymentQuery:IRequest<ResultViewModel<SignaturePaymentViewModel>>
    {
        public GetSignaturePaymentQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get;private set; }
    }
}
