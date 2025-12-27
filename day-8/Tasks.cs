// class Tasks
// {
//     public void task1()
//     {
//         Console.WriteLine("enter the number of products");
//         int n=int.Parse(Console.ReadLine());
//         int[] products=new int[n];
//         for(int i = 0; i < n; i++)
//         {
//             int num=int.Parse(Console.ReadLine());
//             if(num>0)
//                 products[i]=num;
//         }
//         products.Sort();
//         int sum=0;
//         foreach(int it in products)
//         {
//             sum+=it;
//             Console.Write(it+" ");
//         }
//         Console.WriteLine();
//         int avgp=sum/n;

//         for(int i = 0; i < n; i++)
//         {
//             if (products[i] < avgp)
//             {
//                 products[i]=0;
//             }
//         }
//         Array.Resize(ref products, n+5);
//         for(int i = n; i < products.Length; i++)
//         {
//             products[i]=avgp;
//         }

//         foreach(int it in products)
//         {
//             Console.Write(it+" ");
//         }
//         Console.WriteLine();
//     }

//     public void task2()
//     {
//         Console.WriteLine("Enter Number of branches");
//         int branches=int.Parse(Console.ReadLine());
//         Console.WriteLine("Number of months");
//         int months=int.Parse(Console.ReadLine());
//         Console.WriteLine("Sales data monthly wise per branch:");

//         int[,] salesdata=new int[branches, months];
//         for(int i=0;i<branches;i++)
//         {
//             Console.WriteLine("branch: "+i+1);
//             for(int j=0;j<months;j++)
//             {
//                 salesdata[i,j]=int.Parse(Console.ReadLine());
//             }
//         }
//         int[] totalsales=new int[branches];
//         int highestms=0;
//         for(int i=0;i<branches;i++)
//         {
//             for(int j = 0; j < months; j++)
//             {
//                 if (salesdata[i,j] > highestms)
//                     highestms=salesdata[i,j];
//                 totalsales[i]+=salesdata[i,j];            
//             }
//         }
//         Console.WriteLine("Total sales branch wise:");
//         for(int i=0;i<totalsales.Length;i++)
//         {
//             Console.WriteLine(totalsales[i]+" ");
//         }
//         Console.WriteLine();
//         Console.WriteLine("Highest monthly sales accros all branches is "+highestms);

//     }

//     public void task3()
//     {
//         int[][] jagged=new int[][];


//     }
// }