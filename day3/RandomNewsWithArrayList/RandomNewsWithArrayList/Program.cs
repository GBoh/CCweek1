using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNewsWithArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsTick = new ArrayList();
            newsTick.Add("Life gave Cave Johnson lemons");
            newsTick.Add("Cave Johnson had his engineers make lemon grenades");
            newsTick.Add("Life was blown up");

            Random rnd = new Random();
            Console.WriteLine(newsTick[rnd.Next(3)]);
            Console.ReadLine();
        }
    }
}
