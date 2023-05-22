using System;
using NUnit.Framework;

namespace LegCount
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1, 2, 3, Result=22)]
        [TestCase(1, 3, 5, Result=34)]
        [TestCase(2, 4, 6, Result=44)]
        
        public static int animals(int a, int b, int c)
        {
            Console.WriteLine($"Input: {a}, {b}, {c}");
            return Program.animals(a, b, c);
        }
    }
}

