
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Counter
    {
        //gets argument string and splits on the spaces returning length
        public static int CountWords(string sentence)
        {
             return sentence.Split(' ').Length;
        }
    }
}
