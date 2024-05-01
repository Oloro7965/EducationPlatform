using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetAllUsersQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = _dbcontext.Users.Where(u => u.IsActive.Equals(true));
            var usersViewModel =await users.Select(b => new UserViewModel(b.FullName
                 ,b.Email,b.BirthDate,b.PhoneNumber))
                 .ToListAsync();
            return usersViewModel;
        }
    }
}
