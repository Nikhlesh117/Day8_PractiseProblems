using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class CountOccurrences
    {
        public void Occurrences()
        {
            string input = "foxes are omnivorous mammals belonging to several generaof the family Canidae fox";
            string pattern = "fox(es)?";
            int occurrences = Regex.Matches(input, pattern).Count;
            Console.WriteLine("There are {0} occurrences.", occurrences);
            Regex regex = new Regex(pattern);

            

        }
    }
}
