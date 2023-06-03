public class Program
{
	public static int collatz(int num)
	{
		int steps = 0;
		
		for (int i = 0; num > 1; i++)
		{
			if (num % 2 == 0)
				num = num / 2;
			else
				num = num * 3 + 1;
			
			steps += 1;
		}
		
		return steps;
	}
}
