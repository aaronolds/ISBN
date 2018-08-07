using NUnit.Framework;
using System;
using System.Collections;

namespace IsbnUnitTests
{
    [TestFixture]
    public class ExpectedExceptions
    {
        [Test]
        public void IsbnArgumnetNullExceptionTest()
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.That(() => isbn.IsValid(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
