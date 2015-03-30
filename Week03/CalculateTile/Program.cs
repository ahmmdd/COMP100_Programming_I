using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 
 * Tile Limited wants a program allows its salesclerk to enter the length and width 
 * (in meters) of a rectangle and the price of a square meter of tile. The program should 
 * display the area of the rectangle and the total price of the tile.
 * 
 */
namespace CalculateTile{
    class Program{
        static void Main(string[] args){
            
            double length, width, unitPrice, area, totalCost;
            //STEP 1 - prompt and accept length, width, and unitPrice
            Console.Write("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter unitPrice: ");
            unitPrice = Convert.ToInt32(Console.ReadLine());
            //STEP 2 - calculate area = length * width
            area = length * width;
            //STEP 3 - calculate totalCost = area * unitPrice
            totalCost = area * unitPrice;
            //STEP 4 - display area, totalCost
            Console.WriteLine("Area is {0} square meters", area);
            Console.WriteLine("Total cost will be $ {0}", totalCost);


            Console.ReadLine();
        }
    }
}
