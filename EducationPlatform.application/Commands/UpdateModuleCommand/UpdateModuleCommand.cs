using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateModuleCommand
{
    public class UpdateModuleCommand:IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
