using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateUserCommand
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResultViewModel>
    {

        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {

            _userRepository = userRepository;

        }

        public async Task<ResultViewModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            //var user = _dbcontext.Users.SingleOrDefault(u => u.Id == request.Id);
            var user=await _userRepository.GetByIdAsync(request.Id);
            if (user is null)
            {
                return ResultViewModel.Error("Usuário não existe");
            }
            user.Update(request.Email, request.PhoneNumber);

            //_dbcontext.Update(user);  
            _userRepository.SaveChangesAsync();

            return ResultViewModel.Success();

        }
    }
}
