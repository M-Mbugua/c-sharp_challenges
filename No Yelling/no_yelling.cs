using System;
using System.Text;

public class Program 
{
    public static string NoYelling(string phrase)
	{
        if (phrase.EndsWith('!'))
		{
			string newPhrase = phrase.TrimEnd('!');
			return newPhrase + "!";
		}
				
		else if (phrase.EndsWith('?'))
		{
			string newPhrase = phrase.TrimEnd('?');
			return newPhrase + "?";
		}

        return phrase;
				
    }
		
}
