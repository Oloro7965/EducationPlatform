using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetClass
{
    public class GetClassQuery:IRequest<ResultViewModel<ClassViewModel>>
    {
        public GetClassQuery(Guid id)
        {

            Id = id;

        }

        public Guid Id { get; private set; }
    }
}
