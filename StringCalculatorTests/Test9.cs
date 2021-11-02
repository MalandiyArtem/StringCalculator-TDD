using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    class Test9
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Multiply_delimiters_can_be_of_any_length()
        {
            string input1 = "//[***][%%]\n1***2%%3";
            string input2 = "//[####][--][@]\n1@2--3####4";
            int expected1 = 6;
            int expected2 = 10;

            int actual1 = calc.Add(input1);
            int actual2 = calc.Add(input2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
