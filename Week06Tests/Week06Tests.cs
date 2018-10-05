using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week06;

namespace Week06Tests
{
    [TestClass]
    public class PlainNumberTesting
    {
        [TestMethod]
        public void Plain_Number_With_AreaCode_IsTrue()
        {
            // String for a 10 digit number (with area code).
            string testInput = "3034445555";           

            // Tests both numbers.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure both are true.
            Assert.IsTrue(testValue);
        }

        [TestMethod]
        public void Plain_Number_Without_AreaCode_IsTrue()
        {
            // String for a 7 digit number (without area code).
            string testInput = "4445555";

            // Tests the number.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure number passes as true.
            Assert.IsTrue(testValue);
        }
    }

    [TestClass]
    public class DashNumberTesting
    {
        [TestMethod]
        public void Dash_Number_With_AreaCode_IsTrue()
        {
            // String for a 10 digit number (with area code and dashes).
            string testInput = "303-444-5555";

            // Tests both numbers.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure both are true.
            Assert.IsTrue(testValue);
        }
        
        [TestMethod]
        public void Dash_Number_Without_AreaCode_IsTrue()
        {
            // String for a 7 digit number (without area code, with dashes).
            string testInput = "444-5555";

            // Tests the number.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure number passes as true.
            Assert.IsTrue(testValue);
        }
    }

    [TestClass]
    public class DotNumberTesting
    {
        [TestMethod]
        public void Dot_Number_With_AreaCode_IsTrue()
        {
            // String for a 10 digit number (with area code and dots).
            string testInput = "303.444.5555";

            // Tests both numbers.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure both are true.
            Assert.IsTrue(testValue);
        }

        [TestMethod]
        public void Dot_Number_Without_AreaCode_IsTrue()
        {
            // String for a 7 digit number (without area code, with dots).
            string testInput = "444.5555";

            // Tests the number.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure number passes as true.
            Assert.IsTrue(testValue);
        }
    }

    [TestClass]
    public class SpaceNumberTesting
    {
        [TestMethod]
        public void Space_Number_With_AreaCode_IsTrue()
        {
            // String for a 10 digit number (with area code and spaces).
            string testInput = "303 444 5555";

            // Tests both numbers.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure both are true.
            Assert.IsTrue(testValue);
        }

        [TestMethod]
        public void Space_Number_Without_AreaCode_IsTrue()
        {
            // String for a 7 digit number (without area code, with spaces).
            string testInput = "444 5555";

            // Tests the number.
            bool testValue = Program.TestUserInput(testInput);

            // Makes sure number passes as true.
            Assert.IsTrue(testValue);
        }
    }

    [TestClass]
    public class TestForNull
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Null_Exception_Thrown()
        {
            // Empty string
            string testInput = "";
            bool testValue = Program.TestUserInput(testInput);
        }
    }
}
   
