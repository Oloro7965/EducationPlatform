using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateCourseCommand
{
    public class UpdateCourseCommand:IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
    }
}
