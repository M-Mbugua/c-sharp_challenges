using System;

public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
		return  (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);    
    }
}
