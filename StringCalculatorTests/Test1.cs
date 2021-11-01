using NUnit.Framework;
using StringCalculatorLibrary;

namespace StringCalculatorTests
{
    public class Test1
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_empty_returned_0()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act
            int actual = calc.Add(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_5_returned_5()
        {
            // Arrange
            string input = "5";
            int expected = 5;

            // Act
            int actual = calc.Add(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_7and3_returned_10()
        {
            // Arrange
            string input = "7,3";
            int expected = 10;

            // Act
            int actual = calc.Add(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}