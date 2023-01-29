using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Employee
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int YearsOfExperience { get; set; }
        public Employee(string aFirstName, string aLastName, int aAge, int aYearsOfExperience)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            Age = aAge;
            YearsOfExperience = aYearsOfExperience;
        }

    }
}
