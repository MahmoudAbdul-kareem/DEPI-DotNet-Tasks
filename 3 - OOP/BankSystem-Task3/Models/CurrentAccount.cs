namespace BankSystem_Task3.Models
{
    internal class CurrentAccount : Account
    {
        public decimal OverdraftLimit { get; set; } = 1000m; // default

        public override string ToString()
        {
            return base.ToString() + $"\nType: Current Account (Overdraft {OverdraftLimit:C})";
        }
    }
}
