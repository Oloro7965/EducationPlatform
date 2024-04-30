using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.InputModel
{
    public class NewSignatureInputModel
    {
        public NewSignatureInputModel(string name, int duration, List<Course> courses)
        {
            Name = name;
            Duration = duration;
            Courses = courses;
        }
        public string Name { get;set; }
        public int Duration { get;  set; }
        public List<Course> Courses { get; set; }
    }
}
