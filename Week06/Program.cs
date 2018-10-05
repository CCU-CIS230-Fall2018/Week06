using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phone number.");
            string telNo = Console.ReadLine();

            if (Regex.Match(telNo, @"^(\+[0-9])$").Success)
            {
                Console.WriteLine("correctly entered");
            }

            else
            {
                Console.WriteLine("incorrectly entered");
            }

            Console.ReadLine();
        }
    }
}
