using System;
using NUnit.Framework;

namespace NextNum
{
    [TestFixture]
    public class Tests
    {
      [Test]
      [TestCase(15, Result=16)]
      [TestCase(-2 , Result=-1)]
      [TestCase(0, Result=1)]
      [TestCase(1000, Result=1001)]
      [TestCase(99, Result=100)]
      
        public static int FixedTest(int num)
        {
        Console.WriteLine($"Input: {num}");
            return Program.Addition(num);
        }
    }
}

