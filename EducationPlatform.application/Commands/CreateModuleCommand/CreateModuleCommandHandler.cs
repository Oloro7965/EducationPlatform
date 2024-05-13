using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateModuleCommand
{
    public class CreateModuleCommandHandler : IRequestHandler<CreateModuleCommand, Guid>
    {

        private readonly EducationPlatformDbContext _dbcontext;

        public CreateModuleCommandHandler(EducationPlatformDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public async Task<Guid> Handle(CreateModuleCommand request, CancellationToken cancellationToken)
        {

            var module = new Modules(request.Name, request.Description);

            _dbcontext.Modules.AddAsync(module);
            _dbcontext.SaveChangesAsync();

            return module.Id;

        }

    }

}
