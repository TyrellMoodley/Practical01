using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TyrellStudyGroup.Models
{
    public class Student
    {
        public string StudentNumbers;
        public string Name;
        public string Surname;
        public string EmailAddress;

        public string StudentNumber
        {
            get { return StudentNumbers; }
            set { StudentNumbers = value; }
        }

        public string studentName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string studentSurname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public string studentEmailAdress
        {
            get { return EmailAddress; }
            set { EmailAddress = value; }
        }
    }
}