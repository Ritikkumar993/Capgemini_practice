namespace stock
{
    static class Extensions
    {
        public static double CalculateBrokerage(this double amount)
        {
            return amount*0.001;
        }
        public static double CalculateGST(this double amount)
        {
            return amount*0.18;
        }
    }
}