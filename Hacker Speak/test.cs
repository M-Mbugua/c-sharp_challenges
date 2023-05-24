using NUnit.Framework;

namespace HackerSpeak 
{
    [TestFixture]
    public class Tests
        {
        [Test]
        [TestCase("javascript is cool", Result="j4v45cr1pt 15 c00l")]
        [TestCase("become a coder", Result="b3c0m3 4 c0d3r")]
        [TestCase("hi there", Result="h1 th3r3")]
        [TestCase("programming is fun", Result="pr0gr4mm1ng 15 fun")]
        [TestCase("keep on practicing", Result="k33p 0n pr4ct1c1ng")]
            public static string FixedTest(string str)
            {
                return Program.HackerSpeak(str);
            }
        }
}
