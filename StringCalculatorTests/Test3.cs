using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    class Test3
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_handle_new_lines_and_comma_as_delimiter()
        {
            string input = "1,2,3\n4\n5,6,7\n8,9";
            int expected = 45;

            int actual = calc.Add(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
