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
    public class ModuleRepository : IModuleRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;
        public ModuleRepository(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<List<Modules>> GetAllAsync()
        {
           
           return await _dbcontext.Modules.ToListAsync();

        }

        public async Task<Modules> GetByIdAsync(Guid id)
        {

            return await _dbcontext.Modules.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task AddAsync(Modules module)
        {

            await _dbcontext.Modules.AddAsync(module);
            
            await _dbcontext.SaveChangesAsync();

        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }

}
