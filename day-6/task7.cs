namespace stock
{
    static class TradeProcessor
    {
        public static void ProcessTrade(Trade trade)
        {
            switch (trade)
            {
                case EquityTrade et:
                    Console.WriteLine("Processing Equity Trade");
                    Console.WriteLine("Symbol: "+et.Symbol);
                    Console.WriteLine("Trade Value: "+et.CalculateTradeValue());
                    break;
                default:
                    Console.WriteLine("Invalide Trade Type");
                    break;
            }
        }
    }
}