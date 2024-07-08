using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class UserSignatureViewModel
    {
        public UserSignatureViewModel(ESignatureStatus signatureStatus, DateTime startDate, DateTime expiredDate)
        {
            SignatureStatus = signatureStatus;
            StartDate = startDate;
            ExpiredDate = expiredDate;
        }

        public ESignatureStatus SignatureStatus { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime ExpiredDate { get; private set; }
    }
}
