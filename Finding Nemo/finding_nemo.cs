using System;
using System.Linq;

class Program
{
	public static string FindNemo(string sentence)
	{
		string[] result = sentence.Split(' ');
		return (result.Contains("Nemo")) ? $"I found Nemo at {Array.IndexOf(result, "Nemo") + 1}!" : "I can't find Nemo :(";
	}
}
