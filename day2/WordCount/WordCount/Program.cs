using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //gets word count of first sentence
            var words = Counter.CountWords("Hello World!");
            Console.WriteLine("Number of words is " + words);

            //gets word count of second sentence
            words = Counter.CountWords("The Cat in the Hat");
            Console.WriteLine("Number of words is " + words);

            Console.ReadLine();
        }
    }
}
