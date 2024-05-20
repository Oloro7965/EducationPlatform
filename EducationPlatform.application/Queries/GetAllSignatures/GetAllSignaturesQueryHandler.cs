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

namespace EducationPlatform.application.Queries.GetAllSignatures
{
    public class GetAllSignaturesQueryHandler : IRequestHandler<GetAllSignaturesQuery, List<SignatureViewModel>>
    {
        //private readonly EducationPlatformDbContext _dbcontext;
        private readonly ISignatureRepository _signatureRepository;
        public GetAllSignaturesQueryHandler(ISignatureRepository signatureRepository)
        {

            //_dbcontext = dbcontext;
            _signatureRepository = signatureRepository;

        }

        public async Task<List<SignatureViewModel>> Handle(GetAllSignaturesQuery request, CancellationToken cancellationToken)
        {

            var signatures=await _signatureRepository.GetAllAsync();

            var signaturesViewModel =signatures.Select(b => new SignatureViewModel(b.Name
                , b.Duration, b.Courses))
                .ToList();

            return signaturesViewModel;

        }
    }
}
