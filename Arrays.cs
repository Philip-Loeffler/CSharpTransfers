using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayScontinued
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 15, 6 };

            // length returns the size of the array
            Console.WriteLine("length" + numbers.Length);

            // indexOf() returns an integer
            //  index of 9 is 2 because it is the third element in the array and it starts at 0
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9", + index);

            // clear() sets first two numbers to 0
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of clear()");
            foreach( var n in numbers)
                Console.WriteLine(n);
            Console.ReadLine();

            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            //sort() sorts the number in order 
            Array.Sort(another);

            //Reverse() reverses the order
            Array.Reverse(numbers);

            //list 
            var numbers1 = new List<int>();
            
        }
    }
}
