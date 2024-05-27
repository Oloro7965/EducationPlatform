using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateCourseCommand
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepository _courseRepository;

        public CreateCourseCommandHandler(ICourseRepository courseRepository)
        {
            
            _courseRepository = courseRepository;

        }

        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {

            var course = new Course(request.Name, request.Description, request.Cover,request.signatureId);

            await _courseRepository.AddAsync(course);
            
            return course.Id;

        }
    }
}
