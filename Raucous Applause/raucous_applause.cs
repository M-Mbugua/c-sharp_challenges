using System.Linq;

public class Program
{
	public static int CountClaps(string txt)
		=> txt.Count(n=>$"C".Contains(n));
}
