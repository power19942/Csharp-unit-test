using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservition = new Reservation();
            //act
            var res = reservition.CanBeCancelledBy(new User { IsAdmin = true});
            //assert
            Assert.That(res, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //arrange
            var user = new User { IsAdmin = false };
            var reservition = new Reservation() { MadeBy = user};
            //act
            var res = reservition.CanBeCancelledBy(user);
            //assert
            Assert.That(res,Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //arrange
            var reservition = new Reservation() { MadeBy = new User() };
            //act
            var res = reservition.CanBeCancelledBy(new User());
            //assert
            Assert.That(res,Is.False);
        }
    }
}
