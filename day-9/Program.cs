// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a =10;
// int b=0;

// try
// {
//     int result =a/b;
// }catch(Exception e)
// {
//     Console.WriteLine("Error occured: "+e.Message);
// }

/*
using System;
using System.IO;

try
{
    try
    {
        File.ReadAllText("transactions.txt");
    }
    catch (IOException ioEx)//thechnical Layer
    {
        throw new ApplicationException( //business Layer
            "Unable to load transaction data",
            ioEx // exception wraping
        );
    }
}
catch (Exception ex)
{
    Console.WriteLine("Message: " + ex.Message);
    Console.WriteLine("Root Cause: " + ex.InnerException.Message);
}

*/


class Program
{
    public static void Main()
    {
        try
        {
            //User Input validation
            Console.WriteLine("Enter the Withdraw amount");
            decimal amount=decimal.Parse(Console.ReadLine());

            //Arithemic Operation
            int serviceCharge=100;
            int devisorCheck=serviceCharge/int.Parse("1");

            //File access
            string data = File.ReadAllText("account.txt");

            BankAccount account= new BankAccount(-10);
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal is successfull");



        }
        catch(FormatException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientMemoryException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction attempt is completed");
        }

        // FileStream File;
        // try
        // {
        //     File = FileStream("data.txt",FileMode.Open);
        //     int data=File.ReadByte();
        // }
        // catch(FileNotFoundException ex)
        // {
        //     LogException(ex);
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     if (file != null)
        //     {
        //         file.Close(); // Ensures file is always closed
        //         Console.WriteLine("File stream closed in finally block.");
        //     }
            
        // }



        // try
        // {
        //     // Simulate database operation
        //     throw new SqlException("Connection failed");
        // }
        // catch (SqlException ex)
        // {
        //     // Wrap low-level exception into higher-level exception
        //     throw new Exception("Database operation failed in Service Layer", ex);
        // }
    }

    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log",
            DateTime.Now+" | "+  ex.GetType().Name+" | "+ex.Message+Environment.NewLine
        );
    }
}




