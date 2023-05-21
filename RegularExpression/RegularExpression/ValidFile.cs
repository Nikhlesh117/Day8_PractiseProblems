using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class ValidFile
    {
        public void File()
        {
            string pattern = @"^[a-zA-Z0-9_-]+\.(jpg|jpeg|png|gif)$";

            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();

            bool isValid = Regex.IsMatch(fileName, pattern);
            if (isValid)
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
