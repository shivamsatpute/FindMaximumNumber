using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestGeneric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(55, 3, 5, 55)]

        public void FindMaxNumberat1stPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        // TC1.2
     
        [TestMethod]
        [DataRow(55, 599, 5, 599)]
        public void FindMaxNumberat2ndPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        // TC1.3
        [TestMethod]
        [DataRow(55, 599, 5100, 5100)]
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
    }
}
