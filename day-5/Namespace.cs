namespace HR
{
    class Employee
    {
        public static void display()
        {
            Console.WriteLine("Employee");
        }
    }

    class Finance
    {
        public static void display()
        {
            Console.WriteLine("Finance");
        }
    }
}

namespace LibrarySystem
{
    partial  class LibraryAnalytics
    {
        public static void DisplayAnalysis()
        {
            totalborrowed++;
            Console.WriteLine("Total borrowed items are "+totalborrowed);

        }
    }
}
