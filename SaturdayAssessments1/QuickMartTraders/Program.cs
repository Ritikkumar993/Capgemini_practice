class Program
{
    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction;

    public static void Registration()
    {
        SaleTransaction sales =new SaleTransaction();

        string invoiceNo;
        do
        {
            Console.Write("Enter Invoice No: ");
            invoiceNo=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(invoiceNo)) Console.WriteLine("Invoice No, Can't be empty");
        }while(string.IsNullOrWhiteSpace(invoiceNo));
        
        sales.InvoiceNo=invoiceNo;
                
        Console.Write("\nEnter Customer Name: ");
        string customerName=Console.ReadLine();
        sales.CustomerName=customerName;
                

        Console.Write("\nEnter Item Name: ");
        string itemname=Console.ReadLine();
        sales.ItemName=itemname;

        int quantity;
        do
        {
            Console.Write("\nEnter Quantity: ");
            quantity=int.Parse(Console.ReadLine());
            if(quantity<=0) Console.WriteLine("Quantity must be Greater than Zero");
        } while (quantity<=0);
        sales.Quantity=quantity;

        decimal PurchaseAmount;
        do
        {
            Console.Write("\nEnter Purchase Amount (total): ");
            PurchaseAmount=decimal.Parse(Console.ReadLine());   
            if(PurchaseAmount<0) Console.WriteLine("Purchase Amount must be positive");
        } while(PurchaseAmount<0);
        sales.PurchaseAmount=PurchaseAmount;

        decimal sellingAmount;
        do
        {
            Console.Write("\nEnter Selling Amount (total): ");
            sellingAmount=decimal.Parse(Console.ReadLine());
            if(sellingAmount<0) Console.WriteLine("selling Amount must be positive");

        } while (sellingAmount<0);
        sales.SellingAmount=sellingAmount; 

        sales.Status();
        sales.Purchase_Amount();
        sales.profitMarginPercent();
        


        Console.WriteLine("\nTransaction saved successfully.");
        Console.Write("\nStatus: "+sales.ProfitOrLossStatus);
        Console.Write("\nProfit/Loss Amount: "+sales.ProfitOrLossAmount);
        Console.Write("\nProfit Margin (%): "+sales.ProfitMarginPercent);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
        
        LastTransaction=sales;
        HasLastTransaction=true;
    }

    public static void ViewLastTransaction()
    {
        if (HasLastTransaction)
        {
            Console.WriteLine("-------------- Last Transaction --------------");
            Console.WriteLine("InvoiceNo: "+LastTransaction.InvoiceNo);
            Console.WriteLine("Customer: "+LastTransaction.CustomerName);        
            Console.WriteLine("Item: "+LastTransaction.ItemName);        
            Console.WriteLine("Quantity: "+LastTransaction.Quantity);        
            Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");        
            Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");   
            Console.WriteLine("Status: "+LastTransaction.ProfitOrLossStatus);                
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");        
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();        

        }
        else
        {
            Console.WriteLine("No transaction found, creat transaction first");
        }
    }

    public static void CalculateTrades()
    {
        if (HasLastTransaction)
        {
            Console.WriteLine("-------------- Last Transaction Profit/Loss --------------");
            Console.WriteLine("Status: "+LastTransaction.ProfitOrLossStatus);
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");        
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Doesn't have any trade to find Profit/Loss");
        }
    }

    public static void Main()
    {
        bool check=true;
        while(check){
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your option:");
            int choice=int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Registration();               
                    break;
                case 2:
                    ViewLastTransaction();
                    break;
                case 3:
                    CalculateTrades();
                    break;
                case 4:
                    check=false;
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice! please seclect from the menue");
                    break;   
            }
        }

    }
}