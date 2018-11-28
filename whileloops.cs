using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        { 

            //same increment code as for loop
            var i = 0;
            while (i <= 10)
                {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
                }
            // this is an infinte while loop without anything read for console
            while (true)
            {
                Console.Write("type your name");
                // here is letting the user put in something
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                // after putting name it just literally just repeats whatever input 
                Console.WriteLine("@echo:" + input);
            }
        }
    }
}
