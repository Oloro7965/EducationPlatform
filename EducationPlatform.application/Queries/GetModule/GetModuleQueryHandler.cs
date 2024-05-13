using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetModule
{
    public class GetModuleQueryHandler : IRequestHandler<GetModuleQuery, ModuleViewModel>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetModuleQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<ModuleViewModel> Handle(GetModuleQuery request, CancellationToken cancellationToken)
        {
            var module = _dbcontext.Modules.FirstOrDefault(m => m.Id == request.Id);
            var ModuleDetailViewModel = new ModuleViewModel(module.Name, module.Description, module.CreatedDate);
            return ModuleDetailViewModel;
        }
    }
}
