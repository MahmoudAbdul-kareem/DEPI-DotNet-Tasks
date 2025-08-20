using BankSystem_Task3.Models;

namespace BankSystem_Task3.Services
{
    internal static class ReportingService
    {
        public static decimal TotalBalancePerCustomer(Customer customer)
        {
            if (customer is null)
            {
                Console.WriteLine("Error: Invalid Customer!");
                return 0m;
            }
            decimal result = 0m;
            foreach (var account in customer.Accounts)
            {
                result += account.Balance;
            }
            return result;
        }
        public static void BankReport(Bank bank)
        {
            if (bank is null)
            {
                Console.WriteLine("Error: Invalid Bank!");
                return;
            }
            Console.WriteLine($"=== Bank Report: {bank.Name} (Branch: {bank.BranchCode}) ===");
            if (!bank.Customers.Any())
            {
                Console.WriteLine("No customers found.");
                return;
            }
            foreach (var customer in bank.Customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine("--------------------");

                if (!customer.Accounts.Any())
                {
                    Console.WriteLine("  No accounts found.");
                }
                else
                {
                    foreach (var account in customer.Accounts)
                        Console.WriteLine(account); // relies on Account.ToString()
                }
            }
            Console.WriteLine("====================");
        }
        public static void DisplayTransactionHistory(Account account)
        {
            if (account is null)
            {
                Console.WriteLine("Error: Invalid Account!");
                return;
            }
            Console.WriteLine($"=== Transaction History for Account {account.AccountNumber} ===");
            if (!account.TransactionHistory.Any())
            {
                Console.WriteLine("No transactions found.");
            }
            else
            {
                foreach (var transaction in account.TransactionHistory)
                {
                    Console.WriteLine(transaction); // relies on Transaction.ToString()
                    Console.WriteLine("--------------------");
                }
            }
            Console.WriteLine("========================================");
        }
    }
}
