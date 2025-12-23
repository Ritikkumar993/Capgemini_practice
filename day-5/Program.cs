// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Play p= new Play();

// B b=new B();
// b.print();

// HR.Employee.display();
// HR.Finance.display();
 

using alias =LibrarySystem.Items;
using al2 =LibrarySystem;

public class Program
{
    
    public static void Main()
    {
        
        //task1
        alias.Book book= new alias.Book();
        book.Title="5 am club";
        book.Author="Alberto";
        book.ItemID=101;
        book.Display();
        book.CalculateLateFee(3);

        // task2
        alias.IReservable reserve=book;
        reserve.ReserveItem(101);

        //task4 as well Explicit Interface Implementation
        alias.INotifiable notify=book;
        notify.Notify("Booking completed");

        alias.Magazine mg=new alias.Magazine();
        mg.Title="atomic habit";
        mg.Author="Robert ";
        mg.ItemID=102;
        mg.Display();
        mg.CalculateLateFee(3);

        List<alias.LibraryItem> collections=new List<alias.LibraryItem>();
        collections.Add(book);
        collections.Add(mg);


        //task3
        // DisplayItemDetails
        Console.WriteLine("Method selection happens at runtime");
        foreach(alias.LibraryItem it in collections )
        {
            it.Display();
        }

        //partial && static
        
        al2.LibraryAnalytics.DisplayAnalysis();


        //task 7 enum

        al2.Users.Member.DiplayDetails();

        //bonus task
        al2.NotificationSer.SendNotify(al2.Users.UserRole.Admin);
        al2.NotificationSer.SendNotify(al2.Users.UserRole.Member);

        alias.Ebook eb= new alias.Ebook();
        eb.Title="Clean Code";
        eb.Author="Robert C. Martin";
        eb.ItemID=201;

        
        eb.Display();
        eb.Download();

    }
}











