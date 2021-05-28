using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestGeneric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(33, 11, 22, 33)]

        public void FindMaxNumberat1stPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        // TC1.2
     
        [TestMethod]
        [DataRow(11, 33, 22, 33)]
        public void FindMaxNumberat2ndPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        // TC1.3
        [TestMethod]
        [DataRow(11, 22, 33, 33)]
        public void FindMaxNumberat3rdPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(33.33, 22.22, 11.11, 33.33)]
        public void FindMaxFloatNumerat1stPosition(double num1 , double num2, double num3, double expectd)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();
            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);
            Assert.AreEqual(expectd, actual);
        }
        [TestMethod]
        [DataRow(11.11, 33.33, 22.22, 33.33)]
        public void FindMaxFloatNumerat2stPosition(double num1, double num2, double num3, double expectd)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();
            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);
            Assert.AreEqual(expectd, actual);
        }
        [TestMethod]
        [DataRow(11.11, 22.22, 33.33, 33.33)]
        public void FindMaxFloatNumerat3stPosition(double num1, double num2, double num3, double expectd)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();
            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);
            Assert.AreEqual(expectd, actual);
        }

        [TestMethod]
        [DataRow("Peach", "Apple", "Banana", "Peach")]
        public void FindMaxStringNumberat1stPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Apple", "Peach", "Banana", "Peach")]
        public void FindMaxStringNumberat2ndPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        [DataRow("Apple", "Banana", "Peach", "Peach")]
        public void FindMaxStringNumberat3rdPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }
    }
}
