using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(fr=> fr.Read("video.txt")).Returns("");
            var service = new VideoService(fileReader.Object);
            var res = service.ReadVideoTitle();
            Assert.That(res, Does.Contain("error").IgnoreCase);
        }
    }
}
