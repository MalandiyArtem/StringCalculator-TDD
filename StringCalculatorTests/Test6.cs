using NUnit.Framework;
using StringCalculatorLibrary; 

namespace StringCalculatorTests
{
    class Test6
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_number_more_than_1000_ignored()
        {
            string input = "1,2,3\n4\n5,6,1004,1343,7\n8,9";
            int expected = 45;

            int actual = calc.Add(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
