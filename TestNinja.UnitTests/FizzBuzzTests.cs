using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var res = FizzBuzz.GetOutput(15);
            Assert.That(res, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var res = FizzBuzz.GetOutput(3);
            Assert.That(res, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            var res = FizzBuzz.GetOutput(5);
            Assert.That(res, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3And5_ReturnTheSameNumber()
        {
            var res = FizzBuzz.GetOutput(1);
            Assert.That(res, Is.EqualTo("1"));
        }
    }
}
