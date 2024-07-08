using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class UserSignature : BaseEntity
    {
        public UserSignature(Guid userId, Guid signatureId, ESignatureStatus signatureStatus, DateTime expiredDate)
        {

            UserId = userId;

            SignatureId = signatureId;

            SignatureStatus = signatureStatus;

            StartDate = DateTime.Now;

            ExpiredDate = expiredDate;

        }
        public Guid UserId { get; private set; }

        public Guid SignatureId { get; private set; }
        public User user { get; private set; }
        public Signature signature { get; private set; }
        public SignaturePayment signaturePayment { get; private set; }

        public ESignatureStatus SignatureStatus { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime ExpiredDate { get; private set; }
        public void UpdateStatus(ESignatureStatus updateStatus) {
            SignatureStatus = updateStatus;
        }

    }

}
