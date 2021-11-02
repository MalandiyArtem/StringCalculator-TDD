using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    class Test8
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_allows_multiply_delimiters()
        {
            string input1 = "//[*][%]\n1*2%3";
            string input2 = "//[#][-][@]\n1@2-3#4";
            int expected1 = 6;
            int expected2 = 10;

            int actual1 = calc.Add(input1);
            int actual2 = calc.Add(input2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
