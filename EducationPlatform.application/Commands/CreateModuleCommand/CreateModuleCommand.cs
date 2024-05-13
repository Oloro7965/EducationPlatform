using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateModuleCommand
{
    public class CreateModuleCommand:IRequest<Guid>
    {

        public string Name { get; set; }

        public string Description { get; set; }

    }

}
