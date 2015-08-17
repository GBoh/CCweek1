using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //informs the user of what to do
            Console.WriteLine("Enter you date");


            var dateString = Console.ReadLine();
            Console.WriteLine(dateString); //not needed just to double check dateString is being read from ReadLine
            Console.WriteLine(DateTime.Parse(dateString).ToString("D"));

            //to hold the code at the end to double check
            Console.ReadLine();


        }
    }
}