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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Create method SayName()
        public virtual void SayName()
        {
          
        }
    }
}
