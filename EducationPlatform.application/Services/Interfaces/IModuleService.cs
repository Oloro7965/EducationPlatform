using EducationPlatform.application.InputModel;
using EducationPlatform.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Interfaces
{
    public interface IModuleService
    {
        List<ModuleViewModel> Get();
        ModuleViewModel GetById(Guid id);
        void Update(ModuleUpdateInputModel model);
        Guid Create(NewModuleInputModel UserInputModel);
    }
}
