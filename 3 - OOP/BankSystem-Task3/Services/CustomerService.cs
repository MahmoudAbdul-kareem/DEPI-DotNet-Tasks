using BankSystem_Task3.Models;

namespace BankSystem_Task3.Services
{
    internal static class CustomerService
    {
        public static Customer AddCustomer(Bank bank, string fullName, string nationalID, DateTime dateOfBirth)
        {
            if (bank is null)
            {
                Console.WriteLine("Error: Invalid bank!");
                return null;
            }
            if (bank.Customers.Any(c => c.NationalID == nationalID))
            {
                Console.WriteLine("Error: National ID already exists.");
                return null;
            }
            var customer = new Customer(fullName, nationalID, dateOfBirth);
            bank.Customers.Add(customer);

            Console.WriteLine($"Customer added successfully. ID = {customer.ID}");
            return customer;
        }

        public static bool UpdateCustomer(Bank bank, Customer customer, string? newName = null, DateTime? newDOB = null)
        {
            if (customer is null || bank is null)
            {
                Console.WriteLine("Error: Invalid Customer or bank!");
                return false;
            }
            if (!bank.Customers.Contains(customer))
            {
                Console.WriteLine("Error: Customer not found in this bank!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(newName))
                customer.FullName = newName;

            if (newDOB.HasValue)
                customer.DateOfBirth = newDOB.Value;

            Console.WriteLine("Customer updated successfully.");
            return true;
        }

        public static bool RemoveCustomer(Bank bank, Customer customer)
        {
            if (customer is null || bank is null)
            {
                Console.WriteLine("Error: Invalid Customer or bank!");
                return false;
            }
            foreach (var account in customer.Accounts)
            {
                if (account.Balance != 0)
                {
                    Console.WriteLine("Error: Can't remove customer! One or more accounts still have balance.");
                    return false;
                }
            }

            bank.Customers.Remove(customer);
            Console.WriteLine("Customer removed successfully.");
            return true;
        }
        public static Customer SearchCustomer(Bank bank, string nationalID)
        {
            if (bank is null)
            {
                Console.WriteLine("Error: Invalid bank!");
                return null;
            }
            if (string.IsNullOrWhiteSpace(nationalID))
            {
                Console.WriteLine("Error: National ID not valid!");
                return null;
            }
            var customer = bank.Customers.FirstOrDefault(c => c.NationalID == nationalID);
            if (customer is null)
            {
                Console.WriteLine("No customer found with this National ID.");
                return null;
            }
            Console.WriteLine($"Customer with NationalID({nationalID}) Found Successfully.");
            return customer;
        }


        #region ChatGPT-Code
        public static SavingsAccount CreateSavingsAccount(Customer customer)
        {
            if (customer is null)
            {
                Console.WriteLine("Error: Invalid customer!");
                return null;
            }

            var account = new SavingsAccount();
            customer.Accounts.Add(account);

            Console.WriteLine($"Savings account created successfully. Account No: {account.AccountNumber}");
            return account;
        }

        public static CurrentAccount CreateCurrentAccount(Customer customer)
        {
            if (customer is null)
            {
                Console.WriteLine("Error: Invalid customer!");
                return null;
            }

            var account = new CurrentAccount();
            customer.Accounts.Add(account);

            Console.WriteLine($"Current account created successfully. Account No: {account.AccountNumber}");
            return account;
        }
        #endregion
        
    }
}
