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
    public class UserRepository : IUserRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;
        public UserRepository(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<List<User>> GetAllAsync()
        {

            return await _dbcontext.Users.Where(u => u.IsActive.Equals(true)).ToListAsync();

        }
        public async Task<User> GetByIdAsync(Guid id)
        {

            return await _dbcontext.Users.FirstOrDefaultAsync(u => u.Id == id);

        }

        public async Task AddAsync(User user)
        {

            await _dbcontext.Users.AddAsync(user);

            await _dbcontext.SaveChangesAsync();

        }
        public async Task SaveChangesAsync()
        {

            await _dbcontext.SaveChangesAsync();

        }
    }

}
