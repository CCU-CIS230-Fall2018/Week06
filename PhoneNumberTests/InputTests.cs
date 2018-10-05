using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using Week06;
using System.Collections.Generic;

namespace PhoneNumberTests
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void DigitsOnlyWithAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("3092363810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        public void DigitsOnlyWithoutAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("2363810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        public void DigitsAndDashesWithAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("309-236-3810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        public void DigitsAreTooShort_ReturnsFalse()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("309381");
            Assert.AreEqual(TestNumber.ValidTicker, false);
        }

        [TestMethod]
        public void DigitsAreTooLong_ReturnsFalse()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("867530999999");
            Assert.AreEqual(TestNumber.ValidTicker, false);
        }

        [TestMethod]
        public void RandomFormat_ReturnsFalse()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("12-3(405)0256");
            Assert.AreEqual(TestNumber.ValidTicker, false);
        }

        [TestMethod]
        public void DigitsAndParenthesisWithAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("(309)2363810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        public void DigitsAndDashesWithParenthesisAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("(309)-236-3810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        public void DigitsAndDashesWithoutAreaCode_ReturnsTrue()
        {
            USPhoneNumber TestNumber = new USPhoneNumber("236-3810");
            Assert.AreEqual(TestNumber.ValidTicker, true);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void NullNotAcceptedArguement()
        {
            USPhoneNumber TestNumber = new USPhoneNumber(null);
        }
    }
}
