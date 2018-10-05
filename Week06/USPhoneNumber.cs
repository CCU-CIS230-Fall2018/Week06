using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week06
{
    public class USPhoneNumber
    {
        public string Digits { get; set; }
        public bool ValidTicker { get; set; }

        Regex rgx = new Regex(@"^(\([0-9]{3}\)|[0-9]{3})?[ -\.]?[0-9]{3}[ -\.]?[0-9]{4}$");

        public USPhoneNumber(string digits)
        {
            try
            {
                if (rgx.IsMatch(digits) == true)
                {
                    Digits = digits;
                    ValidTicker = true;
                }
            }
            catch
            {
                if (rgx.IsMatch(digits) == false)
                {
                    ValidTicker = false;
                }
                else if (digits == "" || digits == null)
                {
                    throw new System.ArgumentNullException("This arguement may not be null!");
                }
            }
        }
    }
}