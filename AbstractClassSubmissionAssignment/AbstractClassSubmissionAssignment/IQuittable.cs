using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //Create IQuittable interface
    public interface IQuittable
    {
        //Create object of type IQuittiable 
        string Job { get; set; }

        //Define method Quit()
        void Quit();
    }
}
