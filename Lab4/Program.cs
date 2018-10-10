using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcaring variables
            double userInput;
            int startingNumber = 1;
            double squared;
            double cubed;

            do
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer");
                userInput = double.Parse(Console.ReadLine());

                //Console.WriteLine(cubed);

                Console.WriteLine("{0,-8} {1,-8} {2,-8}","Number","Squared","Cubed");
                for (int i = startingNumber; i <= userInput; i++)
                {
                    squared = Math.Pow(i, 2);
                    cubed = Math.Pow(i, 3);
                    Console.WriteLine("{0,-9}{1,-9}{2,-9}", i, squared,
                        cubed);
                }
                Console.WriteLine("Do You Want To Continue. (y/n)?");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
