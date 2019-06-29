using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {

        [Test]
        [Ignore("ignore fore now")]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abs");
            
            //specific assertion
            Assert.That(result,Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            //general assertion
            Assert.That(result,Does.StartWith("<strong>"));
            Assert.That(result,Does.EndWith("</strong>"));
            Assert.That(result,Does.Contain("abc"));
        }
    }
}