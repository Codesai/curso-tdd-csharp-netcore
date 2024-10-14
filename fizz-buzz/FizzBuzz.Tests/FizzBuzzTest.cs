using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Return_Number()
        {
            var result = _fizzBuzz.GetElements();

            Assert.That(GetResultElement(1, result), Is.EqualTo("1"));
            Assert.That(GetResultElement(98, result), Is.EqualTo("98"));
        }

        [Test]
        public void Return_100_Elements_List()
        {
            var result = _fizzBuzz.GetElements();

            Assert.That(result.Count, Is.EqualTo(100));
        }

        [Test]
        public void Return_Fizz_WhenIsDivisibleByThree()
        {
            var result = _fizzBuzz.GetElements();

            Assert.That(GetResultElement(3, result), Is.EqualTo("Fizz"));
            Assert.That(GetResultElement(33, result), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Return_Buzz_WhenIsDivisibleByFive()
        {
            var result = _fizzBuzz.GetElements();

            Assert.That(GetResultElement(5, result), Is.EqualTo("Buzz"));
            Assert.That(GetResultElement(25, result), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Return_FizzBuzz_WhenIsDivisibleBy_ThreeAndFive()
        {
            var result = _fizzBuzz.GetElements();

            Assert.That(GetResultElement(15, result), Is.EqualTo("FizzBuzz"));
            Assert.That(GetResultElement(60, result), Is.EqualTo("FizzBuzz"));
        }

        private static string GetResultElement(int number, IList<string> elements)
        {
            return elements[number - 1];
        }

    }
}