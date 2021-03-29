using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string businessName = "BestBusinessEver";

            // Create a variable using the keyword 'var'
            var emp1 = new Employee("Joe", "Killinme");
            var emp2 = new Employee("Bob", "Jones", 2);
            var emp3 = new Employee("Sue", "Bacon", 3);
            var emp4 = new Employee("Joe", "Nowat", 4);
            var emp5 = new Employee("John", "Bassett", 5);
            var emp6 = new Employee("Sally", "Couch", 6);
            var emp7 = new Employee("Sam", "Larsen", 7);
            var emp8 = new Employee("Joe", "Bananas", 8);
            var emp9 = new Employee("Bob", "Ward", 9);
            var emp10 = new Employee("Sue", "Leyden", 10);
            var emp11 = new Employee("Jan", "Donaldson", 11);
            var emp12 = new Employee("Joe", "Free", 12);

            //Create list of at least 10 employees, each with firstName, lastName, and ID
            List<Employee> Employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10, emp11, emp12 };

            //Using foreach loop, create new list of all employees with first name 'Joe'
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }
            foreach (Employee joe in JoeList)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            //Do same thing with lambda expression
            List<Employee> JoeList2 = Employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee joe in JoeList2)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }
            Console.ReadLine();
        }
    }
    
}
