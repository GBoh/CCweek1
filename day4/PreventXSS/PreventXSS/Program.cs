using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreventXSS
{
    //public class Tag
    //{
    //  public string HtmlTag { get; set; }
    //}

    public class Security
    {

        public static string SanitizeHTML(string badString, List<string> whitelist)
        {
            //find position of < character and store it as startIndex
            //iterate through until a > character is found and store as lastIndex
            //store the characters between startIndex and lastIndex as a string.
            //check the string against the whitelist
            //if it isn't in the whitelist replace the char at startIndex with  &lt; 
            //and replace the char at lastIndext with &gt;
            //begin +1 of last index and run again until end of string.

            var startIndex = 0;
            var lastIndex = 0;
            var tagLength = 0;
            string tagToCheck = null;
            string cleanString;

            startIndex = badString.IndexOf("<");
            lastIndex = badString.IndexOf(">");

            while (startIndex >= 0)
            {
                //find the < character and the > character and stores their positions
                //also starts at +1 of it's position if it isn't the first time, through
                startIndex = badString.IndexOf("<", startIndex);
                lastIndex = badString.IndexOf(">", lastIndex);

                //gets the length of the tag by substracting lastIndex from startIndex and adding 1
                tagLength = ((lastIndex - startIndex) + 1);

                //breaks out of the while loop to avoid infinite loop
                if (startIndex == -1)
                {
                    break;
                }

                //check to make sure that startIndex is not -1 so that substring will start
                //stores the tag based on the startIndex and the tagLength
                if (startIndex >= 0)
                {
                    tagToCheck = badString.Substring(startIndex, tagLength);
                }

                //adds one to the startIndex and lastIndex
                startIndex++;
                lastIndex++;

                if (!whitelist.Contains(tagToCheck))
                {
                    Console.WriteLine("{0} is a evil tag, replacing soon", tagToCheck);
                }
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testHTML = @"<b>hello</b><script>evil</script>";

            var whitelist = new List<string>();
            whitelist.Add("<b>");
            whitelist.Add("</b>");
            whitelist.Add("<p>");
            whitelist.Add("</p>");
            whitelist.Add("<table>");
            whitelist.Add("</table>");
            whitelist.Add("<ul>");
            whitelist.Add("</ul>");
            whitelist.Add("<ol>");
            whitelist.Add("</ol>");
            whitelist.Add("<li>");
            whitelist.Add("</li>");
            whitelist.Add("<tr>");
            whitelist.Add("</tr>");
            whitelist.Add("<td>");
            whitelist.Add("</td>");
            whitelist.Add("<th>");
            whitelist.Add("</th>");
            whitelist.Add("<h1>");
            whitelist.Add("</h1>");
            whitelist.Add("<h2>");
            whitelist.Add("</h2>");
            whitelist.Add("<h3>");
            whitelist.Add("</h3>");
            whitelist.Add("<h4>");
            whitelist.Add("</h4>");
            whitelist.Add("<h5>");
            whitelist.Add("</h5>");
            whitelist.Add("<h6>");
            whitelist.Add("</h6>");

            if (whitelist.Contains("<b>"))
            {

            }
            var sanitizedString = Security.SanitizeHTML(testHTML, whitelist);
            //Console.WriteLine(sanitizedString);
            Console.ReadLine();
        }
    }
}
