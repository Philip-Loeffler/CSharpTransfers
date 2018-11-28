using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomclass
{
    class Program
    {
        static void Main(string[] args)
        {
            // random class gives us random integers
            var random = new Random();
            for (var i = 0; i <=10; i++)
                // this will give us random numbers between one and ten
                Console.WriteLine(random.Next(1, 10));

            // fun fact, computers only understand numbers
            // here is a lowercase a's binary number
            Console.WriteLine((int)'a');
            // here is a random string of chars
            Console.Write((char)random.Next(0, 26));

            // last creating a random string for a password

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var a = 10; a <= 10; a++)
                buffer[a] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
       

        }
    }
}
