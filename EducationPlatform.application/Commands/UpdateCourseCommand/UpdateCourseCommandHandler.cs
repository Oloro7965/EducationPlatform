using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateCourseCommand
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public UpdateCourseCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _dbcontext.Courses.FirstOrDefault(m => m.Id == request.Id);

            course.Update(request.Description);
            _dbcontext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
