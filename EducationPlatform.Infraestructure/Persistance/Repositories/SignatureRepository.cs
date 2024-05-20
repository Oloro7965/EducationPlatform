using Azure.Core;
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
    public class SignatureRepository : ISignatureRepository
    {

        private readonly EducationPlatformDbContext _dbcontext;

        public SignatureRepository(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<List<Signature>> GetAllAsync()
        {

            return await _dbcontext.Signatures.ToListAsync();

        }

        public async Task<Signature> GetByIdAsync(Guid id)
        {

            return await _dbcontext.Signatures.FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task AddAsync(Signature signature)
        {

            await _dbcontext.Signatures.AddAsync(signature);

            await _dbcontext.SaveChangesAsync();

        }

    }

}
