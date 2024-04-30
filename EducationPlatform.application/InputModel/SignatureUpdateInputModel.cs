using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.InputModel
{
    public class SignatureUpdateInputModel
    {
        public SignatureUpdateInputModel(string nome, int duration, List<Course> courses)
        {
            Nome = nome;
            Duration = duration;
            Courses = courses;
        }
        public string Nome { get; private set; }
        public int Duration { get; private set; }
        public List<Course> Courses { get; private set; }
    }
}
