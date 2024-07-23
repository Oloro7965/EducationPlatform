using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Repositories;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetClass
{
    public class GetClassQueryHandler : IRequestHandler<GetClassQuery, ResultViewModel<ClassViewModel>>
    {
        private readonly IClassRepository _classRepository;

        public GetClassQueryHandler(IClassRepository classRepository)
        {

            _classRepository = classRepository;

        }

        public async Task<ResultViewModel<ClassViewModel>> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {

            //var class1 = _dbcontext.Classes.FirstOrDefault(m => m.Id == request.Id);

            var @class=await _classRepository.GetByIdAsync(request.Id);
            if (@class is null)
            {
                return ResultViewModel<ClassViewModel>.Error("Essa aula não existe");
            }
            var ClassDetailViewModel = new ClassViewModel(@class.Name, @class.Description, @class.VideoLink, @class.Duration);

            return ResultViewModel<ClassViewModel>.Success(ClassDetailViewModel);

        }
    }
}
