using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodeFirstApp2
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
