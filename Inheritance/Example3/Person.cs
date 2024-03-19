using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Example3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }

    public class Personnel : Person
    {
        public int WorkHour { get; set; }
        public decimal Salary { get; set; }
        public string Departmant { get; set; }

        
    }

    public class SalesConsultant : Personnel
    {
        public decimal Bonus { get; set; }
        
    }
}
