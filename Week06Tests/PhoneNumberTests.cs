using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week06;

namespace Week06Tests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void NinePass()
        {
            PhoneLibrary pn = new PhoneLibrary()
            {
                PhoneNumber="789-954-9428"
            };
            Assert.AreEqual(pn.IsPhoneValid(pn.PhoneNumber), true);
        }
        [TestMethod]
        public void SevenPass()
        {
            PhoneLibrary pn2 = new PhoneLibrary()
            {
                PhoneNumber = "9549428"
            };
            Assert.AreEqual(pn2.IsPhoneValid(pn2.PhoneNumber),true);
        }
        [TestMethod]
        //[ExpectedException(typeof(System.ArgumentException), "Invalid Input")]
        public void EmptyFail()
        {
            PhoneLibrary pn3 = new PhoneLibrary()
            {
                PhoneNumber = ""
            }; 
        }
        [TestMethod]
        public void NinePass2()
        {
            PhoneLibrary pn4 = new PhoneLibrary()
            {
                PhoneNumber = "789954-9428"
            };
            Assert.AreEqual(pn4.IsPhoneValid(pn4.PhoneNumber), true);
        }
        [TestMethod]
        public void NinePass3()
        {
            PhoneLibrary pn5 = new PhoneLibrary()
            {
                PhoneNumber = "7899549428"
            };
            Assert.AreEqual(pn5.IsPhoneValid(pn5.PhoneNumber), true);
        }
        [TestMethod]
        public void SevenPass2()
        {
            PhoneLibrary pn6 = new PhoneLibrary()
            {
                PhoneNumber = "954-9428"
            };
            Assert.AreEqual(pn6.IsPhoneValid(pn6.PhoneNumber), true);
        }
    }
}
