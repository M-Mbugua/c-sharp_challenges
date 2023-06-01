public class Program 
{
	
    public static bool ValidateEmail(string str) 
    {	
        int atIndex = str.IndexOf("@");
		int dotIndex = str.LastIndexOf(".");

		if (str.Contains("@") == false)
			return false;
		else if (str.Contains(".") == false)
				return false;
		else if (atIndex == 0)
			return false;
		else if (atIndex > dotIndex)
			return false;
		else
			return true;
    }
}


