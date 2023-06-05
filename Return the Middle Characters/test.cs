using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("test", Result="es")]
  [TestCase("testing", Result="t")]
  [TestCase("middle", Result="dd")]
  [TestCase("A", Result="A")]
  [TestCase("inhabitant", Result="bi")]
  [TestCase("brown", Result="o")]
  [TestCase("pawn", Result="aw")]
  [TestCase("cabinet", Result="i")]
  [TestCase("fresh", Result="e")]
  [TestCase("shorts", Result="or")]
    public static string FixedTest(string str)
    {
        return Program.GetMiddle(str);
    }
}
