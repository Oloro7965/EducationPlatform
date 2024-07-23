using EducationPlatform.application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Queries.GetAllModules
{
    public class GetAllModulesQuery:IRequest<ResultViewModel<List<ModuleViewModel>>>
    {
    }
}
