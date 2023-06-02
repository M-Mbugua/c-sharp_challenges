using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("1234", Result=true)]
  [TestCase("12345", Result=false)]
  [TestCase("a234", Result=false)]
  [TestCase("", Result=false)]
  [TestCase("%234", Result=false)]
  [TestCase("`234", Result=false)]
  [TestCase("@234", Result=false)]
  [TestCase("#234", Result=false)]
  [TestCase("$234", Result=false)]
  [TestCase("*234", Result=false)]
  [TestCase("5678", Result=true)]
  [TestCase("^234", Result=false)]
  [TestCase("(234", Result=false)]
  [TestCase(")234", Result=false)]
  [TestCase("123456", Result=true)]
  [TestCase("-234", Result=false)]
  [TestCase("_234", Result=false)]
  [TestCase("+234", Result=false)]
  [TestCase("=234", Result=false)]
  [TestCase("?234", Result=false)]
    public static bool FixedTest(string pin)
    {
        return Program.ValidatePIN(pin);
    }
}
