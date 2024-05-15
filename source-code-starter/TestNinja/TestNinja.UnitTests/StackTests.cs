using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {

    [TestFixture]
    public class StackTests {

        private Fundamentals.Stack<object> _stack;

        [SetUp]
        public void SetUp() {
            _stack = new Fundamentals.Stack<object>();
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNullException() {

            object item = null;
            Assert.That(() => _stack.Push(item), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_ValidArg_PushTheObjectToTheStack() {
            var oldStackCount = _stack.Count;

            var item = new object();
            _stack.Push(item);

            var newStackCount = _stack.Count;

            Assert.That(newStackCount, Is.EqualTo(oldStackCount + 1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero() {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException() {

            while(_stack.Count > 0) {
                _stack.Pop();
            }

            Assert.That(() => _stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WhenCalledOnNonEmptyStack_ReturnTopObject() {
            // Arrange
            var item = new object();
            _stack.Push(item);
            var oldStackCount = _stack.Count;

            // Act
            var result = _stack.Pop();

            var newStackCount = _stack.Count;
            // Assert
            Assert.That(result, Is.EqualTo(item));
            Assert.That(newStackCount, Is.EqualTo(oldStackCount - 1));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException() {

            while (_stack.Count > 0) {
                _stack.Pop();
            }

            Assert.That(() => _stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        public void Peek_WhenCalledOnNonEmptyStack_ReturnTopObject() {
            // Arrange
            var item = new object();
            _stack.Push(item);

            // Act
            var result = _stack.Peek();

            // Assert
            Assert.That(result, Is.EqualTo(item));
        }
    }
}
