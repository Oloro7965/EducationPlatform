using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface IModuleRepository
    {
        Task<List<Modules>> GetAllAsync();
        Task<Modules> GetByIdAsync(Guid id);

        Task AddAsync(Modules module);
        Task SaveChangesAsync();
    }
}
