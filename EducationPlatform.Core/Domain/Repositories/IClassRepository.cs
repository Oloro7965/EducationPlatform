using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Repositories
{
    public interface IClassRepository {

        Task<List<Class>> GetAllAsync();

        Task<Class> GetByIdAsync(Guid id);
        Task AddAsync(Class @class);
    }

}
