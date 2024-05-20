using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface ISignatureRepository
    {
        Task<List<Signature>> GetAllAsync();
        Task<Signature> GetByIdAsync(Guid id);
        Task AddAsync(Signature signature);
    }
}
