﻿using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.DeleteUserCommand
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResultViewModel>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {

            _userRepository=userRepository;

        }

        public async Task<ResultViewModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {

            //var user =_dbcontext.Users.FirstOrDefault(x => x.Id == request.Id);
            var user = await _userRepository.GetByIdAsync(request.Id);
            if (user is null)
            {
                return ResultViewModel.Error("Este usuário não existe");
            }
            user.Delete();

            await _userRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        
        }
    }
}
