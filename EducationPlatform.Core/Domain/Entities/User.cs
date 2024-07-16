using EducationPlatform.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class User:BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        //colocar encrypted na senha
        public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Document  { get; private set; }
        public string PhoneNumber { get; private set; }
        public ERole Role { get; private set; }
        public bool IsActive { get; private set; }
        public List<UserSignature> usersignatures { get; private set; }
        public List<UserFinishedClass> finishedClasses { get; private set; }
        public User() { }
        public User(string fullName,string email,string password,DateTime birthdate,string document,string phoneNumber,ERole role) {

            FullName = fullName;

            Email = email;

            Password = password;

            BirthDate = birthdate;

            Document = document;

            PhoneNumber = phoneNumber;

            IsActive = true;

            Role = role;

            usersignatures= new List<UserSignature>();

        }
        public void Update(string email,string phoneNumber)
        {

            Email = email;

            PhoneNumber = phoneNumber;

        }
        public void Delete() {

            this.IsActive = false;

        }

    }

}
