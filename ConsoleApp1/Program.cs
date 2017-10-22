using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard("0000 0000 0000 0000 1111");
            Console.WriteLine(creditCard.getNumberCard());
            Console.ReadKey();
        }
    }
}
