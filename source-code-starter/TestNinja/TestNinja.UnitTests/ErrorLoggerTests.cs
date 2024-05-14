using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class ErrorLoggerTests {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumnetNullException(string error) {
            var logger = new ErrorLogger();

            /**
             * Using a Lambda Expression: Allows Assert.That to control the execution of the method and 
             * properly verify the exception type.
             * Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
             * 
             * Direct Method Call: Executes the method immediately, causing any exceptions to escape the 
             * control of Assert.That, making it ineffective in asserting the exception. Incorrect!!!
             * Assert.That(logger.Log(error), Throws.ArgumentNullException); // This will not work as expected
             */

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }


        [Test]
        public void Log_ValidError_RaisedErrorLoggedEvent() {
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            // This assertion verifies that the event was raised and the id was set to a new value
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
