using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateSignatureCommand
{
    public class UpdateUserSignatureCommandHandler : IRequestHandler<UpdateUserSignatureCommand, ResultViewModel>
    {
        private readonly IUserSignatureRepository _userSignatureRepository;

        public UpdateUserSignatureCommandHandler(IUserSignatureRepository userSignatureRepository)
        {
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<ResultViewModel> Handle(UpdateUserSignatureCommand request, CancellationToken cancellationToken)
        {
            var userSignature=await _userSignatureRepository.GetByIdAsync(request.Id);
            if (userSignature is null)
            {
                return ResultViewModel.Error("Esta Assinatura de usuário não existe");
            }
            userSignature.UpdateStatus(request.SignatureStatus);
            _userSignatureRepository.SaveChangesAsync();
            return ResultViewModel.Success();
        }
    }
}
