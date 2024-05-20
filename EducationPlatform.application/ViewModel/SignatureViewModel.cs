using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class SignatureViewModel
    {
        public SignatureViewModel(string name, int duration, List<Course> courses)
        {

            Name = name;

            Duration = duration;

            Courses = courses;

        }
        public string Name { get; private set; }
        public int Duration { get; private set; }
        public List<Course> Courses { get; private set; }
    }
}
