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

            //Instantiate Employee1 
            Employee employee1 = new Employee() { ID = 1234};

            //Instantiate Employee2
            Employee employee2 = new Employee() { ID = 1235 };

            if (employee1 == employee2)
            {
                Console.WriteLine("Employees 1 and 2 have the same ID number");
            }
            else
            {
                Console.WriteLine("Employees 1 and 2 have different ID numbers");
            }
            Console.ReadLine();



            
            Console.ReadLine();



            


        }
    }
}
