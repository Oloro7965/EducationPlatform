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
    public class SignatureService : ISignatureService
    {
        private readonly EducationPlatformDbContext _dbcontext;

        public SignatureService(EducationPlatformDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Guid Create(NewSignatureInputModel Model)
        {
            var signature = new Signature(Model.Name, Model.Duration,Model.Courses);
            _dbcontext.Signatures.Add(signature);
            //_dbcontext.SaveChanges();
            return signature.Id;
        }

        public List<SignatureViewModel> Get()
        {
            var signatures = _dbcontext.Signatures;
            var signaturesViewModel = signatures.Select(b => new SignatureViewModel(b.Name
                , b.Duration,b.Courses))
                .ToList();
            return signaturesViewModel;
        }

        public SignatureViewModel GetById(Guid id)
        {
            var signature = _dbcontext.Signatures.FirstOrDefault(b => b.Id == id);
            var SignatureDetailViewModel = new SignatureViewModel(signature.Name,signature.Duration,signature.Courses);
            return SignatureDetailViewModel;
        }
    }
}
