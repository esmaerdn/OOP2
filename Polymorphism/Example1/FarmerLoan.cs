using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example1
{
    public class FarmerLoan : ILoan
    {

        public void Calculate()
        {
            Console.WriteLine("tarim kredisi hesaplandi");
        }


    }
}
