using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class ModuleViewModel
    {
        public ModuleViewModel(string name, string description, DateTime createdDate)
        {
            Name = name;
            Description = description;
            CreatedDate = createdDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedDate { get; private set; }
    }
}
