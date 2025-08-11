namespace OOP_Task1
{
    internal class CurrentAccount: BankAccount
    {
        public decimal OverdraftLimit;
        public override decimal CalculateInterest()
        {
            return 0;
        }
        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"OverdraftLimit: {OverdraftLimit}");
        }
    }
}
