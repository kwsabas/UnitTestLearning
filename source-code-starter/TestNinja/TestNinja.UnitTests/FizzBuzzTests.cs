using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class FizzBuzzTests {

        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz() {

            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Does.Not.Contain("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz() {

            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Does.Not.Contain("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz() {

            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Does.Contain("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3r5_ReturnTheSameNumberAsString() {

            var result = FizzBuzz.GetOutput(1);

            Assert.That(result,Is.EqualTo("1"));
        }

        [Test]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(1, ExpectedResult = "1")]
        public string GetOutput_TestCases_ReturnExpectedResults(int input) {
            return FizzBuzz.GetOutput(input);
        }
    }
}
