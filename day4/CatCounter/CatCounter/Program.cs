using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CatCounter
{


    class Program
    {
        //first cat counter method, the one mentioned in class by me.

        public static int CountCats1(string sentence)
        {
            int numberOfCats = 0;
            string[] sentenceArr = sentence.Split(' ');
            for (int i = 0; i < sentenceArr.Length; i++)
            {
                if (sentenceArr[i] == "cat")
                {
                    numberOfCats++;
                }
            }
            return numberOfCats;
        }

        public static int CountCats2(string sentence)
        {
            int numberOfCats = 0;
            string findCat = "cat";
            int index = 0;

            while ((index = sentence.IndexOf(findCat, index)) != -1)
            {
                index += findCat.Length;
                numberOfCats++;
            }
            return numberOfCats;
        }

        static void Main(string[] args)
        {

            //copypasted code from MSDN to read file from disc(added @ so didn't have to do \\)
            System.IO.StreamReader myFile = new System.IO.StreamReader(@"C:\programming\CCweek1\day4\CatCounter\CatCounter\cat.txt");
            string catSentence = myFile.ReadToEnd();

            //var for ammount of cats and stopwatch
            var stopwatch = new Stopwatch();
            int catNumber;

            //timer and method
            stopwatch.Start();

            catNumber = CountCats1(catSentence);

            stopwatch.Stop();

            //writes results for first counter
            Console.WriteLine(catNumber);
            Console.WriteLine("was the number of times cat appeared");
            Console.WriteLine("It took {0} milliseconds", stopwatch.ElapsedMilliseconds);

            ////////////////////////////////////
            ////seperator and addeds some blanck space
            Console.WriteLine("\n\n");

            //timer and method
            stopwatch.Start();

            catNumber = CountCats2(catSentence);

            stopwatch.Stop();

            //writes results for second counter
            Console.WriteLine(catNumber);
            Console.WriteLine("was the number of times cat appeared");
            Console.WriteLine("It took {0} milliseconds", stopwatch.ElapsedMilliseconds);



            Console.ReadLine();
        }
    }
}
