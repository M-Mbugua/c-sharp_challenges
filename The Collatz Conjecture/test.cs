using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(2, Result=1)]
		[TestCase(3, Result=7)]
		[TestCase(10, Result=6)]
		[TestCase(6, Result=8)]
		[TestCase(345, Result=125)]
		[TestCase(72, Result=22)]
    public static int FixedTest(int num)
    {
				Console.WriteLine($"Input: {num}");
        return Program.collatz(num);
    }
}
