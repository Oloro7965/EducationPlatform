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
    public class CourseRepository : ICourseRepository
    {
        private readonly EducationPlatformDbContext _dbcontext;
        public CourseRepository(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<List<Course>> GetAllAsync()
        {

            return await _dbcontext.Courses.ToListAsync();

        }

        public async Task<Course> GetByIdAsync(Guid id)
        {

            return await _dbcontext.Courses.FirstOrDefaultAsync(m => m.Id == id);

        }
        public async Task AddAsync(Course course)
        {

            _dbcontext.Courses.AddAsync(course);

            _dbcontext.SaveChangesAsync();

        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }

}
