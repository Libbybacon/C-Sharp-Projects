using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //Employee class inherits Person class and IQuittable interface
    public class Employee : Person, IQuittable
    {
        //Give Employee ID property
        public int ID { get; set; }

        ////Add property 'things' and have data type be generic list matching generic type of class
        //public List Things {get; set;}


        //Implement SayName() method 
        public override void SayName()
        {
            Console.WriteLine("Employee name: " + firstName + " " + lastName);
            Console.ReadLine();
            base.SayName();
        }

        //Implement IQuittable() method
        public void Quit()
        {
            Console.WriteLine("This place sucks, I quit!");
        }

        //Overload '==' operator so it checks if two Employee objects are equal by comparing ID property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////Overload '!=' operator because you have to if you're going to change the '==' operator.  I think...
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
