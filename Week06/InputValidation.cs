using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week06
{
	public class InputValidation
	{
		public bool phoneNumberString(string phoneNumber)
		{
			bool valid = false;
			string pattern10digitStandard = @"^[(]\d{3}[)]\s?\d{3}-\d{4}$";
			string patternalt10Digit = @"^\d{3}-\d{3}-\d{4}$";
			string patternNoHyphen = @"^\d{10}$";
			string pattern7Digit = @"^\d{3}-?\d{4}$";
			// string pattern7DigitAlt = @"^\d{7}$";

			if (Regex.IsMatch(phoneNumber, pattern10digitStandard))
				valid = true;
			else if (Regex.IsMatch(phoneNumber, patternalt10Digit))
				valid = true;
			else if (Regex.IsMatch(phoneNumber, patternNoHyphen))
				valid = true;
			else if (Regex.IsMatch(phoneNumber, pattern7Digit))
				valid = true;
			else if (phoneNumber == "" || phoneNumber == null)
					throw new ArgumentNullException("Phone Number");
			return valid;
		}

	}
}			
