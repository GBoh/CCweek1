using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {

        public static int? TryParseAsInt(string value)
        {
            int number;

            //checks if the value can be parsed as a whole number
            //if true return a parse of the number
            if (int.TryParse(value, out number))
            {
                return int.Parse(value);
            }
            //if not return null
            else
            {
                return null;
            }
        }


        static void Main(string[] args)
        {
            //debug to check if it returned as a whole number or a null
            Debug.Assert(TryParseAsInt("89898") == 89898);
            Debug.Assert(TryParseAsInt("I am not a number") == null);
            Debug.Assert(TryParseAsInt("6.5") == null);

            //pause
            Console.ReadLine();
        }
    }
}
