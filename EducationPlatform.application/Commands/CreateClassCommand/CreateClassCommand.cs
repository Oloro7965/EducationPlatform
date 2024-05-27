using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateClassCommand
{
    public class CreateClassCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }
        public int Duration { get; set; }

        public Guid moduleId { get; set; }
    }
}
