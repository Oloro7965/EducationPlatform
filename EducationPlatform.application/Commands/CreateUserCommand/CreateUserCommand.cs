using EducationPlatform.Core.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateUserCommand
{
    public class CreateUserCommand: IRequest<Guid>
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        //colocar encrypted na senha
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public ERole Role { get; set; }

    }

}
