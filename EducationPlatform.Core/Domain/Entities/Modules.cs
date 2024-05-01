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
        public Modules() { }
        public Modules(string name, string description)
        {
            Name = name;
            Description = description;
            CreatedDate = DateTime.Now;
        }
        public void Update(string description)
        {
            Description = description;
        }
    }
}
