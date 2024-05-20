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
        public Guid SignatureId { get; private set; }
        public Signature Signature { get; private set; }

        public List<Modules> Modules { get; private set; }

        public Course() { }

        public Course(string name, string description, string cover)
        {

            Name = name;

            Description = description;

            Cover = cover;

            CreatedDate = DateTime.Now;

        }
        public void Update(string description)
        {

            Description = description;

        }
    }
}
