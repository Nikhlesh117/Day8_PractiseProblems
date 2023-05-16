using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class LettersUnderscore
    {
        public void Letters() 
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Regex regex = new Regex(@"[a-z]+(_[a-z])");
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
