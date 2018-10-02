using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week06;

namespace InputValidationTests
{
	[TestClass]
	public class PhoneNumberValidation
	{
		InputValidation validator = new InputValidation();

		[TestMethod]
		public void Standard10Digit()
		{
			string test1 = "(505) 944-6114";
			string test2 = "(505)944-6114";
			Assert.IsTrue(validator.phoneNumberString(test1));
			Assert.IsTrue(validator.phoneNumberString(test2));
		}

		[TestMethod]
		public void NoHyphen10Digit()
		{
			string test1 = "5059446114";
			Assert.IsTrue(validator.phoneNumberString(test1));
		}

		[TestMethod]
		public void Alternate10Digit()
		{
			string test1 = "505-944-6114";
			Assert.IsTrue(validator.phoneNumberString(test1));
		}

		[TestMethod]
		public void InvalidNumber()
		{
			string test1 = "505944-6114";
			Trace.Write(validator.phoneNumberString(test1));
			Assert.IsFalse(validator.phoneNumberString(test1));
		}

		[TestMethod]
		public void Standard7Digit()
		{
			string test1 = "944-6114";
			string test2 = "9446114";
			Assert.IsTrue(validator.phoneNumberString(test1));
			Assert.IsTrue(validator.phoneNumberString(test2));
		}

		[TestMethod]
		[ExpectedException(typeof(System.ArgumentNullException))]
		public void NullNumber()
		{
			string test1 = "";
			Assert.IsTrue(validator.phoneNumberString(test1));
		}
	}


	
}
