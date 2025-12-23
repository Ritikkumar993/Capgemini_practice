// See https://aka.ms/new-console-template for more information
using System.Buffers;
using System.Linq.Expressions;

class Program
{
    public static void Main()
    {
// Console.WriteLine("Hello, World!");


// BankAccount b= new BankAccount();

// FixedDeposit fd =new FixedDeposit();



// Product p = new Product
// {
//     Price=34,
//     Name="milk",


// };

// Console.WriteLine(p.Name);
// Console.WriteLine(p.Price);

// StudentProfile sp =new StudentProfile(1001)
// {
//     Year=2026
// };
// sp.Name="Ritik";
// sp.Age=21;
// sp.Marks=89;
// sp.Password="Ritik123";
// Console.WriteLine(sp.Result);
// Console.WriteLine(sp.Year);





// Lms lib=new Lms();
// lib[101]="C# Basics";
// Console.WriteLine(lib[101]);
// Console.WriteLine(lib["C# Basics"]);

// Ums u=new Ums();

// InsuranceMS ims=new InsuranceMS();
// ims.start();


        // Console.WriteLine("Ente valid password");
        // string email=Console.ReadLine();
        // string  pass=int.Parse(Console.ReadLine());
        // UserAuth.UserAuth(email,pass);


        UserAuth.Authenticate("ritiksah99344@gmail.com", "Ritik");

        LifeInsurance life = new LifeInsurance { PolicyNumber = 101, Name = "Life Secure" };
        life.calpremium(1000);
        life.display();

        HealthInsurance health = new HealthInsurance { PolicyNumber = 202, Name = "Health Plus" };
        health.calpremium(2000);
        health.display();

        PolicyDirectory directory = new PolicyDirectory();
        directory.policies.Add(101, "Life Secure");
        directory.policies.Add(202, "Health Plus");

        Console.WriteLine("Policy by ID 101: " + directory[101]);
        Console.WriteLine("Policy by Name 'Health Plus': " + directory["Health Plus"]);
    }
}







