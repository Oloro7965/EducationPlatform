using EducationPlatform.Core.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateSignatureCommand
{
    public class UpdateUserSignatureCommand:IRequest<Unit>
    {
        public Guid Id { get; set; }

        public ESignatureStatus SignatureStatus { get;  set; }
    }
}
