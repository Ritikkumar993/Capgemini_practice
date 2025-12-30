namespace bankingsystem
{

    class InsufficentBalanceException : Exception
    {
        public InsufficentBalanceException(string message):base(message){}

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
                throw new ArgumentException("Account number is not null, empty, or whitespace.", nameof(accountNumber));
            }
            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialBalance),"Initial Balance can't be negative");
            }

            AccountNumber=accountNumber;
            Balance=initialBalance;

        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("withdrawal amount is greater than zero");
            }

            try
            {
                

                if(Balance < amount)
                {
                    throw new InsufficentBalanceException("Insufficient balance to withdraw");
                }

                Balance-=amount;       
                Console.WriteLine("Withdraw is successfull, Current balance is: "+Balance);
            }
            catch (InsufficentBalanceException ex)
            {
                
            }
        }
        
        
    }
}