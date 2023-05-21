using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //MatchString matchString = new MatchString();
            //matchString.Match();

            //LettersUnderscore lettersUnderscore = new LettersUnderscore();
            //lettersUnderscore.Letters();

            //RegexHtmlTags regexHtml = new RegexHtmlTags();
            //regexHtml.Tags();

            //CountOccurrences occurrences = new CountOccurrences();
            //occurrences.Occurrences();

            ValidFile valid = new ValidFile();
            valid.File();

            Console.ReadLine();
        }
    }
}
