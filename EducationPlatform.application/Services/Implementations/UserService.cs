using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public UserService(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        //public List<UserViewModel> Get(string query)
        //{
        //    var users = _dbcontext.Users.Where(u => u.IsActive.Equals(true));
        //    var usersViewModel = users.Select(b => new UserViewModel(b.FullName
        //        ,b.Email,b.BirthDate,b.PhoneNumber))
        //        .ToList();
        //    return usersViewModel;
        //}

        public UserViewModel GetById(Guid id)
        {
            var user=_dbcontext.Users.FirstOrDefault(u => u.Id == id);
            var UserDetailViewModel=new UserViewModel(user.FullName,user.Email,user.BirthDate,user.PhoneNumber);
            return UserDetailViewModel;
        }

        //public void Update(UserUpdateInputModel model)
        //{
        //    var user= _dbcontext.Users.FirstOrDefault(user=>user.Id==model.Id);
        //    user.Update(model.Email, model.PhoneNumber);
        //    _dbcontext.SaveChanges();
        //}
    }
}
