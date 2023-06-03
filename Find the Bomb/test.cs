using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
[TestCase("There is a bomb.", Result =  "Duck!!!")]
[TestCase("Hey, did you find it?", Result =  "There is no bomb, relax.")]
[TestCase("Hey, did you think there is a bomb?", Result =  "Duck!!!")]
[TestCase("This goes boom!!!", Result =  "There is no bomb, relax.")]
[TestCase("Hey, did you find the BoMb?", Result =  "Duck!!!")]
[TestCase("Commotion in the third, a bomb is found!", Result =  "Duck!!!")]
    public static string FixedTest(string a)
    {
        return Program.Bomb(a);
    }
}
