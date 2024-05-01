using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetUser
{
    public class GetUserQuery:IRequest<UserViewModel>
    {
        public Guid Id { get; private set; }
    }
}
