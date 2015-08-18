using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = addNumbers(2, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int addNumbers(params int[] number)
        {
            var sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            return sum;
        }
    }
}
