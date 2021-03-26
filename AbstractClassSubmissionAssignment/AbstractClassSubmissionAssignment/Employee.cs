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
        IQuittable Job { get; set; }

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
    }
}
