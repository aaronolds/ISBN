using NUnit.Framework;
using System;
using System.Collections;

namespace IsbnUnitTests
{
    [TestFixture]
    public class ExpectectedIsbnTrue
    {
     
        [Test, TestCaseSource(typeof(Isbn13), "TestCasesIsbn13")]
        public void TheseAreValidIsbn13Test(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.IsTrue(isbn.IsValid(s));
        }


        public class Isbn13
        {
            public static IEnumerable TestCasesIsbn10
            {
                get
                {
                    yield return new TestCaseData("");
                }
            }

            public static IEnumerable TestCasesIsbn13
            {
                get
                {
                    yield return new TestCaseData("9780470059029");
                    yield return new TestCaseData("978 0 471 48648 0");
                    yield return new TestCaseData("978-0596809485");
                    yield return new TestCaseData("978-0-13-149505-0");
                    yield return new TestCaseData("978-0-262-13472-9");
                }
            }
        }
        //yield return new TestCaseData("0000000000000");  INTERESTING CASE

    }
}
