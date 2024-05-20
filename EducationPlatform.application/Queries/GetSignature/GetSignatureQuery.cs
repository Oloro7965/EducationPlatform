using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetSignature
{
    public class GetSignatureQuery:IRequest<SignatureViewModel>
    {
        public GetSignatureQuery(Guid id)
        {

            Id = id;

        }

        public Guid Id { get; private set; }

    }
}
