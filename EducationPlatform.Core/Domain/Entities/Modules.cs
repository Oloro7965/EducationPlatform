using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class Modules:BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedDate { get; private set;}
        public Guid CourseId { get; private set; }
        public Course Course { get; private set; }
        public List<Class> Classes { get; private set; }
        public Modules() { }
        public Modules(string name, string description,Guid courseId)
        {

            Name = name;

            Description = description;

            CreatedDate = DateTime.Now;

            CourseId = courseId;

        }
        public void Update(string description)
        {

            Description = description;

        }
    }
}
