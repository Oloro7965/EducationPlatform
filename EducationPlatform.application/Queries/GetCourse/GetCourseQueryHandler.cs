using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetCourse
{
    public class GetCourseQueryHandler : IRequestHandler<GetCourseQuery, CourseViewModel>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseQueryHandler(ICourseRepository courseRepository)
        {

            _courseRepository = courseRepository;

        }

        public async Task<CourseViewModel> Handle(GetCourseQuery request, CancellationToken cancellationToken)
        {
            //var course = _dbcontext.Courses.FirstOrDefault(m => m.Id == request.Id);
            var course = await _courseRepository.GetByIdAsync(request.Id);

            var CourseDetailViewModel = new CourseViewModel(course.Name, course.Description, course.Cover);

            return CourseDetailViewModel;

        }
    }
}
