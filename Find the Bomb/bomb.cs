using System;

public class Program
{
	public static string Bomb(string txt)
	{
		txt = txt.ToLower();
		string result = (txt.Contains("bomb")) ? "Duck!!!" : "There is no bomb, relax.";
		return result;
	}
}
