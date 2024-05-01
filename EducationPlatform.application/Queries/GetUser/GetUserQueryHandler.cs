using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery,UserViewModel>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetUserQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = _dbcontext.Users.FirstOrDefault(u => u.Id == request.Id);
            var UserDetailViewModel = new UserViewModel(user.FullName, user.Email, user.BirthDate, user.PhoneNumber);
            return UserDetailViewModel;
        }
    }
}
