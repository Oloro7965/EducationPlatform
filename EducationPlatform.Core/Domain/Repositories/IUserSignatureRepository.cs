using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface IUserSignatureRepository
    {
        Task<List<UserSignature>> GetAllAsync();
        Task<UserSignature> GetByIdAsync(Guid id);
        Task AddAsync(UserSignature signature);
        Task SaveChangesAsync();
    }
}
