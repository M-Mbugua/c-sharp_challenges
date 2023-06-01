using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("ratio", "orator", Result=true)]
  [TestCase("sparkling", "groups", Result=true)]
  [TestCase("mentee", "eminem", Result=true)]
	[TestCase("yahtzee", "easy", Result=true)]
  [TestCase("bush", "hubris", Result=false)]
  [TestCase("edit", "cheese", Result=false)]
	[TestCase("false", "true", Result=false)]
  [TestCase("cupid", "dionysus", Result=false)]
  [TestCase("futile", "elephant", Result=false)]
	[TestCase("", "", Result=true)]
  [TestCase("", "abc", Result=false)]
  [TestCase("a", "a", Result=true)]
	[TestCase("a", "b", Result=false)]
  [TestCase("&!", "!&", Result=true)]
	[TestCase("5556", "65", Result=true)]
    public static bool FixedTest(string str1, string str2)
    {
        return Program.IsStrangePair(str1, str2);
    }
}
