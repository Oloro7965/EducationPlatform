using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllClasses
{
    public class GetAllClassesQueryHandler : IRequestHandler<GetAllClassesQuery, List<ClassViewModel>>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetAllClassesQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<ClassViewModel>> Handle(GetAllClassesQuery request, CancellationToken cancellationToken)
        {
            var classes = _dbcontext.Classes;
            var ClassesViewModel = await classes.Select(b => new ClassViewModel(b.Name,
                b.Description, b.VideoLink, b.Duration))
                .ToListAsync();
            return ClassesViewModel;
        }
    }
}
