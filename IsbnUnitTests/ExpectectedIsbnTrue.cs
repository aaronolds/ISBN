using NUnit.Framework;
using System;
using System.Collections;

namespace IsbnUnitTests
{
    [TestFixture]
    public class ExpectectedIsbnTrue
    {
        /// <summary>
        /// Theses the are valid isbn10 test.
        /// </summary>
        /// <param name="s">The s.</param>
        [Test, TestCaseSource(typeof(IsbnGoodExamples), nameof(IsbnGoodExamples.TestCasesIsbn10))]
        public void TheseAreValidIsbn10Test(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.IsTrue(isbn.IsValid(s));
        }

        /// <summary>
        /// Theses the are valid isbn13 test.
        /// </summary>
        /// <param name="s">The s.</param>
        [Test, TestCaseSource(typeof(IsbnGoodExamples), nameof(IsbnGoodExamples.TestCasesIsbn13))]
        public void TheseAreValidIsbn13Test(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.IsTrue(isbn.IsValid(s));
        }


        public class IsbnGoodExamples
        {
            public static IEnumerable TestCasesIsbn10
            {
                get
                {
                    yield return new TestCaseData("0471958697");
                    yield return new TestCaseData("0 471 60695 2");
                    yield return new TestCaseData("0 - 470 - 84525 - 2");
                    yield return new TestCaseData("0 - 321 - 14653 - 0");
                    yield return new TestCaseData("0-9752298-0-X");
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
                    yield return new TestCaseData("0000000000000");
                }
            }
        }
    }
}
