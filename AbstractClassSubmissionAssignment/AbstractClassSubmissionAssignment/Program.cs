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

            ////Use polymorphism to create object of type IQuittable
            //IQuittable employee = new Employee<string>() { firstName = "Sample", lastName = "Student" };

            ////Call Quit() method on IQuittable object
            //employee.Quit();



            ////Instantiate Employee object with type "string" as generic parameter
            //Employee<string> employee1 = new Employee<string>();

            ////Assign a list of strings as the property value of Things
            //employee1.Things = new List<string>() {"Office", "Computer", "Desk", "Chair", "Phone" };

            ////Instantiate Employee object with type "int" as generic parameter
            //Employee<int> employee2 = new Employee<int>();

            ////Assign list of integers as the property value of Things
            //employee2.Things = new List<int>() { 13, 7, 14, 21, 3};

            //foreach (string thing in employee1.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //foreach (int thing in employee2.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            
            Console.ReadLine();



            


        }
    }
}
