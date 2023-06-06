using System;

public class Program 
{
    public static string Maskify(string str) 
    {
        char[] chars = str.ToCharArray();
			for ( int i = 0; i < str.Length - 4; i++)
			{
				chars[i] = '#';
			}
			
			return new string(chars);
    }
}
