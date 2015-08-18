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
            //asks for date and converts it to large format
            ////informs the user of what to do
            //console.writeline("enter you date");


            //var datestring = console.readline();
            //console.writeline(datestring); //not needed just to double check datestring is being read from readline
            //console.writeline(datetime.parse(datestring).tostring("d"));

            ////to hold the code at the end to double check
            //console.readline();


            ////////////////////////////////////////////
            //picks random news tick

            //Random rnd = new Random();

            //var newsTicker = new string[]
            //{
            //    "Martians attack!","Life gives Cave Jonson Lemons","Life gets blown up by lemon grenades"
            //};

            //int message = rnd.Next(0, newsTicker.Length);
            //Console.WriteLine(newsTicker[message]);
            //Console.ReadLine();

            ////////////////////////////////////////////
            //yoda speak


            ////gets a message written by the user
            //var message = Console.ReadLine();
            ////dispay message test
            ////Console.WriteLine(message);

            ////convert message to array, split on spaces
            //var reverseMessage = message.Split(' ');
            ////reverse array
            //Array.Reverse(reverseMessage);

            ////write reversed message
            //Console.WriteLine(string.Join(" ", reverseMessage));


            ////stop
            //Console.ReadLine();

            ////////////////////////////////////////////
            //news ticker switch case


            Random rnd = new Random();


            switch (rnd.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("Life gave you lemons");
                 break;

                case 2:
                    Console.WriteLine("Life gave Cave Johnson lemons");
                    break;

                case 3:
                    Console.WriteLine("Life was blown up by lemon grenades");
                    break;
            }

            Console.ReadLine();
        }
    }
}