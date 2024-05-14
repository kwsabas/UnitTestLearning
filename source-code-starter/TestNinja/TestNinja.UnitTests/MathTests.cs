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
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgumnets() {
            var math = new Math();

            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumnetIsGreater_ReturnTheFirstArgument() {
            var math = new Math();

            var result = math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumnetIsGreater_ReturnTheSecondArgument() {
            var math = new Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {
            var math = new Math();

            var result = math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

    }
}
