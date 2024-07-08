using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetUserSignature
{
    public class GetUserSignatureQueryHandler : IRequestHandler<GetUserSignatureQuery, UserSignatureViewModel>
    {
        private readonly IUserSignatureRepository _userSignatureRepository;

        public GetUserSignatureQueryHandler(IUserSignatureRepository userSignatureRepository)
        {
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<UserSignatureViewModel> Handle(GetUserSignatureQuery request, CancellationToken cancellationToken)
        {
            var userSignature = await _userSignatureRepository.GetByIdAsync(request.Id);

            var UserSignatureDetailViewModel = new UserSignatureViewModel(userSignature.SignatureStatus, userSignature.StartDate, userSignature.ExpiredDate);

            return UserSignatureDetailViewModel;
        }
    }
}
