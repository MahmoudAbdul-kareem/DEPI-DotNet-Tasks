namespace BankSystem_Task3.Models
{
    internal abstract class Account
    {
        private static readonly Random _random = new Random(); // to generate AccountNumbers
        private decimal _balance;
        public int AccountNumber { get; }
        public decimal Balance
        {
            get => _balance;
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                    Console.WriteLine("Error: Plese enter positive balance!!");
            }
        }
        public DateTime DateOpened { get; }
        public List<Transaction> TransactionHistory { get; set; }
        public Account()
        {
            AccountNumber = int.Parse(_random.Next(1000000000, int.MaxValue).ToString().Substring(0, 16));
            DateOpened = DateTime.Now;
            TransactionHistory = new List<Transaction>();
        }

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                TransactionHistory.Add(new Transaction("Deposit", amount));
                Console.WriteLine($"Amount of {amount:C} was added successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid amount!");
                return false;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                Console.WriteLine("Error: Please enter a valid amount!");
                return false;
            }

            Balance -= amount;
            TransactionHistory.Add(new Transaction("Withdraw", amount));
            Console.WriteLine($"Amount of {amount:C} was withdrawn successfully.");
            return true;
        }

        public bool TransferTo(Account account, decimal amount)
        {
            if (account is null)
            {
                Console.WriteLine("Error: Transfer operation failed (invalid account).");
                return false;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Error: Please enter a positive amount!");
                return false;
            }

            if (amount > this.Balance)
            {
                Console.WriteLine("Error: Insufficient balance!");
                return false;
            }

            this.Balance -= amount;
            account.Balance += amount;

            Console.WriteLine($"Amount of {amount:C} was Transferred to {account.AccountNumber} successfully.");

            this.TransactionHistory.Add(new Transaction("Sent", amount));
            account.TransactionHistory.Add(new Transaction("Received", amount));

            return true;
        }
        public override string ToString()
        {
            return $"Account ({AccountNumber})" +
                   $"Balance: {Balance}\n" +
                   $"Date Opened: {DateOpened}";
        }
    }
}
