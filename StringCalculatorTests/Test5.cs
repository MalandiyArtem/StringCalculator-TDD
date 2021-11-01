using NUnit.Framework;
using StringCalculatorLibrary;
using System;

namespace StringCalculatorTests
{
    class Test5
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void Add_negative_multiply_numbers_throws_exception()
        {
            string input1 = "1,2,-3\n4\n-5,6,-7\n8,9";

            var ex = Assert.Throws<NegativesNotAllowedException>(() => calc.Add(input1));
            Assert.That(ex.Message, Is.EqualTo("-3 -5 -7"));
        }

        [Test]
        public void Add_negative_number_throws_exception()
        {
            string input = "1,2,3\n4\n5,6,-7\n8,9";
            Assert.Throws<NegativesNotAllowedException>(() => calc.Add(input));
        }
    }
}
