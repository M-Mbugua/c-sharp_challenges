using System;
using NUnit.Framework;

namespace CountVowels
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Celebration", Result=5)]
        [TestCase("Palm", Result=1)]
        [TestCase("Prediction", Result=4)]
        [TestCase("Suite", Result=3)]
        [TestCase("Quote", Result=3)]
        [TestCase("Portrait", Result=3)]
        [TestCase("Steam", Result=2)]
        [TestCase("Tape", Result=2)]
        [TestCase("Nightmare", Result=3)]
        [TestCase("Convention", Result=4)]
            public static int FixedTest(string str)
            {
                return Program.CountVowels(str);
            }
    }

}
