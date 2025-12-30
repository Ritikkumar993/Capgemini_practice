namespace bankingsystem
{

    public class InsufficentBalanceException : Exception
    {
        public InsufficentBalanceException(string message):base(message){}

    }
    public class BankOperationException : Exception
    {
        public BankOperationException(string message,Exception inner):base(message,inner){}

    }

    class BankAccount
    {
        public string AccountNumber{get;private set;}
        public decimal Balance{get; private set;}

        public BankAccount(string accountNumber,decimal initialBalance)
        {
            // Validate that the account number is not null, empty, or whitespace.
            if( string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Account number is not null, empty, or whitespace.");
            }
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial Balance can't be negative");
            }

            AccountNumber=accountNumber;
            Balance=initialBalance;

        }

        public void Withdraw(decimal amount)
        {

            try
            {
                
                if (amount <= 0)
                {
                    throw new ArgumentException("withdrawal amount is greater than zero");
                }

                if(Balance < amount)
                {
                    throw new InsufficentBalanceException("Insufficient balance to withdraw");
                }

                Balance-=amount;       
                Console.WriteLine("Withdraw is successfull, Current balance is: "+Balance);
            }
            catch (InsufficentBalanceException ex)
            {
                LogException(ex);
                throw;
            }
            catch(Exception ex)
            {
                LogException(ex);
                throw new BankOperationException("Unexpected error during withdrawal.", ex);
            }
        }
        
        private void LogException(Exception ex)
        {
            File.AppendAllText(
                "error.log",
                "Date & Time :"+DateTime.Now+Environment.NewLine+
                "Account No  :"+AccountNumber + Environment.NewLine+
                "Exception   :"+ex.ToString()+Environment.NewLine
            );
        }
        
    }
}