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
            IQuittable employee = new Employee() { firstName = "Sample", lastName = "Student"};
            //Call SayName() method
            employee.Quit();

            Console.ReadLine();

            


        }
    }
}
