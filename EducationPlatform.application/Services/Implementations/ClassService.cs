using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.application.ViewModel;
using EducationPlatform.Core.Domain.Entities;
using EducationPlatform.Infraestructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Implementations
{
    public class ClassService : IClassService
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public ClassService(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        //public Guid Create(NewClassInputModel Model)
        //{
        //    var class1 = new Class(Model.Name, Model.Description, Model.VideoLink,Model.Duration);
        //    _dbcontext.Classes.Add(class1);
        //    _dbcontext.SaveChanges();
        //    return class1.Id;
        //}

        //public List<ClassViewModel> Get()
        //{
        //    var classes = _dbcontext.Classes;
        //    var ClassesViewModel = classes.Select(b => new ClassViewModel(b.Name,
        //        b.Description, b.VideoLink,b.Duration))
        //        .ToList();
        //    return ClassesViewModel;
        //}

        //public ClassViewModel GetById(Guid id)
        //{
        //    var class1 = _dbcontext.Classes.FirstOrDefault(m => m.Id == id);
        //    var ClassDetailViewModel = new ClassViewModel(class1.Name, class1.Description, class1.VideoLink,class1.Duration);
        //    return ClassDetailViewModel;
        //}
    }
}
