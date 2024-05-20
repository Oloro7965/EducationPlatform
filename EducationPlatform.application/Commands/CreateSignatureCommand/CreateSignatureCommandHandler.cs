using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateSignatureCommand
{
    public class CreateSignatureCommandHandler : IRequestHandler<CreateSignatureCommand, Guid>
    {
        private readonly ISignatureRepository _signatureRepository;

        public CreateSignatureCommandHandler(ISignatureRepository signatureRepository)
        {
            
            _signatureRepository = signatureRepository;

        }

        public async Task<Guid> Handle(CreateSignatureCommand request, CancellationToken cancellationToken)
        {
            var signature = new Signature(request.Name, request.Duration);
           
            await _signatureRepository.AddAsync(signature);

            return signature.Id;
        }
    }
}
