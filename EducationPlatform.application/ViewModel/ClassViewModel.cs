using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class ClassViewModel
    {
        public ClassViewModel(string name, string description, string videoLink, int duration)
        {
            Name = name;
            Description = description;
            VideoLink = videoLink;
            Duration = duration;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string VideoLink { get; private set; }
        public int Duration { get; private set; }
    }
}
