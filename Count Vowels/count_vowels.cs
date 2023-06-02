// Count the number of vowels in a word.

namespace CountVowels
{
    public class Program 
    {
        public static int CountVowels(string str) 
        {
            int count = 0;
            
            foreach (char letter in str)
            {
                if (letter == 'a')
                    ++count;
                else if (letter == 'e')
                    ++count;
                else if (letter == 'i')
                    ++count;
                else if (letter == 'o')
                    ++count;
                else if (letter == 'u')
                    ++count;
            }
                
            return count;
        }
    }
}
