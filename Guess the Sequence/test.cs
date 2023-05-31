using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(1, Result=90)]
	[TestCase(2, Result=240)]
	[TestCase(3, Result=450)]
	[TestCase(4, Result=720)]
	[TestCase(5, Result=1050)]
	[TestCase(6, Result=1440)]
	[TestCase(7, Result=1890)]
	[TestCase(8, Result=2400)]
	[TestCase(9, Result=2970)]
	[TestCase(10, Result=3600)]
	[TestCase(11, Result=4290)]
	[TestCase(12, Result=5040)]
	[TestCase(13, Result=5850)]
	[TestCase(14, Result=6720)]
	[TestCase(15, Result=7650)]
	[TestCase(16, Result=8640)]
	[TestCase(17, Result=9690)]
	[TestCase(18, Result=10800)]
	[TestCase(19, Result=11970)]
	[TestCase(20, Result=13200)]
	
	public static int GuessSequence(int num)
	{
		Console.WriteLine($"Input: {num}");
		return Program.GuessSequence(num);
	}
}

// Author: Mubashir Hassan