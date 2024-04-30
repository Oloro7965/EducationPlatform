using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EducationPlatform.Core.Domain.Entities
{
    public class Class:BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get;private set; }
        public string VideoLink { get; private  set; }
        public int Duration { get; private set; }

        public Class() { }
        
    }
}
