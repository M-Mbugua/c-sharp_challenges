using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(7, 5, Result = new int[] { 7, 14, 21, 28, 35 })]
	[TestCase(12, 10, Result = new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
	[TestCase(17, 7, Result = new int[] { 17, 34, 51, 68, 85, 102, 119 })]
	[TestCase(630, 14, Result = new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 })]
	[TestCase(140, 3, Result = new int[] { 140, 280, 420 })]
	[TestCase(7, 8, Result = new int[] { 7, 14, 21, 28, 35, 42, 49, 56 })]
	[TestCase(11, 21, Result = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 })]
	public static int[] FixedTest(int num, int len) => Program.ArrayOfMultiples(num, len);
}
