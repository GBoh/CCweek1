using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i<100; i++)
            {
                var number = i % 7;
                if (number == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
