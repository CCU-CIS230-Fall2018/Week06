using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Week06
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool PhoneTester (string phoneNumber)
        {

            bool valid = false;

            if (phoneNumber.Length == 0 || phoneNumber == null)
            {
                throw new ArgumentNullException("Error: No phone number given.");
            }

            string myRegex = @"\d{3}-\d{3}-\d{4}";
            if (Regex.IsMatch(phoneNumber, myRegex))
            {
                valid = true;
            }           

            return valid;
        }
    }
}
