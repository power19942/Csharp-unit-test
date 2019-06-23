using System.IO;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }
        
        [Test]
        [Ignore("ignore this test for now")]
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
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(2,2,2)]
        public void Max_FirstArgumentIsGreater_ReturnTheGreaterArgument(int a,int b,int expectedResult)
        {
            //arrange
//            var math = new Math();
            //act
            var res = _math.Max(a, b);
            //assert
            Assert.That(res,Is.EqualTo(expectedResult));
        }

    }
}