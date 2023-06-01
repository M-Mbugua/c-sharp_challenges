using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("@edabit.com", Result=false)]
  [TestCase("@edabit", Result=false)]
  [TestCase("matt@edabit.com", Result=true)]
  [TestCase("", Result=false)]
  [TestCase("hello.gmail@com", Result=false)]
  [TestCase("bill.gates@microsoft.com", Result=true)]
  [TestCase("hello@email", Result=false)]
  [TestCase("%^%$#%^%", Result=false)]
  [TestCase("www.email.com", Result=false)]
  [TestCase("email", Result=false)]
    public static bool FixedTest(string str)
    {
        return Program.ValidateEmail(str);
    }
}
