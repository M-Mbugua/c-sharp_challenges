using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
		[TestCase("I am Ne mo Nemo !", Result="I found Nemo at 5!")]
		[TestCase("N e m o is NEMO NeMo Nemo !", Result="I found Nemo at 8!")]
		[TestCase("I am Nemo's dad Nemo senior .", Result="I found Nemo at 5!")]
		[TestCase("Oh, hello !", Result="I can't find Nemo :(")]
		[TestCase("Is it Nemos, Nemona, Nemoor or Garfield?", Result="I can't find Nemo :(")]
		[TestCase("Nemo is a clown fish, he has white and orange stripes. Nemo , come back!", Result="I found Nemo at 1!")]
    public static string FixedTest(string str)
    {
				Console.WriteLine($"Input: {str}");
        return Program.FindNemo(str);
    }
}
