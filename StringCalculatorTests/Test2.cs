using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    class Test2
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_handle_an_unknown_amount_of_numbers()
        {
            string input = "1,2,3,4,5,6,7,8,9";
            int expected = 45;

            int actual = calc.Add(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
