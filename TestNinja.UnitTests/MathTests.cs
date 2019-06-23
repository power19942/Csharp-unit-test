using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        private Math _math;

        [SetUp]
        void Setup()
        {
            _math = new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgument()
        {
            //arrange
//            var math = new Math();
            //act
            var res = _math.Add(1, 2);
            //assert
            Assert.That(res,Is.EqualTo(3));
        }
        
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            //arrange
//            var math = new Math();
            //act
            var res = _math.Max(2, 1);
            //assert
            Assert.That(res,Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //arrange
//            var math = new Math();
            //act
            var res = _math.Max(1, 2);
            //assert
            Assert.That(res,Is.EqualTo(2));
        }
        
        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            //arrange
//            var math = new Math();
            //act
            var res = _math.Max(3, 3);
            //assert
            Assert.That(res,Is.EqualTo(3));
        }
    }
}