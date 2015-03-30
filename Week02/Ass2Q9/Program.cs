using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Algorithm:
             * amountOfCandies = amountToSpend / priceOfCandy
             * moneyLeft = amountToSpend – (amountOfCandies * priceOfCandy)
             * display moneyLeft, amountOfCandies
             */
            //input
            int priceOfCandy, amountToSpend, moneyLeft;
            int amountOfCandies;
            Console.Write("Enter price of candy: ");
            priceOfCandy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Amount to spend: ");
            amountToSpend = Convert.ToInt32(Console.ReadLine());
            //processing
            amountOfCandies = amountToSpend / priceOfCandy;
            moneyLeft = amountToSpend - (amountOfCandies * priceOfCandy);
            Console.WriteLine("Candies bought {0} and the the remaining money is {1:c}.",amountOfCandies, moneyLeft);
            Console.ReadLine();
        }
    }
}
