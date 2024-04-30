using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.InputModel
{
    public class ModuleUpdateInputModel
    {
        public ModuleUpdateInputModel(Guid id, string description)
        {
            Id = id;
            Description = description;
        }
        public Guid Id { get; set; }
        public string Description { get; set; }

    }
}
