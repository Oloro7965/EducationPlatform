using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateClassCommand
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, Guid>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public CreateClassCommandHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var @class = new Class(request.Name, request.Description, request.VideoLink, request.Duration);

            await _dbcontext.Classes.AddAsync(@class);
            await _dbcontext.SaveChangesAsync();

            return @class.Id;
        }
    }
}
