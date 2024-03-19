using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Example1
{
    public class Student :User
    {
        public string Department { get; set; }

        public double GPA { get; set; }
    }
}
