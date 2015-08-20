using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class ProfanityCleaner
    {
        Dictionary<string, string> badWords = new Dictionary<string, string>();
        public ProfanityCleaner()
        {
            badWords.Add("darn", "drat");
            badWords.Add("gosh", "golly gee willikers");
            badWords.Add("yuck", "yech");
        }

        internal string Clean(string sentence)
        {
            StringBuilder sb = new StringBuilder();

            var wordsArr = sentence.Split(' ');
            foreach (var word in wordsArr)
            {
                if (badWords.ContainsKey(word))
                {
                    sb.Append(badWords[word] + " ");
                }
                else
                {
                    sb.Append(word + " ");
                }
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var chatMonitor = new ProfanityCleaner();
            Console.WriteLine("gosh darn it I hate those green things. yuck \n\n");

            Console.WriteLine(chatMonitor.Clean("gosh darn it I hate those green things. yuck"));
            Console.ReadLine();
        }
    }
}