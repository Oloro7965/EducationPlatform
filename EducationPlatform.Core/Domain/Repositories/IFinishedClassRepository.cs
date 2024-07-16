using EducationPlatform.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface IFinishedClassRepository
    {
        Task<List<UserFinishedClass>> GetAllAsync();
        Task<UserFinishedClass> GetByIdAsync(Guid id);
        Task AddAsync(UserFinishedClass finishedclass);
        Task SaveChangesAsync();
    }
}
