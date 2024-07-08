using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Persistance.Repositories
{
    public class SignaturePaymentRepository : ISignaturePaymentRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public SignaturePaymentRepository(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(SignaturePayment payment)
        {
            await _dbcontext.SignaturePayments.AddAsync(payment);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<SignaturePayment>> GetAllAsync()
        {
            return await _dbcontext.SignaturePayments.ToListAsync();
        }

        public async Task<SignaturePayment> GetByIdAsync(Guid id)
        {
            return await _dbcontext.SignaturePayments.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
