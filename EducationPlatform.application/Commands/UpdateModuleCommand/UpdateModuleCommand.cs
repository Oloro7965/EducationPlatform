using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateModuleCommand
{
    public class UpdateModuleCommand:IRequest<ResultViewModel>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
