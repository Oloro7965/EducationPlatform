using EducationPlatform.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace EducationPlatform.Infraestructure.Persistance
{
    public class EducationPlatformDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Course> Courses { get; set; }
        public EducationPlatformDbContext()
        {
        }
        public EducationPlatformDbContext(DbContextOptions<EducationPlatformDbContext> options) : base(options)
        {
        }
    }
}