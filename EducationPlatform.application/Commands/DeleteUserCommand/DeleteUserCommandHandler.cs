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
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public DeleteUserCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user =_dbcontext.Users.FirstOrDefault(x => x.Id == request.Id);
            user.Delete();
            await _dbcontext.SaveChangesAsync();
            return Unit.Value;
        
        }
    }
}
