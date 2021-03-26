using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize an Employee object with first and last name
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};

            //Call superclass method SayName() on Employee object
            employee.SayName();
            Console.ReadLine();

        }
    }
}
