using EducationPlatform.Core.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateUserSignatureCommand
{
    public class CreateUserSignatureCommand:IRequest<Guid>
    {
        public Guid UserId { get;  set; }
        public Guid SignatureId { get; set; }

        //public ESignatureStatus SignatureStatus { get; set; }
        public DateTime ExpiredDate { get; set; }

    }
}
