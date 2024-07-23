using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Core.Domain.Results;
using EducationPlatform.Core.Domain.Results.Errors;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery,ResultViewModel<UserViewModel>>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {

            _userRepository = userRepository;

        }

        public async Task<ResultViewModel<UserViewModel>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            //var user = _dbcontext.Users.FirstOrDefault(u => u.Id == request.Id);
            var user = await _userRepository.GetByIdAsync(request.Id);
            if (user is null)
            {
                return ResultViewModel<UserViewModel>.Error("Este Usuário não existe");
            }
            var UserDetailViewModel = new UserViewModel(user.FullName, user.Email, user.BirthDate, user.PhoneNumber);
            //var UserDetailViewModel = UserViewModel.FromEntity(user);
            return ResultViewModel<UserViewModel>.Success(UserDetailViewModel);

        }
    }
}
