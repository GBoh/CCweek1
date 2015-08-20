using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCodeWithHashTable
{
    class Program
    {

        public static string Encrypt(string message)
        {
            //sets lower case
            var lower = message.ToLower();

            //puts each char of the string into an single array
            var encryptArray = lower.ToCharArray();

            //cipher
            Hashtable encyrptLetter = new Hashtable();
            encyrptLetter.Add("a", "z");
            encyrptLetter.Add("b", "y");
            encyrptLetter.Add("c", "x");
            encyrptLetter.Add("d", "w");
            encyrptLetter.Add("e", "v");
            encyrptLetter.Add("f", "u");
            encyrptLetter.Add("g", "t");
            encyrptLetter.Add("h", "s");
            encyrptLetter.Add("i", "r");
            encyrptLetter.Add("j", "q");
            encyrptLetter.Add("k", "p");
            encyrptLetter.Add("l", "o");
            encyrptLetter.Add("m", "n");
            encyrptLetter.Add("n", "m");
            encyrptLetter.Add("o", "l");
            encyrptLetter.Add("p", "k");
            encyrptLetter.Add("q", "j");
            encyrptLetter.Add("r", "i");
            encyrptLetter.Add("s", "h");
            encyrptLetter.Add("t", "g");
            encyrptLetter.Add("u", "f");
            encyrptLetter.Add("v", "e");
            encyrptLetter.Add("w", "d");
            encyrptLetter.Add("x", "c");
            encyrptLetter.Add("y", "b");
            encyrptLetter.Add("z", "a");
            encyrptLetter.Add(" ", " ");
            encyrptLetter.Add(".", ".");


            //iterates through each char, converts to string runs through has and appends to stringbuilder
            StringBuilder sb = new StringBuilder();
            foreach (var item in lower)
            {
                var letter = item.ToString();
                string value = (string)encyrptLetter[letter];
                sb.Append(value);
            }
            return sb.ToString();
        }

        public static string Decrypt(string message)
        {
            //sets lower case
            var lower = message.ToLower();

            //puts each char of the string into an single array
            var DecryptArray = lower.ToCharArray();

            //cipher
            Hashtable decyrptLetter = new Hashtable();
            decyrptLetter.Add("z", "a");
            decyrptLetter.Add("y", "b");
            decyrptLetter.Add("x", "c");
            decyrptLetter.Add("w", "d");
            decyrptLetter.Add("v", "e");
            decyrptLetter.Add("u", "f");
            decyrptLetter.Add("t", "g");
            decyrptLetter.Add("s", "h");
            decyrptLetter.Add("r", "i");
            decyrptLetter.Add("q", "j");
            decyrptLetter.Add("p", "k");
            decyrptLetter.Add("o", "l");
            decyrptLetter.Add("n", "m");
            decyrptLetter.Add("m", "n");
            decyrptLetter.Add("l", "o");
            decyrptLetter.Add("k", "p");
            decyrptLetter.Add("j", "q");
            decyrptLetter.Add("i", "r");
            decyrptLetter.Add("h", "s");
            decyrptLetter.Add("g", "t");
            decyrptLetter.Add("f", "u");
            decyrptLetter.Add("e", "v");
            decyrptLetter.Add("d", "w");
            decyrptLetter.Add("c", "x");
            decyrptLetter.Add("b", "y");
            decyrptLetter.Add("a", "z");
            decyrptLetter.Add(" ", " ");
            decyrptLetter.Add(".", ".");


            //iterates through each char, converts to string runs through has and appends to stringbuilder
            StringBuilder sb = new StringBuilder();
            foreach (var item in lower)
            {
                var letter = item.ToString();
                string value = (string)decyrptLetter[letter];
                sb.Append(value);
            }
            return sb.ToString();
        }


        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            Console.WriteLine("Your encrypted message is");
            var encryptedMessage = (Encrypt(message));
            Console.Write(encryptedMessage);

            Console.WriteLine("\n\n");

            Console.WriteLine("Your decrypted message is");
            var decryptedMessage = (Decrypt(encryptedMessage));
            Console.WriteLine(decryptedMessage);

            Console.ReadLine();
        }
    }
}
