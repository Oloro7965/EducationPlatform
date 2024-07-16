using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateFinishedClassCommand
{
    public class CreateFinishedClassCommand:IRequest<Guid>
    {
        public Guid UserId { get;  set; }
        public Guid ClassId { get;  set; }
        public DateTime FinishedDate { get;  set; }
        public int Grade { get; set; }
    }
}
