using EducationPlatform.application.ViewModel;
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
        private readonly EducationPlatformDbContext _dbcontext;

        public GetAllSignaturesQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<SignatureViewModel>> Handle(GetAllSignaturesQuery request, CancellationToken cancellationToken)
        {

            var signatures = _dbcontext.Signatures;
            var signaturesViewModel = await signatures.Select(b => new SignatureViewModel(b.Name
                , b.Duration, b.Courses))
                .ToListAsync();
            return signaturesViewModel;
        }
    }
}
