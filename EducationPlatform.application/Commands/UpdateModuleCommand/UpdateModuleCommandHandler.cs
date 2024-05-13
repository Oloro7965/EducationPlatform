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

        private readonly EducationPlatformDbContext _dbcontext;

        public UpdateModuleCommandHandler(EducationPlatformDbContext dbcontext)

        {
            
            _dbcontext = dbcontext;

        }

        public async Task<Unit> Handle(UpdateModuleCommand request, CancellationToken cancellationToken)
        {

            var Module = _dbcontext.Modules.FirstOrDefault(m => m.Id == request.Id);

            Module.Update(request.Description);
            _dbcontext.SaveChangesAsync();

            return Unit.Value;

        }

    }

}
