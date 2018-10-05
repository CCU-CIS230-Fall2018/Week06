using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phone number, with or without the area code:");
            string userInput = Console.ReadLine();
 
            TestUserInput(userInput);
        }
        public static bool TestUserInput(string input)
        {
            string pattern = @"^(?:\(?)(\d{3})?(?:[\).\s-]?)(\d{3})(?:[-\.\s-]?)(\d{4})(?!\d)";
            Match matchResult = Regex.Match(input, pattern);

            if (input != "")
            {
                if (matchResult.Success)
                {
                    return true;
                }        
                else
                {
                    return false;
                }
            }
            else
            { 
                throw new System.ArgumentException("Input cannot be null");             
            }
        }
    }
}
