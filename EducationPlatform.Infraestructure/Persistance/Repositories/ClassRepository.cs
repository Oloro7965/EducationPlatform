using Azure.Core;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infraestructure.Persistance.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public ClassRepository(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<List<Class>> GetAllAsync()
        {

            return await _dbcontext.Classes.ToListAsync();

        }

        public async Task<Class> GetByIdAsync(Guid id)
        {

            return await _dbcontext.Classes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task AddAsync(Class @class)
        {

            await _dbcontext.Classes.AddAsync(@class);

            await _dbcontext.SaveChangesAsync();

        }
    }

}
