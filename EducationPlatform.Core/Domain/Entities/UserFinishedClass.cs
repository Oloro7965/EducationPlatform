using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class UserFinishedClass:BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid ClassId { get; private set; }
        public DateTime FinishedDate { get; private set; }
        public int Grade { get; private set; }
        public UserFinishedClass() { }
    }
}
