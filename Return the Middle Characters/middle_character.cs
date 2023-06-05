using System;

public class Program 
{
	public static string GetMiddle(string str) 
	{
		string result = "";
		
		if (str.Length % 2 == 0)
			result = str.Substring(str.Length/2 - 1, 2);
		
		else 
			result = str.Substring(str.Length/2, 1);
		
		return result;
	}
}