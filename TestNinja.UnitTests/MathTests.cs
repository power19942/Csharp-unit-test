using System.IO;
using System.Linq;
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

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var res = _math.GetOddNumbers(5);
            Assert.That(res,Is.Not.Empty);
            Assert.That(res.Count(),Is.EqualTo(3));
            Assert.That(res,Does.Contain(1));
            Assert.That(res,Does.Contain(5));
            Assert.That(res,Does.Contain(3));
            
            Assert.That(res,Is.EquivalentTo(new[]{1,3,5}));
            Assert.That(res,Is.Ordered);
            Assert.That(res,Is.Unique);
        }

    }
}