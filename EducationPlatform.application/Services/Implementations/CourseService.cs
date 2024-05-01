using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public CourseService(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Guid Create(NewCourseInputModel Model)
        {
            var course = new Course(Model.Name, Model.Description, Model.Cover);
            _dbcontext.Courses.Add(course);
            _dbcontext.SaveChanges();
            return course.Id;
        }

        public List<CourseViewModel> Get()
        {
            var courses = _dbcontext.Courses;
            var CoursesViewModel = courses.Select(b => new CourseViewModel(b.Name,
                b.Description, b.Cover))
                .ToList();
            return CoursesViewModel;
        }

        public CourseViewModel GetById(Guid id)
        {
            var course = _dbcontext.Courses.FirstOrDefault(m => m.Id == id);
            var CourseDetailViewModel = new CourseViewModel(course.Name, course.Description, course.Cover);
            return CourseDetailViewModel;
        }

        public void Update(CourseUpdateInputModel model)
        {
            var course = _dbcontext.Courses.FirstOrDefault(m => m.Id == model.Id);
            course.Update(model.Description);
            _dbcontext.SaveChanges();
        }
    }
}
