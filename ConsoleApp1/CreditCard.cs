using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CreditCard
    {
        private readonly string numbercreditCard;
        public double creditLimit { get; set; }
        public double ownMany { get; set; }
        
        public CreditCard(string numberCard)
        {
            numbercreditCard = numberCard;
        }

        public string getNumberCard()
        {
            return numbercreditCard;
        }

    }

}
