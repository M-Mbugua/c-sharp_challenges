using System;
using System.Linq;
using System.Collections.Generic;
public class Program 
{
    public static int[] IndexOfCapitals(string str) 
    {
			int[] result = {};
			char[] array = str.ToCharArray();
			var resultList = result.ToList();
			
			foreach (char i in array)
			{
				if (Char.IsUpper(i))
					resultList.Add(str.IndexOf(i));
				else
					result = result;
			}
			
			result = resultList.ToArray();
			return result;
    }
}
