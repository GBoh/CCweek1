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
            for (int i = 0; i < messageArray.Length; i++)
            {
                //Console.WriteLine(messageArray[i]);

                //switch case to find words similar to "like", "don't like"
                switch (messageArray[i])
                {
                    case "like":
                        //Console.WriteLine("found the word like at array position " + i);
                        messageArray[i] = "don't like";
                        break;

                    case "don't":
                        messageArray[i] = "";
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", messageArray));
            Console.ReadLine();
        }
    }
}
