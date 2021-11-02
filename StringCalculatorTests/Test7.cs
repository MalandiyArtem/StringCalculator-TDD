using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    class Test7
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Delimiters_can_be_of_any_length()
        {
            string input1 = "//[***]\n1***2***3";
            string input2 = "//[----]\n1----2----3";
            string input3 = "//[^^^^^]\n1^^^^^2^^^^^3";
            int expected = 6;

            int actual1 = calc.Add(input1);
            int actual2 = calc.Add(input2);
            int actual3 = calc.Add(input3);

            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }
    }
}
