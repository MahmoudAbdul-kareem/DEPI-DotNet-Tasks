namespace BankSystem_Task3.Models
{
    internal class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; } = 0.05m; // default
        public decimal CalculateMonthlyInterest()
        {
            return Balance * (InterestRate / 12 / 100);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nType: Savings Account (Interest {InterestRate:P})";
        }
    }
}
