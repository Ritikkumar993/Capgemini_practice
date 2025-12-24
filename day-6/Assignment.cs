// using System;

namespace stock
{

    //Mini Project: SmartTrade � Real-Time Trading System Using Advanced C#

    //TASK 1: Market Price Snapshot Using Struct

    struct PriceSnapshot
    {
        public string Symbol;
        public double Price;
    };


    //TASK 2: Base Trade Abstraction
    abstract class Trade
    {
        public int TradeId { get; set; }
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        abstract public double CalculateTradeValue();
        public override string ToString()
        {
            return "Trade Id: " + TradeId + "\nSymbol: " + Symbol+"\nQuantity: "+Quantity;
        }
        
    }

    class EquityTrade : Trade
    {
        public double? Price;
        public override double CalculateTradeValue()
        {
            return (Price ?? 0)  * Quantity;
           
        } 
        
    }


    //Task4: Generic Trade Repository
    abstract class Globalvar
    {
        public static int counter=0;
    }
    
    class TradeRepository<T>: Globalvar where T : Trade
    {
       
        List<T> storeTrade= new List<T>();

        public void AddTrade(T a)
        {
            counter++;
            storeTrade.Add(a);
            Console.WriteLine("Trade Added Successfully");
        }
        public void ShowRepo()
        {
            Console.Write(counter); 
            Console.WriteLine(" Trade Logs ");
            foreach(T trade in storeTrade)
            {
                Console.WriteLine(trade.ToString());
            }

        }
        

    }






}