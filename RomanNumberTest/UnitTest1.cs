using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualWork3;

namespace RomanNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            var number = new RomanNumber(1);
            Assert.AreEqual("I", number.ToString());
        }

        [TestMethod]
        public void TestClone()
        {
            var number = new RomanNumber(1);
            RomanNumber number2 = (RomanNumber)number.Clone();
            Assert.IsTrue(number.CompareTo(number2) == 0);
        }

        [TestMethod]
        public void TestAdd1()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(24);
            var expected = new RomanNumber(10 + 24);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestAdd2()
        {
            var n1 = new RomanNumber(1);
            RomanNumber? n2 = null;
            var res = n1 + n2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestSub1()
        {
            var n1 = new RomanNumber(1);
            var n2 = new RomanNumber(24);
            var res = n1 - n2;
        }

        [TestMethod]
        public void TestSub2()
        {
            var n1 = new RomanNumber(24);
            var n2 = new RomanNumber(1);
            Assert.IsTrue(
                (n1 - n2).CompareTo(new RomanNumber(24 - 1)) == 0
            );
        }

        [TestMethod]
        public void TestMul1()
        {
            var n1 = new RomanNumber(24);
            var n2 = new RomanNumber(1);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(24 * 1)) == 0
            );
        }

        [TestMethod]
        public void TestMul2()
        {
            var n1 = new RomanNumber(123);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(123 * 10)) == 0
            );
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestDiv1()
        {
            var n1 = new RomanNumber(123);
            var n2 = new RomanNumber(11);
            var res = n1 / n2;
        }

        [TestMethod]
        public void TestDiv2()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(5);
            Assert.IsTrue((n1 / n2).CompareTo(new RomanNumber(10 / 5)) == 0);
        }

        [TestMethod]
        public void TestCompare1()
        {
            var n1 = new RomanNumber(100);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
        }

        [TestMethod]
        public void TestCompare2()
        {
            var n1 = new RomanNumber(99);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == -1);
        }

        [TestMethod]
        public void TestCompare3()
        {
            var n1 = new RomanNumber(101);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == 1);
        }
    }
}