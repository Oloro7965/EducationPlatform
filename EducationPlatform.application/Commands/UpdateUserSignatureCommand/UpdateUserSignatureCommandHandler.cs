using EducationPlatform.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateSignatureCommand
{
    public class UpdateUserSignatureCommandHandler : IRequestHandler<UpdateUserSignatureCommand, Unit>
    {
        private readonly IUserSignatureRepository _userSignatureRepository;

        public UpdateUserSignatureCommandHandler(IUserSignatureRepository userSignatureRepository)
        {
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<Unit> Handle(UpdateUserSignatureCommand request, CancellationToken cancellationToken)
        {
            var userSignature=await _userSignatureRepository.GetByIdAsync(request.Id);
            userSignature.UpdateStatus(request.SignatureStatus);
            _userSignatureRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
