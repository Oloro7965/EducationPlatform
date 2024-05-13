using EducationPlatform.Core.Domain.Entities;
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
        private readonly EducationPlatformDbContext _dbcontext;

        public CreateCourseCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course(request.Name, request.Description, request.Cover);

            _dbcontext.Courses.AddAsync(course);
            _dbcontext.SaveChangesAsync();
            
            return course.Id;
        }
    }
}
