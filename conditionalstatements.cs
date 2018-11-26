using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalstatements
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter 
    }
    class Switch
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("it's autumn and a beautiful season"); ;
                    break;

                case Season.Summer:
                    Console.WriteLine("its perfect time to go to beach");
                    break;

                default:
                    Console.WriteLine("I dont understand that season!");
                    break;
            }
           
        }
    }
}
