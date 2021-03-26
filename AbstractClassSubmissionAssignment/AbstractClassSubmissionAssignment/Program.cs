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
           
            //Use polymorphism to create object of type IQuittable, 
            IQuittable employee = new Employee() { firstName = "Sample", lastName = "Student"};
            //Call Quit() method on IQuittable object
            employee.Quit();

            Console.ReadLine();



            


        }
    }
}
