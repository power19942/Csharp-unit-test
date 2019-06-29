using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);
            
            Assert.That(result,Is.TypeOf<NotFound>());
            Assert.That(result,Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdNotZero_ReturnOk()
        {
            var result = _customerController.GetCustomer(1);
            
            Assert.That(result,Is.TypeOf<Ok>());
        }
        
    }
}