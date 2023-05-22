// Class to calculate the number of animal legs on a farm

namespace LegCount
{
    public class Program
    {
        public static int animals(int chickens, int cows, int pigs)
        {
            
            return chickens * 2 + (cows + pigs) * 4;
        }
    }
}
