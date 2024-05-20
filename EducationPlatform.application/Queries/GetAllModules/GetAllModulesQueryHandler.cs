using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
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
        private readonly IModuleRepository _moduleRepository;

        public GetAllModulesQueryHandler(IModuleRepository moduleRepository)
        {

            _moduleRepository = moduleRepository;

        }

        public async Task<List<ModuleViewModel>> Handle(GetAllModulesQuery request, CancellationToken cancellationToken)
        {

            var modules = await _moduleRepository.GetAllAsync();

            var modulesViewModel =modules.Select(b => new ModuleViewModel(b.Name
                , b.Description, b.CreatedDate))
                .ToList();

            return modulesViewModel;

        }
    }
}
