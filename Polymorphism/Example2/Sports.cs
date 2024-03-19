using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example2
{
    public class Sports:Ticket
    {
        public override void GetTicket()
        {
            Console.WriteLine("Spor Bileti");
        }
    }
}
