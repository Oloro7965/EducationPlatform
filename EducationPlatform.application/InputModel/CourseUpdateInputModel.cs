using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.InputModel
{
    public class CourseUpdateInputModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
    }
}
