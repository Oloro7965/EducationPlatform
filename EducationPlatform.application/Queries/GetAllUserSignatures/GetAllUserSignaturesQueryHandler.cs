using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllUserSignatures
{
    public class GetAllUserSignaturesQueryHandler : IRequestHandler<GetAllUserSignaturesQuery, List<UserSignatureViewModel>>
    {
        private readonly IUserSignatureRepository _userSignatureRepository;

        public GetAllUserSignaturesQueryHandler(IUserSignatureRepository userSignatureRepository)
        {
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<List<UserSignatureViewModel>> Handle(GetAllUserSignaturesQuery request, CancellationToken cancellationToken)
        {
            var userSignatures = await _userSignatureRepository.GetAllAsync();
            
            var userSignatureViewModel = userSignatures.Select(b => new UserSignatureViewModel(b.SignatureStatus
                 , b.StartDate, b.ExpiredDate))
                 .ToList();

            return userSignatureViewModel;
        }
    }
}
