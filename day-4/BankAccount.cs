using System.Buffers.Text;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class BankAccount
{
    int AccountNo;
    double Balance;
    static string BankName;

    static BankAccount()
    {
        BankName="SBI";
    }

    public  BankAccount(int AccountNo,double Balance)
    {
        this.AccountNo=AccountNo;
        this.Balance=Balance;
         Console.WriteLine($"Balance is :{this.Balance}");
    }
}

class FixedDeposit : BankAccount
{
    int timeperiod;
    double fdamt;
    double roi;
    public FixedDeposit():base(101,4000)
    {
        
        Console.WriteLine("Account is feached");
        // Console.WriteLine($"Balance is :{this.Balance}");
    }
    
}