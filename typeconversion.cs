using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            int l = 1;
            // cannot implicity conver type int to byte
            byte v = l;
            // casting so no data is lost 
            byte m = (byte)l;
            Console.WriteLine(l);
            // now non compatible types
            string number = "1234";
            //cannot convert int to string so need to use convert class
            int a = Convert.ToInt32(number);
            Console.WriteLine(a);
            // crashing the system now, trying to convert string with larger number than byte
          
            byte f = Convert.ToByte(number);
            Console.WriteLine(f);

            // last using an try catch block to run the code 
            // since we know the byte cannot be converted
            // the code tries to compile and run the convert but it doesnt work
            // so it catches and throws the console right line exception
                 try
            {
                var numbers = "122334";
                byte z = Convert.ToByte(numbers);
                Console.WriteLine(z);
                
            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be converted to a byte");
                Console.ReadLine();
            }


        }
    }
}
