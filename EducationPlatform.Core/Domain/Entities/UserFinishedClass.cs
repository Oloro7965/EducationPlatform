using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class UserFinishedClass:BaseEntity
    {
        public UserFinishedClass(Guid userId, Guid lessonId, DateTime finishedDate, int grade)
        {
            UserId = userId;
            LessonId = lessonId;
            FinishedDate = finishedDate;
            Grade = grade;
        }

        public Guid UserId { get; private set; }
        public User user { get; private set; }
        public Guid LessonId { get; private set; }
        public Class Lesson { get; private set; }
        public DateTime FinishedDate { get; private set; }
        public int Grade { get; private set; }
    }
}
