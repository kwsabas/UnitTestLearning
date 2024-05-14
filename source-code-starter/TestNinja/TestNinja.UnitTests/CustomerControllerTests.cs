using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class CustomerControllerTests {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound() {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            // TypeOf ensures that is exactly that specific type
            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // InstanceOf is used if we want to check also class derivatives
            // NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk() {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
