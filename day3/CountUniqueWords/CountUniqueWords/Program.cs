using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountUniqueWords
{
    class Program
    {
        static int CountWords(string sentence)
        {
            Hashtable uniqueWords = new Hashtable();
            var lower = sentence.ToLower();
            var wordArr = lower.Split(' ');
            int key = 0;

            foreach (var word in wordArr)
            {
                if (!uniqueWords.ContainsKey(word))
                {
                    uniqueWords.Add(word, key+=1);
                }
            }
            return key;
        }

        static void Main(string[] args)
        {
            ;
            Debug.Assert(CountWords("The cat and the cat ate the rat") == 5);
        }
    }
}
