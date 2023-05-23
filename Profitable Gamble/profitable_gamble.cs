namespace Gamble
{
    public class Program 
    {
        public static bool ProfitableGamble(double prob, int prize, double pay) 
        {
            if (prob * prize > pay)
                return true;
            else
                return false;
        }
    }
}
