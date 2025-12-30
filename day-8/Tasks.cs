using System.Collections;

class Tasks
{
    public void tasks()
    {
        //    Console.WriteLine("enter the number of products");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("enter products price:");
        //    int[] products = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        int num = int.Parse(Console.ReadLine());
        //        if (num > 0)
        //            products[i] = num;
        //    }
        //    products.Sort();
        //    int sum = 0;
        //    foreach (int it in products)
        //    {
        //        sum += it;
        //        Console.Write(it + " ");
        //    }
        //    Console.WriteLine();
        //    int avgp = sum / n;

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (products[i] < avgp)
        //        {
        //            products[i] = 0;
        //        }
        //    }
        //    Array.Resize(ref products, n + 5);
        //    for (int i = n; i < products.Length; i++)
        //    {
        //        products[i] = avgp;
        //    }

        //    foreach (int it in products)
        //    {
        //        Console.Write(it + " ");
        //    }
        //    Console.WriteLine();
        //}

        ////public void task2()
        ////{
        //    Console.WriteLine("Enter Number of branches");
        //    int branches = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Number of months");
        //    int months = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Sales data monthly wise per branch:");

        //    int[,] salesdata = new int[branches, months];
        //    for (int i = 0; i < branches; i++)
        //    {
        //        Console.WriteLine("branch: " +( i + 1));
        //        for (int j = 0; j < months; j++)
        //        {
        //            salesdata[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    int[] totalsales = new int[branches];
        //    int highestms = 0;
        //    for (int i = 0; i < branches; i++)
        //    {
        //        for (int j = 0; j < months; j++)
        //        {
        //            if (salesdata[i, j] > highestms)
        //                highestms = salesdata[i, j];
        //            totalsales[i] += salesdata[i, j];
        //        }
        //    }
        //    Console.WriteLine("Total sales branch wise:");
        //    for (int i = 0; i < totalsales.Length; i++)
        //    {
        //        Console.WriteLine(totalsales[i] + " ");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Highest monthly sales accros all branches is " + highestms);

        ////}

        ////public void task3()
        ////{
        //    int[][] jagged = new int[branches][];
        //    for(int i = 0; i < branches; i++)
        //    {
        //        List<int> temp = new List<int>();
        //        for(int j = 0; j < months; j++)
        //        {
        //            if (salesdata[i, j] >= avgp)
        //            {
        //                temp.Add(salesdata[i, j]);
        //            }
        //        }
        //        jagged[i] = temp.ToArray();
        //    }

        //    for(int i = 0; i < jagged.Length; i++)
        //    {
        //        Console.WriteLine("branch "+i+1);
        //        for (int j= 0; j < jagged[i].Length; j++) {
        //            Console.WriteLine(jagged[i][j]);
        //        }
        //    }

        //    //task 4
        //    Console.WriteLine("Enter the No. of transaction.");
        //    int NoOfTransaction = int.Parse(Console.ReadLine());
        //    List<int> CustomerIds = new List<int>();

        //    for(int i=0;i<NoOfTransaction;i++){
        //        CustomerIds.Add(int.Parse(Console.ReadLine()));   
        //    }

        //    HashSet<int> uniqueIds = new HashSet<int>(CustomerIds);

        //    CustomerIds = uniqueIds.ToList();

        //    Console.WriteLine("Differnce b/w original and final List is" + (NoOfTransaction - CustomerIds.Count));


        // //task 5
        // Console.WriteLine("Enter the No. of transaction");
        // int N = int.Parse(Console.ReadLine());

        // Dictionary<int, double> store = new Dictionary<int, double>();
        
        // for(int i = 0; i < N; i++)
        // {
        //     Console.WriteLine("Enter Transaction  id and amount");
        //     int id = int.Parse(Console.ReadLine());
        //     double amount = double.Parse(Console.ReadLine());
        //     if (!store.ContainsKey(id))
        //     {
        //         store.Add(id,amount);
        //     }
        // }
        
        // SortedList<int, double> sortedlist = new SortedList<int, double>();
        // foreach(var it in store)
        // {
        //     if (it.Value >= avgp)
        //     {
        //         sortedlist.Add(it.Key,it.Value);
        //     }
        // }
        // Console.WriteLine("Sorted List of Transaction");
        // foreach(var it in sortedlist)
        // {
        //     Console.WriteLine(it.Key+" "+it.Value);
        // }
        

        //task 6
        // Console.WriteLine("Enter the no. of operations");
        // int noofOpterations=int.Parse(Console.ReadLine());
        // Queue<int> processingOrder=new Queue<int>();
        // Stack<int> undoTracking =new Stack<int>();

        // for(int i = 0; i < noofOpterations; i++)
        // {
        //     int ops=int.Parse(Console.ReadLine());
        //     processingOrder.Enqueue(ops);
        //     undoTracking.Push(ops);
        // }
        
        // List<int> processed=new List<int>();
        // Console.WriteLine("processed (fifo) oders");
        // while (processingOrder.Count > 0)
        // {
        //     int p=processingOrder.Dequeue();
        //     processed.Add(p);
        //     Console.WriteLine(p);
        // }

        // Console.WriteLine("Undo Operations");
        // List<int>undo = new List<int>();

        // for(int i = 0; i < 2; i++)
        // {
        //     int ud=undoTracking.Pop();
        //     undo.Add(ud);
        //     Console.WriteLine(ud);
        // }


        //task7

        Console.WriteLine("Enter the no. of users");
        int noofUser=int.Parse(Console.ReadLine());
        Hashtable hashtable=new Hashtable();
        ArrayList arrayList=new ArrayList();

        for(int i = 0; i < noofUser; i++)
        {
            Console.WriteLine("Enter the user name and role for "+(i+1));
            string username=Console.ReadLine();
            string role=Console.ReadLine(); 
            hashtable.Add(username,role);
            arrayList.Add(username);
            arrayList.Add(role);

        }
        arrayList.Add("Ritik");
        foreach(DictionaryEntry it in hashtable)
        {
            Console.WriteLine(it.Key+" "+it.Value);
        }
        Console.WriteLine();

        foreach(string it in arrayList)
        {
            Console.WriteLine(it);
        }

        Console.WriteLine();


           
    }
}