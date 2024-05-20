using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class CourseViewModel
    {
        public CourseViewModel(string name, string description, string cover)
        {

            Name = name;

            Description = description;

            Cover = cover;

        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Cover { get; private set; }
    }
}
