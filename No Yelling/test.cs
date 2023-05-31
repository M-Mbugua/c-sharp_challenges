using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
		[Test]
		[TestCase("What went wrong?????????", Result="What went wrong?")]
		[TestCase("Oh my goodness!!!", Result="Oh my goodness!")]
		[TestCase("WHAT!", Result="WHAT!")]
		[TestCase("WHAT?", Result="WHAT?")]
		[TestCase("Oh my goodness!", Result="Oh my goodness!")]
		[TestCase("I just cannot believe it.", Result="I just cannot believe it.")]
		[TestCase("I just!!! can!!! not!!! believe!!! it!!!", Result="I just!!! can!!! not!!! believe!!! it!")]
		[TestCase("That's a ton!! of cheese!!!!", Result="That's a ton!! of cheese!")]
    public static string NoYelling(string phrase) 
    {
				Console.WriteLine($"Input: {phrase}");
        return Program.NoYelling(phrase);
    }
}

