namespace OOP_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //BankAccount account1 = new BankAccount(null, "30402284571896", "01254698875", "Cairo", 5000);
            //var account2 = new BankAccount()
            //{
            //    FullName = "Mahmoud Awad",
            //    NationalID = "30405705421876",
            //    PhoneNumber = "01218501459",
            //    Address = "Menofia",
            //    Balance = 10000
            //};

            //account1.ShowAccountDetails();
            //account2.ShowAccountDetails();
            #endregion

            #region Task-2
            SavingAccount savingAccount = new SavingAccount()
            {
                InterestRate = 20,
                Address = "Roma",
                Balance = 647000,
                FullName = "Maher T.",
                NationalID = "58942265789832",
                PhoneNumber = "01234567892"
            };
            CurrentAccount currentAccount = new CurrentAccount()
            {
                OverdraftLimit = 10,
                Address = "Italy",
                Balance = 23350,
                FullName = "Ghareeb A.",
                NationalID = "87542136954785",
                PhoneNumber = "01235877125"
            };
            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(savingAccount);
            bankAccounts.Add(currentAccount);
            
            foreach (BankAccount bankAccount in bankAccounts)
            {
                bankAccount.ShowAccountDetails();
                Console.WriteLine("===============");
                Console.WriteLine(bankAccount.CalculateInterest()); 
            }

            #endregion
        }
    }
}
