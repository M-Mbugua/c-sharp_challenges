using NUnit.Framework;

    [TestFixture]
    public class FindNeedleTest
    {
        [Test]
        public void GenericTests()
        {
            double[] haystack_1 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            double[] haystack_2 = new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            double[] haystack_3 = new double[] { 91, -4, 80, -73, -28 };
            double[] haystack_4 = new double[] { };
            double[] haystack_5 = new double[] { 69, 100, 28, 47, 53, -61, -24 };
        	  double[] haystack_6 = new double[] { 5, 7, 9, -3, -7, 61, -24 };
          	double[] haystack_7 = new double[] { 0 };
          	double[] haystack_8 = new double[] { 98, 51, -19, -97 };
          	double[] haystack_9 = new double[] { -42, 3, -51, -64, 69, 77, -20, -5, 68, -76 };
						double[] haystack_10 = new double[] { 0, 0, 0 };
          
            Assert.AreEqual(new int[] { 10, -65 }, Program.CountPosSumNeg(haystack_1));
            Assert.AreEqual(new int[] { 7, -252 }, Program.CountPosSumNeg(haystack_2));
            Assert.AreEqual(new int[] { 2, -105 }, Program.CountPosSumNeg(haystack_3));
            Assert.AreEqual(new int[] {  }, Program.CountPosSumNeg(haystack_4));
            Assert.AreEqual(new int[] { 5, -85 }, Program.CountPosSumNeg(haystack_5));
        	  Assert.AreEqual(new int[] { 4, -34 }, Program.CountPosSumNeg(haystack_6));
        		Assert.AreEqual(new int[] { 0, 0 }, Program.CountPosSumNeg(haystack_7));
         	 	Assert.AreEqual(new int[] { 2, -116 }, Program.CountPosSumNeg(haystack_8));
         	 	Assert.AreEqual(new int[] { 4, -258 }, Program.CountPosSumNeg(haystack_9));
         	 	Assert.AreEqual(new int[] { 0, 0 }, Program.CountPosSumNeg(haystack_10));
        }
    }
    