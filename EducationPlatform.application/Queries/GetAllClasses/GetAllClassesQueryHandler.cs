using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllClasses
{
    public class GetAllClassesQueryHandler : IRequestHandler<GetAllClassesQuery, List<ClassViewModel>>
    {
        private readonly IClassRepository _classRepository;

        public GetAllClassesQueryHandler(IClassRepository classRepository)
        {

            _classRepository = classRepository;

        }

        public async Task<List<ClassViewModel>> Handle(GetAllClassesQuery request, CancellationToken cancellationToken)
        {
            //var classes = _dbcontext.Classes;
            var classes = await _classRepository.GetAllAsync();

            var ClassesViewModel = classes.Select(b => new ClassViewModel(b.Name,
                b.Description, b.VideoLink, b.Duration))
                .ToList();

            return ClassesViewModel;

        }
    }
}
