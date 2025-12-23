namespace LibrarySystem
{
    namespace Items
    {
        // 1. Nested namespaces help organize large projects by grouping related classes logically.
        // 2. They avoid name conflicts and ensure that classes inside a namespace remain uniquely identified.
        abstract class LibraryItem
        {
            public string Title{get;set;}
            public string Author{get;set;}
            public int ItemID{get;set;}

            abstract public void  Display();
            
            abstract public void CalculateLateFee(int Lday);  
        }

        interface IReservable
        {
            public void ReserveItem(int iteamid);
            
        }

        interface INotifiable
        {
            public void Notify(string message);            
            
        }

        class Book:LibraryItem ,IReservable, INotifiable
        {
            public override void Display()
            {
                Console.WriteLine("Book Title :"+Title);   
                Console.WriteLine("Author Name :"+Author);   
                Console.WriteLine("Item Id :"+ItemID);  
            }
            public override void CalculateLateFee(int Lday)
            {
                double fee = Lday * 1.0;
                Console.WriteLine($"Total late of {Lday} days is "+fee);
            }
            void IReservable.ReserveItem(int iteamid)
            {
                Console.WriteLine("Reservation success for "+iteamid);
            }
            void INotifiable.Notify(string message)
            {
                Console.WriteLine("Notification message sent it includes "+message);
            }
        }
        // Explicit interface implementation restricts direct access and allows methods to be called only through interface references.


        class Magazine:LibraryItem
        {
            public override void Display()
            {
                Console.WriteLine("Magazine Title :"+Title);   
                Console.WriteLine("Author Name :"+Author);   
                Console.WriteLine("Item Id :"+ItemID);  
            }
            public override void CalculateLateFee(int Lday)
            {
                double fee=Lday*0.5;
                Console.WriteLine($"Total late of {Lday}days is "+fee);
            }
        }
        class Ebook: LibraryItem, INotifiable
        {
            public override void Display()
            {
                Console.WriteLine("eBook Title: "+Title);
                Console.WriteLine("Author: "+Author);
                Console.WriteLine("Item ID: "+ItemID);
            }

            public override void CalculateLateFee(int Lday)
            {
                 Console.WriteLine("No late fee for eBooks.");
            }

            public void Download()
            {
                Console.WriteLine("eBook downloaded successfully.");
            }

            void INotifiable.Notify(string message)
            {
                Console.WriteLine(message);
            }

        }

    }

    namespace Users
    {
        enum UserRole
        {
            Admin,
            Librarian,
            Member
        }

        enum ItemStatus
        {
            Available,
            Borrowed,
            Reserved,
            Lost

        }
        // Enums prevent invalid values and improve code readability compared to strings.

        public class Member
        {
            public static void DiplayDetails()
            {
                UserRole role = UserRole.Member;
                ItemStatus status = ItemStatus.Borrowed;

                Console.WriteLine("User Role: " + role);
                Console.WriteLine("Item status: " + status);
            }
        }
        
    }
    partial class LibraryAnalytics
    {
        public static int totalborrowed{get;set;}
    }
    // Static members store system-wide data shared across all objects.

    static class NotificationSer
    {
        public static void SendNotify(Users.UserRole role)
        {
            if(role == Users.UserRole.Admin)
            {
                Console.WriteLine("Admin Alert: System maintenance scheduled.");

            }
            else if(role == Users.UserRole.Member)
            {
                 Console.WriteLine("Member Notification: Your borrowed item is due tomorrow.");
            }
        }
    }

}
