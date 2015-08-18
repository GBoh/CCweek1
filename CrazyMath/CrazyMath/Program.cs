using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{

    class FunnyMath
    {
        public static int CalculateNumbers(int number1, int number2)
        {
            return number1 / number2;
        }

        public static int CalculateNumbers(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public static int CalculateNumbers(int number1, int number2, int number3, int number4)
        {
            return number1 * number2 * number3 * number4;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunnyMath.CalculateNumbers(2, 2,2,2));
            Console.ReadLine();
        }
    }

    
}
