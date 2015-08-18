using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contrarian
{
    class Program
    {
        static void Main(string[] args)
        {

            //get user message
            //find the world "like"
            //replace the word like with "don't like"
            //ExC. Generalize to include other worlds.
            var userMessage = Console.ReadLine();
            //var lower = userMessage.ToLower();
            //Console.WriteLine(lower);

            //splits message to array on splits
            var messageArray = userMessage.Split(' ');

            //itterates through array to look for words to disagree with
            var wordFound = false;
            var i = 0;
            while (!wordFound)
            {
                //Console.WriteLine(messageArray[i]);
                if (messageArray[i] == "don't")
                {
                    messageArray[i] = "";
                    wordFound = true;
                    break;
                }

                if (messageArray[i] == "like")
                {
                    messageArray[i] = "don't like";
                    wordFound = true;
                    break;
                }
                i++;
            }
            Console.WriteLine(string.Join(" ", messageArray.Where(s => !String.IsNullOrEmpty(s))));
            Console.ReadLine();
        }

        //public string[] Where(string[] messageArray)
        //{
        //    List<string> temp = new List<string>();
        //    foreach(var s in messageArray)
        //    {
        //        if (!String.IsNullOrEmpty(s))
        //        {
        //            temp.Add(s);
        //        }
        //    }
        //    return temp.ToArray<string>();
        //}
    }
}
