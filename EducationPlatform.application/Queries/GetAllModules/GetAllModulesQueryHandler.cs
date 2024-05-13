using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllModules
{
    public class GetAllModulesQueryHandler : IRequestHandler<GetAllModulesQuery, List<ModuleViewModel>>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetAllModulesQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<ModuleViewModel>> Handle(GetAllModulesQuery request, CancellationToken cancellationToken)
        {

            var modules = _dbcontext.Modules;
            var modulesViewModel = await modules.Select(b => new ModuleViewModel(b.Name
                , b.Description, b.CreatedDate))
                .ToListAsync();
            return modulesViewModel;
        }
    }
}
