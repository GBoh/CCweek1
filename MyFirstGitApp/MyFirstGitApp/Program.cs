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
            ////informs the user of what to do
            //console.writeline("enter you date");


            //var datestring = console.readline();
            //console.writeline(datestring); //not needed just to double check datestring is being read from readline
            //console.writeline(datetime.parse(datestring).tostring("d"));

            ////to hold the code at the end to double check
            //console.readline();

            Random rnd = new Random();

            var newsTicker = new string[]
            {
                "Martians attack!","Life gives Cave Jonson Lemons","Life has been blown up by lemon grenades"
            };

            int pickMessage = rnd.Next(0, newsTicker.Length);
            Console.WriteLine(newsTicker[pickMessage]);
            Console.ReadLine();
        }
    }
}