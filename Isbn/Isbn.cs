using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Isbn
{
    public class IsbnValidator
    {
        private const float MIN_NORMAL = 0.000f;

        /// <summary>
        ///     Returns true if ... is valid.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns>
        ///     <c>true</c> if the specified isbn is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid(string isbn)
        {
            ArgumentNotNullOrEmptyString(isbn, nameof(isbn));
            var unformatedIsbn = RemoveNonIntegers(isbn);
            if (unformatedIsbn.Length == 10) return IsValidIsbn10(unformatedIsbn, out _);

            return unformatedIsbn.Length == 13 && IsValidIsbn13(unformatedIsbn, out _);
        }

        /// <summary>
        ///     Determines whether [is valid isbn10] [the specified isbn].
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <param name="correctIsbn">The correct isbn.</param>
        /// <returns>
        ///     <c>true</c> if [is valid isbn10] [the specified isbn]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        private static bool IsValidIsbn10(string isbn, out string correctIsbn)
        {
            correctIsbn = isbn.Substring(0, 9) + Isbn10Checksum(isbn);
            return correctIsbn == isbn;
        }

        /// <summary>
        ///     Isbn10s the checksum.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns></returns>
        private static string Isbn10Checksum(string isbn)
        {
            var sum = 0;
            for (var i = 0; i < 9; i++)
            {
                sum += (10 - i) * int.Parse(isbn[i].ToString());
            }

            var rem = sum % 11;

            if (Math.Abs(rem) <= MIN_NORMAL)
            {
                return "0";
            }

            return rem == 1 ? "X" : (11 - rem).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     Determines whether [is valid isbn13] [the specified isbn].
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <param name="correctIsbn">The correct isbn.</param>
        /// <returns>
        ///     <c>true</c> if [is valid isbn13] [the specified isbn]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsValidIsbn13(string isbn, out string correctIsbn)
        {
            correctIsbn = isbn.Substring(0, 12) + Isbn13Checksum(isbn);
            return correctIsbn == isbn;
        }

        /// <summary>
        ///     Isbn13s the checksum.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns></returns>
        private static string Isbn13Checksum(string isbn)
        {
            float sum = 0;
            for (var i = 0; i < 12; i++)
            {
                sum += (i % 2 == 0 ? 1 : 3) * int.Parse(isbn[i].ToString());
            }

            var rem = sum % 10;

            return Math.Abs(rem) <= MIN_NORMAL ? "0" : (10 - rem).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     Removes the non integers.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns></returns>
        private static string RemoveNonIntegers(string isbn)
        {
            return Regex.Replace(isbn, "[^0-9X]", "");
        }

        /// <summary>
        ///     Arguments the not null.
        /// </summary>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        private static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null) throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        ///     Arguments the not null or empty string.
        /// </summary>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        private static void ArgumentNotNullOrEmptyString(string argumentValue, string argumentName)
        {
            ArgumentNotNull(argumentValue, argumentName);
            if (argumentValue.Length == 0) throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "String Cannot Be Empty"));
        }
    }
}