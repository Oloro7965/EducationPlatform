using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Commands.CreateFinishedClassCommand
{
    public class CreateFinishedClassCommandHandler : IRequestHandler<CreateFinishedClassCommand, Guid>
    {
        private readonly IFinishedClassRepository _finishedClassRepository;

        public CreateFinishedClassCommandHandler(IFinishedClassRepository finishedClassRepository)
        {
            _finishedClassRepository = finishedClassRepository;
        }

        public async Task<Guid> Handle(CreateFinishedClassCommand request, CancellationToken cancellationToken)
        {
            var finishedClass = new UserFinishedClass(request.UserId,request.ClassId,request.FinishedDate,request.Grade);

            await _finishedClassRepository.AddAsync(finishedClass);

            return finishedClass.Id;
        }
    }
}
