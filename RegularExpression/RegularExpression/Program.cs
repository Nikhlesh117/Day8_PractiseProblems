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
            MatchString matchString = new MatchString();
            matchString.Match();
            Console.ReadLine();
        }
    }
}
