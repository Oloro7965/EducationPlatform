using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class FinishedClassViewModel
    {
        public FinishedClassViewModel(DateTime finishedDate, int grade)
        {
            FinishedDate = finishedDate;
            Grade = grade;
        }

        public DateTime FinishedDate { get;private set; }
        public int Grade { get; private set; }
    }
}
