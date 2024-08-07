﻿using EducationPlatform.application.ViewModel;
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
    public class UpdateModuleCommandHandler : IRequestHandler<UpdateModuleCommand, ResultViewModel>

    {

        private readonly IModuleRepository _moduleRepository;

        public UpdateModuleCommandHandler(IModuleRepository moduleRepository)

        {
            
            _moduleRepository = moduleRepository;

        }

        public async Task<ResultViewModel> Handle(UpdateModuleCommand request, CancellationToken cancellationToken)
        {

            //var Module = _dbcontext.Modules.FirstOrDefault(m => m.Id == request.Id);
            var Module = await _moduleRepository.GetByIdAsync(request.Id);
            if (Module is null)
            {
                return ResultViewModel.Error("Este Módulo não existe");
            }
            Module.Update(request.Description);

            await _moduleRepository.SaveChangesAsync();

            return ResultViewModel.Success();

        }

    }

}
