using System.Text;

using s=stock;
using stock;
class Program
{
    public static void Main()
    {

        // StockPrice sp=new StockPrice
        // {
        //     Symbol="TCS",
        //     Price=1406.9,
        // };
        // //int struct obj  is passed by value
        // StockPrice copiedPrice = sp;
        // copiedPrice.Price=1450.6;
        // Console.WriteLine("Original Price of stock:"+sp.Price);
        // Console.WriteLine("Price of stock:"+copiedPrice.Price);


        //class -> by refrence
        // Trade trade1= new Trade
        // {
        //     TradeId=101,
        //     Symbol="Tcs",
        //     Quantity=100
        // };

        // Trade trade2=trade1;
        // trade2.Quantity=5;

        // Console.WriteLine("Trade one "+trade1.Quantity);
        // Console.WriteLine("Trade two "+trade2.Quantity);


        //portfolio
        // Portfolio p1= new Portfolio{Name="Growth"};
        // Portfolio p2= new Portfolio{Name="Growth"};

        // Console.WriteLine(p1.Equals(p2));
        // // Console.WriteLine(p1.Equals(p2));

        // Console.WriteLine("p1 code "+p1.GetHashCode());
        // Console.WriteLine("p2 code "+p2.GetHashCode());


        // Trade t = new EquityTrade();
        // Console.WriteLine(t.GetType());

        //boxing && unboxing
        //Object obj=price;//boxing
        //int value=(int)obj;//unboxing


        

        // //generic Class
        // Repositry<Trade> rp=new Repositry<Trade>();
        // rp.Data= new Trade{Name="Ritik"};
        // Console.WriteLine(rp.Data.Name);

        // //generic method 
        // Calculator cal=new Calculator();
        // string result=cal.calculator("ramu","ritik");
        // Console.WriteLine(result);
        // Console.WriteLine(cal.calculator(1,9));

        //generic collections List<T> list=new List<T>();


        // List<Trade> list = new List<Trade>();

        // // ?
        // // ?? null coall
        // // ?.
        
        // //extension methods (static class static method)
        // double amount = 5000;
        // Console.WriteLine($"tax amount of {amount}  is "+amount.Tax());



        //day 6 Assignment

        //Task 1: Market Price Snapshot Using Struct
        s.PriceSnapshot ps = new s.PriceSnapshot
        {
            Symbol = "AAPL",
            Price = 150.50,
        };
      
        Console.WriteLine($"Stock Symbol: {ps.Symbol}");
        Console.WriteLine($"Stock Price: {ps.Price}");
      

        Console.WriteLine("-----------------------------------");
        //Task 2: Base Trade Abstraction
        s.Trade equityTrade = new s.EquityTrade
        {
            TradeId = 1,
            Symbol = "AAPL",
            Quantity = 10,
            Price = 150.25,
        };
        string res=equityTrade.ToString();
        Console.WriteLine(res);

        Console.WriteLine("-----------------------------------");
        //TASK 3: Equity Trade Implementation

        s.EquityTrade tv = new s.EquityTrade();
        tv.Quantity=1;
        Console.WriteLine("Trade Value: "+tv.CalculateTradeValue());
        tv.Price=15050;
        Console.WriteLine("Trade Value: "+tv.CalculateTradeValue());


        Console.WriteLine("-----------------------------------");
        //TASK 4: Generic Trade Repository

        s.Trade equityTrade2 = new s.EquityTrade
        {
            TradeId = 2,
            Symbol = "TCS",
            Quantity = 100,
            Price = 150.5,
        };

        s.TradeRepository<s.Trade> repo= new s.TradeRepository<s.Trade>();
        repo.AddTrade(equityTrade);
        repo.AddTrade(equityTrade2);
        repo.ShowRepo();
          

        Console.WriteLine("-----------------------------------");
        //Task5:  
        s.TradeAnalytics.display();

        Console.WriteLine("-----------------------------------");
        //Task6:
        double tradeValue=equityTrade2.CalculateTradeValue();
        Console.WriteLine("Trade Value: " + tradeValue);
        double brokerage = tradeValue.CalculateBrokerage();
        double gst = brokerage.CalculateGST();

        Console.WriteLine("Brokerage: " + brokerage);
        Console.WriteLine("GST: " + gst);

        Console.WriteLine("-----------------------------------");
        // task7
        s.TradeProcessor.ProcessTrade(equityTrade2);

        Console.WriteLine("-----------------------------------");
        // task8
        Object obj=s.Globalvar.counter;
        Console.WriteLine("Boxed Trade Count: "+obj);
        int count=(int)obj;
        Console.WriteLine("UnBoxed Trade Count: "+count);

        Console.WriteLine("-----------------------------------");
            
    }
}



