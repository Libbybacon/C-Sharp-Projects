using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //Create abstract class Person
    public abstract class Person
    {
        //Two string properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Method SayName
        public virtual void SayName()
        {
            Console.WriteLine("Employee name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
