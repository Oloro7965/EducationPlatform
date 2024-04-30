using EducationPlatform.application.InputModel;
using EducationPlatform.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.Services.Interfaces
{
    public interface ISignatureService
    {
        List<SignatureViewModel> Get();
        SignatureViewModel GetById(Guid id);
        Guid Create(NewSignatureInputModel UserInputModel);
    }
}
