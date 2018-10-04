using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using Week06;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        // Valid format - 000-000-0000.
        [TestMethod]
        public void PhoneTestCorrect()
        {
            Phone workingPhone = new Phone();
            workingPhone.PhoneNumber = "800-392-5820";
            Assert.IsTrue(Program.PhoneTester(workingPhone.PhoneNumber.ToString()));
        }

        [TestMethod]
        public void PhoneTestIncorrect()
        {
            Phone wrongNumber = new Phone();
            wrongNumber.PhoneNumber = "200-555-392";
            Assert.IsFalse(Program.PhoneTester(wrongNumber.PhoneNumber.ToString()));
        }

        [TestMethod]
        public void SecondPhoneTestIncorrect()
        {
            Phone secondBrokenPhone = new Phone();
            secondBrokenPhone.PhoneNumber = "797 232 4640";
            Assert.IsFalse(Program.PhoneTester(secondBrokenPhone.PhoneNumber.ToString()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PhoneTestError()
        {
            Phone emptyNumber = new Phone();
            emptyNumber.PhoneNumber = "";
            bool works = Program.PhoneTester(emptyNumber.PhoneNumber.ToString());
        }
    }
}
