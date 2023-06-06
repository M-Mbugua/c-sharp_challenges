using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("4556364607935616", Result="############5616")]
  [TestCase("64607935616", Result="#######5616")]
  [TestCase("1", Result="1")]
  [TestCase("", Result="")]
  [TestCase("tBy>L/cMe+?<j:6n;C~H", Result="################;C~H")]
  [TestCase("12", Result="12")]
  [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", Result="##########################j7vJ")]
  [TestCase("123", Result="123")]
  [TestCase(")E$aCU=e\"_", Result="######=e\"_")]
  [TestCase("2673951408", Result="######1408")]
  [TestCase("1234", Result="1234")]
  
    public static string FixedTest(string str)
    {
        return Program.Maskify(str);
    }
}
