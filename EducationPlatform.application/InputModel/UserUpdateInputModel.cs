﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.application.InputModel
{
    public class UserUpdateInputModel
    {
        public Guid Id { get;private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
