namespace OOP_Task1
{
    internal class SavingAccount: BankAccount
    {
        public decimal InterestRate;
        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"InterestRate: {InterestRate}");
        }
    }
}
