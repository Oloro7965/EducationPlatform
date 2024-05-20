using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email,DateTime birthDate, string phoneNumber)
        {

            FullName = fullName;

            Email = email;

            //Password = password;
            BirthDate = birthDate;

            PhoneNumber = phoneNumber;

        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        //colocar encrypted na senha
        //public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
