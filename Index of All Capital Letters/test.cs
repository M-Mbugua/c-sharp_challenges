using NUnit.Framework;
using System;
[TestFixture]
public class Tests
{
    [Test]
  [TestCase("eDaBiT", Result=new int[]{1, 3, 5})]
  [TestCase("eQuINoX", Result=new int[]{1, 3, 4, 6})]
  [TestCase("determine", Result=new int[]{})]
  [TestCase("STRIKE", Result=new int[]{0, 1, 2, 3, 4, 5})]
  [TestCase("sUn", Result=new int[]{1})]
  [TestCase("SpiDer", Result=new int[]{0, 3})]
  [TestCase("accOmpAnY", Result=new int[]{3, 6, 8})]
  [TestCase("@xCE#8S#i*$en", Result=new int[]{2, 3, 6})]
  [TestCase("1854036297", Result=new int[]{})]
  [TestCase("Fo?.arg~{86tUx=|OqZ!", Result=new int[]{0, 12, 16, 18})]
  public static int[] IndexTests(string str)
    {    
    	return Program.IndexOfCapitals(str);
    }
}
