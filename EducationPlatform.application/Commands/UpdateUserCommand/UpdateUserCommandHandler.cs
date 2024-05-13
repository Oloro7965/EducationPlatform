﻿using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.UpdateUserCommand
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {

        private readonly EducationPlatformDbContext _dbcontext;

        public UpdateUserCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _dbcontext.Users.SingleOrDefault(u => u.Id == request.Id);
            user.Update(request.Email, request.PhoneNumber);
            //_dbcontext.Update(user);  
            _dbcontext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}