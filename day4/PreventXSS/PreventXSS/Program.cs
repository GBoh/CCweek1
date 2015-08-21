using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreventXSS
{
    class Tag
    {
      public string HtmlTag { get; set; }
    }

    public class Security
    {
       
        public static string SanitizeHTML(string htmlTag, List<Tag> whitelist)
        {
            //check string elements against whitelist
            //iterate through each char and check to see if it matches one of the whitelist tags
            //if it doesn't replace the < with &lt; and > with &gt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testHTML = @"<b>hello</b><script>evil</script>";

            var whitelist = new List<Tag>();
            whitelist.Add(new Tag { HtmlTag = "<b>" });
            whitelist.Add(new Tag { HtmlTag = "</b>" });
            whitelist.Add(new Tag { HtmlTag = "<p>" });
            whitelist.Add(new Tag { HtmlTag = "</p>" });
            whitelist.Add(new Tag { HtmlTag = "<table>" });
            whitelist.Add(new Tag { HtmlTag = "</table>" });
            whitelist.Add(new Tag { HtmlTag = "<ul>" });
            whitelist.Add(new Tag { HtmlTag = "</ul>" });
            whitelist.Add(new Tag { HtmlTag = "<ol>" });
            whitelist.Add(new Tag { HtmlTag = "</ol>" });
            whitelist.Add(new Tag { HtmlTag = "<li>" });
            whitelist.Add(new Tag { HtmlTag = "</li>" });
            whitelist.Add(new Tag { HtmlTag = "<tr>" });
            whitelist.Add(new Tag { HtmlTag = "</tr>" });
            whitelist.Add(new Tag { HtmlTag = "<td>" });
            whitelist.Add(new Tag { HtmlTag = "</td>" });
            whitelist.Add(new Tag { HtmlTag = "<th>" });
            whitelist.Add(new Tag { HtmlTag = "</th>" });
            whitelist.Add(new Tag { HtmlTag = "<h1>" });
            whitelist.Add(new Tag { HtmlTag = "</h1>" });
            whitelist.Add(new Tag { HtmlTag = "<h2>" });
            whitelist.Add(new Tag { HtmlTag = "</h2>" });
            whitelist.Add(new Tag { HtmlTag = "<h3>" });
            whitelist.Add(new Tag { HtmlTag = "</h3>" });
            whitelist.Add(new Tag { HtmlTag = "<h4>" });
            whitelist.Add(new Tag { HtmlTag = "</h4>" });
            whitelist.Add(new Tag { HtmlTag = "<h5>" });
            whitelist.Add(new Tag { HtmlTag = "</h5>" });
            whitelist.Add(new Tag { HtmlTag = "<h6>" });
            whitelist.Add(new Tag { HtmlTag = "</h6>" });

            var sanitizedString = Security.SanitizeHTML(testHTML, whitelist);
            Console.WriteLine(sanitizedString);
        }
    }
}
