using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Isbn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var isbn = new Isbn();
            var x = isbn.Isbn13Checksum("978817525766");
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}