using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class Course:BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get;private set; }
        public string Cover { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Course() { }
        public Course(int id) { }
    }
}
