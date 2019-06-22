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
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //arrance
            var user = new User { IsAdmin = false };
            var reservition = new Reservation() { MadeBy = user};
            //act
            var res = reservition.CanBeCancelledBy(user);
            //assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //arrance
            var reservition = new Reservation() { MadeBy = new User() };
            //act
            var res = reservition.CanBeCancelledBy(new User());
            //assert
            Assert.IsFalse(res);
        }
    }
}
