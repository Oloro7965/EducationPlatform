using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateSignatureCommand
{
    public class CreateSignatureCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}
