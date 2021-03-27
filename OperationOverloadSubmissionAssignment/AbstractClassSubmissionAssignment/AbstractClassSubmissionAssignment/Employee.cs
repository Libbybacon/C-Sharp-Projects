using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //Employee class inherits Person class and IQuittable interface
    public class Employee : Person
    {
        //Give Employee ID property
        public int ID { get; set; }


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
