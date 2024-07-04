﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Domain.Entities
{
    public class Signature:BaseEntity
    {
        public string Name { get; private set; }
        public int Duration { get; private set; }
        public List<UserSignature> usersignatures { get; private set; }
        public List<Course> Courses { get; private set; }
        public Signature() { }
        public Signature(string name,int duration) {

            Name = name;

            Duration = duration;

            Courses=new List<Course>();

        }

    }

}
