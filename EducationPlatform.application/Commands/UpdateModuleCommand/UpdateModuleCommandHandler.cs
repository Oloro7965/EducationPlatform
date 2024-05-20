using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateModuleCommand
{
    public class UpdateModuleCommandHandler : IRequestHandler<UpdateModuleCommand, Unit>

    {

        private readonly IModuleRepository _moduleRepository;

        public UpdateModuleCommandHandler(IModuleRepository moduleRepository)

        {
            
            _moduleRepository = moduleRepository;

        }

        public async Task<Unit> Handle(UpdateModuleCommand request, CancellationToken cancellationToken)
        {

            //var Module = _dbcontext.Modules.FirstOrDefault(m => m.Id == request.Id);
            var Module = await _moduleRepository.GetByIdAsync(request.Id);

            Module.Update(request.Description);

            _moduleRepository.SaveChangesAsync();

            return Unit.Value;

        }

    }

}
