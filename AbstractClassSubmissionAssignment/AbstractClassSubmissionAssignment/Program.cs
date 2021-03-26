using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employee object
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student"};
            //Call SayName() method
            employee.SayName();

            employee.Job.Quit();


        }
    }
}
