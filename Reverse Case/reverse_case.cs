using System;

public class Program 
{
    public static string ReverseCase(string str) 
    {
		string reversed = string.Empty;
    	char[] strArray = str.ToCharArray();
    	
        foreach (char c in strArray)
    	{
            if (char.IsLower(c))
                reversed += Char.ToUpper(c);
      	    else
                reversed += Char.ToLower(c);
    	}

        return reversed;
    }
}
