using System.Security.Cryptography.X509Certificates;

sealed class UserAuth
{
    private static string pass = "Ritik";
    private static string Email = "ritiksah99344@gmail.com";

    public static void Authenticate(string email, string val)
    {
        if (Email == email)
        {
            if (val == pass)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
        else
        {
            Console.WriteLine("User is invalid");
        }
    }
}

abstract class InsurancePolicy
{
    public int  PolicyNumber{get;init;}
    private double Premium;
    public string Name;
    public double premium
    {
        get{return Premium;}
        set{
            if (value > 0)
            {
                Premium=value;
            }
            else
            {
                Console.WriteLine("Invalid premium amount");
            }
        }
    }

    public virtual void calpremium(double amount )
    {
        double total=amount+amount*5/100;
        Console.WriteLine("calculated primium is"+total);
    }

    public void display()
    {
        Console.WriteLine("policy information");
        Console.WriteLine($"Policy Number: {PolicyNumber}, Name: {Name}, Premium: {premium}");        
    }
}

class LifeInsurance:InsurancePolicy
{
    public sealed override void calpremium(double amount)
    {
        double total = amount + amount * 10 / 100;
        premium = total;
        Console.WriteLine("Life Insurance premium calculated: " + total);
    }

    public new void display()
    {
        Console.WriteLine("Life Insurance Policy:");
        Console.WriteLine($"Policy Number: {PolicyNumber}, Name: {Name}, Premium: {premium}");
    }
}



class HealthInsurance:InsurancePolicy
{
    public sealed override void calpremium(double amount)
    {
        double total = amount + amount * 15 / 100;
        premium = total;
        Console.WriteLine("Health Insurance premium calculated: " + total);
    }

    public new void display()
    {
        Console.WriteLine("Health Insurance Policy:");
        Console.WriteLine($"Policy Number: {PolicyNumber}, Name: {Name}, Premium: {premium}");        
    }    
}


class PolicyDirectory
{
    public Dictionary<int,string> policies= new Dictionary<int,string>();
    public string this[int idx]
    {
        get
        {
            return policies.ContainsKey(idx) ? policies[idx] : "Policy not found";
        }
    }
    public string this[string name]
    {
        get
        {
            return policies.FirstOrDefault(p=>p.Value==name).Value;
        }
    }

}



