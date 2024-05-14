using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class MathTests {
        private Math _math;

        // SetUp
        // Before the execution of each method
        [SetUp]
        public void SetUp() {
            _math = new Math();
        }

        // TearDown - 
        // After the execution of each method
        // More possible at Integration Tests where maybe we want to clear things at the database

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgumnets() {

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumnetIsGreater_ReturnTheFirstArgument() {

            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumnetIsGreater_ReturnTheSecondArgument() {

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {

            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

    }
}
