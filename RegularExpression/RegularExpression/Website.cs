using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class Website
    {
        public void ValidWebsite() 
        {
            string pattern = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";

            Console.WriteLine("Enter a website address:");
            string website = Console.ReadLine();

            bool isValid = Regex.IsMatch(website, pattern);
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
