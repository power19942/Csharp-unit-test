using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrance
            var reservition = new Reservation();
            //act
            var res = reservition.CanBeCancelledBy(new User { IsAdmin = true});
            //assert
            Assert.AreEqual(res, true);
        }
    }
}
