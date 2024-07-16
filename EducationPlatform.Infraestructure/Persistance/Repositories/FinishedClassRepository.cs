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
    public class FinishedClassRepository : IFinishedClassRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public FinishedClassRepository(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(UserFinishedClass finishedclass)
        {
            await _dbcontext.userFinishedClasses.AddAsync(finishedclass);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<UserFinishedClass>> GetAllAsync()
        {
            return await _dbcontext.userFinishedClasses.ToListAsync();
        }

        public async Task<UserFinishedClass> GetByIdAsync(Guid id)
        {
            return await _dbcontext.userFinishedClasses.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
