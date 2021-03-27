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
            Employee emp1 = new Employee() { firstName = "Joe", lastName = "Killinme", ID = 1 };
            Employee emp2 = new Employee() { firstName = "Bob", lastName = "Jones", ID = 2};
            Employee emp3 = new Employee() { firstName = "Sue", lastName = "Bacon", ID = 3};
            Employee emp4 = new Employee() { firstName = "Joe", lastName = "Nowat", ID = 4};
            Employee emp5 = new Employee() { firstName = "John", lastName = "Bassett", ID = 5};
            Employee emp6 = new Employee() { firstName = "Sally", lastName = "Couch", ID = 6};
            Employee emp7 = new Employee() { firstName = "Sam", lastName = "Larsen", ID = 7};
            Employee emp8 = new Employee() { firstName = "Joe", lastName = "Bananas", ID = 8};
            Employee emp9 = new Employee() { firstName = "Bob", lastName = "Ward", ID = 9};
            Employee emp10 = new Employee() { firstName = "Sue", lastName = "Leyden", ID = 10};
            Employee emp11 = new Employee() { firstName = "Jan", lastName = "Donaldson", ID = 11 };
            Employee emp12 = new Employee() { firstName = "Joe", lastName = "Free", ID = 12 };

            //Create list of at least 10 employees, each with firstName, lastName, and ID
            List<Employee> Employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10, emp11, emp12};

            //Using foreach loop, create new list of all employees with first name 'Joe'
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                if (employee.firstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }
            foreach (Employee joe in JoeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }

            //Do same thing with lambda expression
            List<Employee> JoeList2 = Employees.Where(x=> x.firstName == "Joe").ToList();
            foreach(Employee joe in JoeList2)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }
            Console.ReadLine();
        }
    }
}
