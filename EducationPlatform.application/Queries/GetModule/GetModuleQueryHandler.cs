using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using EducationPlatform.Infraestructure.Persistance.Repositories;
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
        private readonly IModuleRepository _moduleRepository;

        public GetModuleQueryHandler(IModuleRepository moduleRepository)
        {

            _moduleRepository = moduleRepository;

        }

        public async Task<ModuleViewModel> Handle(GetModuleQuery request, CancellationToken cancellationToken)
        {
            var module = await _moduleRepository.GetByIdAsync(request.Id);
            

            var ModuleDetailViewModel = new ModuleViewModel(module.Name, module.Description, module.CreatedDate);

            return ModuleDetailViewModel;

        }
    }
}
