using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class RegexHtmlTags
    {
        public void Tags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = "<.*?>";

            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match.Value);
            }
            
        }
    }
}
