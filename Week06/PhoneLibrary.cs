using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week06
{
    public class PhoneLibrary
    {
        public string PhoneNumber { get; set; }

        public bool IsPhoneValid(string phone)
        {
            var r10 = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            var r7 = new Regex("([0-9]{3})[-.●]?([0-9]{4})$");
            try
            {
                if (string.IsNullOrEmpty(phone))
                {
                    return false;
                    throw new System.ArgumentException("Invalid input");
                }
                else if (r10.IsMatch(phone))
                {
                    return true;
                }
                else if (r7.IsMatch(phone)) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
                                
            }
            catch
            {
                throw new System.ArgumentException("The input given is not in the correct format, please try agin.");
            }
        }
    }
}
