using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlakyCatch
{
    class Program
    {

        public static void Flaky()
        {
            if (new Random().NextDouble() < 0.5)
            {
                Console.WriteLine("Finished calling Flaky");
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Flaky();
            }
            catch
            {
                Console.WriteLine("Yikes! There was an error");
            }
            Console.ReadLine();
        }
    }
}
