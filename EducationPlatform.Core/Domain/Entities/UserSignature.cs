using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class UserSignature:BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid SignatureId { get; private set; }
        public ESignatureStatus SignatureStatus { get;private set; }
        public DateTime StartDate { get; private set; }
        public DateTime ExpiredDate { get; private set; }
        public UserSignature() { }

    }
}
