using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Enums;
using EducationPlatform.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Persistance.Repositories
{
    public class UserSignatureRepository : IUserSignatureRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public UserSignatureRepository(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(UserSignature signature)
        {
            await _dbcontext.UserSignatures.AddAsync(signature);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<UserSignature>> GetAllAsync()
        {
            return await _dbcontext.UserSignatures.Where(u => u.SignatureStatus==ESignatureStatus.Active).ToListAsync();
        }

        public async Task<UserSignature> GetByIdAsync(Guid id)
        {
            return await _dbcontext.UserSignatures.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
