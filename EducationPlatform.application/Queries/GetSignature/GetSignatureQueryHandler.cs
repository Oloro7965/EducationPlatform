using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetSignature
{
    public class GetSignatureQueryHandler : IRequestHandler<GetSignatureQuery, SignatureViewModel>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetSignatureQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<SignatureViewModel> Handle(GetSignatureQuery request, CancellationToken cancellationToken)
        {
            var signature = _dbcontext.Signatures.FirstOrDefault(b => b.Id == request.Id);
            var SignatureDetailViewModel = new SignatureViewModel(signature.Name, signature.Duration, signature.Courses);
            return SignatureDetailViewModel;
        }
    }
}
