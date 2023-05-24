using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(17, 8, Result=24)]
	[TestCase(98, 3, Result=99)]
	[TestCase(14, 11, Result=22)]
	[TestCase(11, 8, Result=16)]
	[TestCase(450, 36, Result=468)]
	[TestCase(1019, 13, Result=1027)]
	
	public static int DivisibleByB(int a, int b)
	{
		Console.WriteLine($"Input: {a} {b}");
		return Program.DivisibleByB(a, b);
	}
}
