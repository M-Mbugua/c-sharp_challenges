public class Program
{
    public static bool IsStrangePair(string str1, string str2)
    {
		if (str1.Length == 0 && str2.Length == 0)
				return true;
		try 
		{
			return str1.First() == str2.Last() && str2.First() == str1.Last();
		}
		catch 
		{
			return false;	
		}
			
    }
}
