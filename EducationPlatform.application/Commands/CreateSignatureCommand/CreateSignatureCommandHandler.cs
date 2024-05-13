using EducationPlatform.Core.Domain.Entities;
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
        private readonly EducationPlatformDbContext _dbcontext;

        public CreateSignatureCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> Handle(CreateSignatureCommand request, CancellationToken cancellationToken)
        {
            var signature = new Signature(request.Name, request.Duration);

            await _dbcontext.Signatures.AddAsync(signature);
            await _dbcontext.SaveChangesAsync();

            return signature.Id;
        }
    }
}
