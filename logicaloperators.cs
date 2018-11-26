using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3; 

            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            // just like in math, some operators take precidence over others
            Console.WriteLine(a + b * c);
            // boolean expression will always render a boolean value
            Console.WriteLine( a == b );

            // tricky example, two negatives always equal a positive
     
            Console.WriteLine(!(a != b));

            //  c is greater than be and c is greater than a meaning this will result in a true

            Console.WriteLine(c > b && c > a);

            // and a true and false will result in false 
            Console.WriteLine(c > b && c == a );

        }
    }
}
