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
            var result = addNumbers(2, 3, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int addNumbers(params int[] number)
        {
            var sum = 0;

            foreach (var value in number)
            {
                sum += value;
            }

            return sum;
        }
    }
}
