﻿using NUnit.Framework;
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
        //[Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArgumnets() {

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult) {

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit() {
            var result = _math.GetOddNumbers(5);

            // Possible checks
            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            //  Assert.That(result, Does.Contain(1));
            //  Assert.That(result, Does.Contain(3));
            //  Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5}));

            // Other useful 
            //  Assert.That(result, Is.Ordered);
            //  Assert.That(result, Is.Unique);
        }
    }
}
