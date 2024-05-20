using EducationPlatform.Core.Domain.Repositories;
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
        private readonly ICourseRepository _courseRepository;

        public UpdateCourseCommandHandler(ICourseRepository courseRepository)
        {

            _courseRepository = courseRepository;
        }

        public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            //var course = _dbcontext.Courses.FirstOrDefault(m => m.Id == request.Id);
            var course = await _courseRepository.GetByIdAsync(request.Id);

            course.Update(request.Description);

            _courseRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
