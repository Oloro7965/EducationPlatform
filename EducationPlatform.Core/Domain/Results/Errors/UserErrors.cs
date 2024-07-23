using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Results.Errors
{
    public static class UserErrors
    {
        public static readonly Error NotFound = new("User.NotFound", "Usuário não encontrado");
    }
}
