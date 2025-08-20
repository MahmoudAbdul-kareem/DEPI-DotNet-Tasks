namespace BankSystem_Task3.Models
{
    internal class Transaction
    {
        public DateTime Date { get; set; }
        public string? Type { get; set; } // Deposit / Withdraw / Received / Sent
        public decimal Amount { get; set; }

        public Transaction(string type, decimal amount)
        {
            Date = DateTime.Now;
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Type} - {Amount:C} at {Date}";
        }
    }
}
