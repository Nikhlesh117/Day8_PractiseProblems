using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class MatchString
    {
        public void Match()
        {
            Console.WriteLine("Enter a string to match:");
            string input = Console.ReadLine();

            Regex regex = new Regex("a[bc]{2,3}");
            bool isMatch = regex.IsMatch(input);

            if (isMatch)
            {
                Console.WriteLine("String matches the pattern.");
            }
            else
            {
                Console.WriteLine("String does not match the pattern.");
            }
        }
    }
}
