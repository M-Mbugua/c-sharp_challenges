using System.Linq;

public class Program 
{
    public static int[] CountPosSumNeg(double[] arr) 
    {
      return new[] {arr.Count(n => n > 0), (int)arr.Sum(n => n < 0 ? n : 0)};
    }
}
