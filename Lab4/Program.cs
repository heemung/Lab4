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

            //running yes or no loop
            do
            {
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an integer: ");
                userInput = double.Parse(Console.ReadLine());

                //starting table and spacing using escape code \n and position codes.
                Console.WriteLine("\n{0,-15} {1,-15} {2}","Number","Squared","Cubed");
                Console.WriteLine("{0,-15} {1,-15} {2}", "======", "=======", "=====");

                //loop tests starting number aginst user number, Runs until user number is reached.
                for (int i = startingNumber; i <= userInput; i++)
                {
                    //logic, takes starting number and uses squared and cubed from Math.Pow
                    squared = Math.Pow(i, 2);
                    cubed = Math.Pow(i, 3);

                    //Writes under table using position codes
                    Console.WriteLine("{0,-16}{1,-16}{2}", i, squared,
                        cubed);
                }
                Console.WriteLine("Do You Want To Continue. (y/n)?");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
