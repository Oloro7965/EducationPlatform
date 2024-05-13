using EducationPlatform.application.ViewModel;
using EducationPlatform.Infraestructure.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetClass
{
    public class GetClassQueryHandler : IRequestHandler<GetClassQuery, ClassViewModel>
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public GetClassQueryHandler(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<ClassViewModel> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {
            var class1 = _dbcontext.Classes.FirstOrDefault(m => m.Id == request.Id);
            var ClassDetailViewModel = new ClassViewModel(class1.Name, class1.Description, class1.VideoLink, class1.Duration);
            return ClassDetailViewModel;
        }
    }
}
