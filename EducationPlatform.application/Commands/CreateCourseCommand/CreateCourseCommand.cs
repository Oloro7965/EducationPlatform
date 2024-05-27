using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateCourseCommand
{
    public class CreateCourseCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }

        public Guid signatureId { get; set; }
    }
}
