using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Implementations
{
    public class ModuleService : IModuleService
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public ModuleService(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Guid Create(NewModuleInputModel Model)
        {
            var module = new Module(Model.Name, Model.Description);
            _dbcontext.Modules.Add(module);
            _dbcontext.SaveChanges();
            return module.Id;
        }

        public List<ModuleViewModel> Get()
        {
            var modules = _dbcontext.Modules;
            var modulesViewModel = modules.Select(b => new ModuleViewModel(b.Name
                ,b.Description,b.CreatedDate))
                .ToList();
            return modulesViewModel;
        }

        public ModuleViewModel GetById(Guid id)
        {
            var module = _dbcontext.Modules.FirstOrDefault(m => m.Id == id);
            var ModuleDetailViewModel=new ModuleViewModel(module.Name,module.Description,module.CreatedDate);
            return ModuleDetailViewModel;
        }

        public void Update(ModuleUpdateInputModel model)
        {
            var Module=_dbcontext.Modules.FirstOrDefault(m=>m.Id == model.Id);
            Module.Update(model.Description);
            _dbcontext.SaveChanges();
        }
    }
}
