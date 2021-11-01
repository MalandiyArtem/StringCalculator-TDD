using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_empty_returned_0()
        {
            // Arrange
            StringCalculator calc = new StringCalculator();
            string input = "";
            int expected = 0;

            // Act
            int actual = calc.Add(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}