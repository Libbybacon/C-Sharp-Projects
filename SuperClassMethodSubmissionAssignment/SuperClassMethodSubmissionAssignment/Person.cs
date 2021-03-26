using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassMethodSubmissionAssignment
{
    public class Person
    {
        //Give class Person two string properties, FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Give class void method SayName that takes no parameters, writes person's full name to console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
