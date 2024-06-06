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

        public Task<Guid> Handle(CreateUserSignatureCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
