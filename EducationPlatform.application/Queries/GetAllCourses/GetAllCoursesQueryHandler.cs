using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllCourses
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, List<CourseViewModel>>
    {
        private readonly ICourseRepository _courseRepository;

        public GetAllCoursesQueryHandler(ICourseRepository courseRepository)
        {

            _courseRepository = courseRepository;

        }

        public async Task<List<CourseViewModel>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {

            //var courses = _dbcontext.Courses;
            var courses = await _courseRepository.GetAllAsync();

            var CoursesViewModel = courses.Select(b => new CourseViewModel(b.Name,
                b.Description, b.Cover))
                .ToList();

            return CoursesViewModel;

        }
    }
}
