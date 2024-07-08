using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface ISignaturePaymentRepository
    {
        Task<List<SignaturePayment>> GetAllAsync();
        Task<SignaturePayment> GetByIdAsync(Guid id);
        Task AddAsync(SignaturePayment payment);
        Task SaveChangesAsync();
    }
}
