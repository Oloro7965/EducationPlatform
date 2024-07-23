using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
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
    public class GetSignatureQueryHandler : IRequestHandler<GetSignatureQuery, ResultViewModel<SignatureViewModel>>
    {
        //private readonly EducationPlatformDbContext _dbcontext;
        private readonly ISignatureRepository _signatureRepository;

        public GetSignatureQueryHandler(ISignatureRepository signatureRepository)
        {

            _signatureRepository = signatureRepository;

        }

        public async Task<ResultViewModel<SignatureViewModel>> Handle(GetSignatureQuery request, CancellationToken cancellationToken)
        {

            var signature = await _signatureRepository.GetByIdAsync(request.Id);

            if (signature is null)
            {
                return ResultViewModel<SignatureViewModel>.Error("Esta assinatura não existe");
            }
            var SignatureDetailViewModel = new SignatureViewModel(signature.Name, signature.Duration, signature.Courses);

            return ResultViewModel<SignatureViewModel>.Success(SignatureDetailViewModel);

        }
    }
}
