using EducationPlatform.application.InputModel;
using EducationPlatform.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Interfaces
{
    public interface ICourseService
    {
        //List<CourseViewModel> Get();
        //CourseViewModel GetById(Guid id);
        void Update(CourseUpdateInputModel model);
        //Guid Create(NewCourseInputModel Model);
    }
}
