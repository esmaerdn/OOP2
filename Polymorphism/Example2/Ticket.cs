using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example2
{
    public class Ticket
    {
        public virtual void GetTicket()
        {
            Console.WriteLine("Genel bilet");
        }
    }
}
