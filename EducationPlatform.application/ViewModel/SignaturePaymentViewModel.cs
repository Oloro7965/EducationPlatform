using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class SignaturePaymentViewModel
    {
        public SignaturePaymentViewModel(EPaymentStatus paymentStatus, decimal amount, string paymentLink, DateTime dueDate)
        {
            PaymentStatus = paymentStatus;
            Amount = amount;
            PaymentLink = paymentLink;
            DueDate = dueDate;
        }

        public EPaymentStatus PaymentStatus { get; private set; }
        public Decimal Amount { get; private set; }
        public string PaymentLink { get; private set; }
        public DateTime DueDate { get; private set; }
        //public string IdExternalPayment { get; private set; }
    }
}
