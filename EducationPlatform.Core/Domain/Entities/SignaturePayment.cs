using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class SignaturePayment:BaseEntity
    {
        public SignaturePayment(string message, decimal amount, Guid userSignatureId,string paymentLink, string idExternalPayment, DateTime dueDate)
        {
            ProcessingDate = DateTime.Now;
            PaymentStatus=EPaymentStatus.Pending;
            Message = message;
            Amount = amount;
            UserSignatureId = userSignatureId;
            PaymentLink = paymentLink;
            IdExternalPayment = idExternalPayment;
            DueDate = dueDate;
        }

        public DateTime ProcessingDate { get; private set; }
        public EPaymentStatus PaymentStatus { get; private set; }
        public string Message { get;private set; }
        public Decimal Amount { get; private set; }
        public Guid UserSignatureId { get; private set; }
        public UserSignature userSignature { get; private set; }
        public string PaymentLink { get; private set; }
        public string IdExternalPayment { get; private set; }
        public DateTime DueDate { get; private set; }
        public void UpdatePaymentStatus(EPaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
        }
    }
}
