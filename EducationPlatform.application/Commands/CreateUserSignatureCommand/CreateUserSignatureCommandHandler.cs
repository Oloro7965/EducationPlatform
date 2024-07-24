using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateUserSignatureCommand
{
    public class CreateUserSignatureCommandHandler : IRequestHandler<CreateUserSignatureCommand, Guid>
    {
        private readonly IUserSignatureRepository _userSignatureRepository;

        public CreateUserSignatureCommandHandler(IUserSignatureRepository userSignatureRepository)
        {
            _userSignatureRepository = userSignatureRepository;
        }

        public async Task<Guid> Handle(CreateUserSignatureCommand request, CancellationToken cancellationToken)
        {

            var userSignature = new UserSignature(request.UserId,request.SignatureId,request.ExpiredDate);

            await _userSignatureRepository.AddAsync(userSignature);

            return userSignature.Id;

        }
    }
}
