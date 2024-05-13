using EducationPlatform.application.ViewModel;
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
        private readonly EducationPlatformDbContext _dbcontext;

        public GetAllCoursesQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<CourseViewModel>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var courses = _dbcontext.Courses;
            var CoursesViewModel = await courses.Select(b => new CourseViewModel(b.Name,
                b.Description, b.Cover))
                .ToListAsync();
            return CoursesViewModel;
        }
    }
}
