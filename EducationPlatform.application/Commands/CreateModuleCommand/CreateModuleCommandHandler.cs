using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
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

        private readonly IModuleRepository _moduleRepository;

        public CreateModuleCommandHandler(IModuleRepository moduleRepository)
        {

            _moduleRepository = moduleRepository;

        }

        public async Task<Guid> Handle(CreateModuleCommand request, CancellationToken cancellationToken)
        {

            var module = new Modules(request.Name, request.Description,request.courseId);

            await _moduleRepository.AddAsync(module);

            return module.Id;

        }

    }

}
