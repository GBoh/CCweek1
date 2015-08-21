using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PreventXSS.Tests
{
    [TestClass]
    public class SanitizeTests
    {
        [TestMethod]
        public void TestTags()
        {
            // Arrange
            var security = new Security();

            //allowed tags
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

            string testing = @"<></> <> </> <img/> <script></script><span><div>text test</div></span> <a href=""></a>";
            string correct = @"&lt;&gt;&lt;/&gt; &lt;&gt; &lt;/&gt; &lt;img/&gt; &lt;script&gt;&lt;/script&gt;&lt;span&gt;&lt;div&gt;text test&lt;/div&gt;&lt;/span&gt; &lt;a href=""&gt;&lt;/a&gt;";


            // Act
            var result = security.SanitizeHTML(testing, whitelist);


            // Assert
            Assert.AreNotEqual(testing, result);
            Assert.AreEqual(correct, result);
        }
    }
}
