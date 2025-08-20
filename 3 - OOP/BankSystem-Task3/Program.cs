#region Commented
// using BankSystem_Task3.Models;
// using BankSystem_Task3.Services;

// namespace BankSystem_Task3
// {
//     internal class Program
//     {
//         private static Bank? bank1 = null;
//         static void Main(string[] args)
//         {
//             /*
//                 == Start & Bank Creation ==
//                     ** Validation **

//                 1) Customer Management:
//                     1- Add customer
//                     2- update customer
//                     3- remove customer
//                     4- search customer
//                     5- back
//                 2) Open Account:
//                     1- savings account
//                     2- current account
//                     3- back
//                 3) Account Operations:
//                     1- Deposit
//                     2- Withdraw
//                     3- Transfer
//                     4- back
//                 4) Reports
//                     1- Total balance per customer
//                     2- Monthly interest report
//                     3- Bank report (all customers + accounts + balances)
//                     4- Transaction history per account
//                     5- back
//                 5) Exit
//             */

//             PrintHeader("   Welcome to Banking System");
//             Console.WriteLine("Please create your first bank.");
//             while (bank1 is null)
//             {
//                 Console.Write("Enter Bank Name:");
//                 var bankName = Console.ReadLine();
//                 Console.Write("Enter Branch Code:");
//                 var branchCode = Console.ReadLine();
//                 bank1 = Bank.Create(bankName, branchCode);
//             }

//             while (true)
//             {
//                 PrintHeader("          Main Menu");
//                 Console.WriteLine("1) Customer Management");
//                 Console.WriteLine("2) Open Account");
//                 Console.WriteLine("3) Account Operations");
//                 Console.WriteLine("4) Reports");
//                 Console.WriteLine("5) Exit");
//                 Console.WriteLine("-----------------------\n");
//                 Console.Write("Choose an option: ");
//                 string? choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         CustomerManagement();
//                         break;
//                     case "2":
//                         OpenAccount();
//                         break;
//                     case "3":
//                         AccountOperations();
//                         break;
//                     case "4":
//                         Reports();
//                         break;
//                     case "5":
//                         PrintHeader("  Thanks for using our system");
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option, try again!"); // not printing
//                         break;
//                 }
//             }
//         }


//         private static void CustomerManagement()
//         {
//             while (true)
//             {
//                 PrintHeader("    Customer Management");
//                 Console.WriteLine("1) Add customer");
//                 Console.WriteLine("2) update customer");
//                 Console.WriteLine("3) remove customer");
//                 Console.WriteLine("4) search customer");
//                 Console.WriteLine("5) Back");
//                 Console.WriteLine("-----------------------\n");
//                 Console.Write("Choose an option: ");
//                 string? choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         // code
//                         break;
//                     case "2":
//                         CustomerService.UpdateCustomer(bank1, SelectCustomer(bank1), )
//                         break;
//                     case "3":
//                         // code
//                         break;
//                     case "4":
//                         // code
//                         break;
//                     case "5":
//                         // code
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option, try again!"); // not printing
//                         break;
//                 }
//             }
//         }
//         private static void OpenAccount()
//         {
//             while (true)
//             {
//                 PrintHeader("       Open Account"); // for any customer (or return to create)
//                 Console.WriteLine("1) savings account");
//                 Console.WriteLine("2) current account");
//                 Console.WriteLine("3) Back");
//                 Console.WriteLine("-----------------------\n");
//                 Console.Write("Choose an option: ");
//                 string? choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         // code
//                         break;
//                     case "2":
//                         // code
//                         break;
//                     case "3":
//                         // code
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option, try again!"); // not printing
//                         break;
//                 }
//             }
//         }
//         private static void AccountOperations()
//         {
//             while (true)
//             {
//                 PrintHeader("    Account Operations"); // login to account first (or create)
//                 Console.WriteLine("1) Deposit");
//                 Console.WriteLine("2) Withdraw");
//                 Console.WriteLine("3) Transfer");
//                 Console.WriteLine("4) Back");
//                 Console.WriteLine("-----------------------\n");
//                 Console.Write("Choose an option: ");
//                 string? choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         // code
//                         break;
//                     case "2":
//                         // code
//                         break;
//                     case "3":
//                         // code
//                         break;
//                     case "4":
//                         // code
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option, try again!"); // not printing
//                         break;
//                 }
//             }
//         }
//         private static void Reports()
//         {
//             while (true)
//             {
//                 PrintHeader("              Reports");
//                 Console.WriteLine("1) Total balance per customer"); // customer ??
//                 Console.WriteLine("2) Monthly interest report"); // for any saving account
//                 Console.WriteLine("3) Bank report (all customers + accounts + balances)");
//                 Console.WriteLine("4) Transaction history per account"); // for any account
//                 Console.WriteLine("5) Back");
//                 Console.WriteLine("-----------------------\n");
//                 Console.Write("Choose an option: ");
//                 string? choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         // code
//                         break;
//                     case "2":
//                         // code
//                         break;
//                     case "3":
//                         // code
//                         break;
//                     case "4":
//                         // code
//                         break;
//                     case "5":
//                         // code
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option, try again!"); // not printing
//                         break;
//                 }
//             }
//         }

//         private static void PrintHeader(string message)
//         {
//             Console.Clear();
//             Console.WriteLine("===============================");
//             Console.WriteLine($"{message}");
//             Console.WriteLine("===============================");
//             Console.WriteLine();
//         }

//         #region ChatGPT-Code
//         /// ========== ChatGPT Code start ===================
//         private static Customer? SelectCustomer(Bank bank)
//         {
//             if (bank.Customers.Count == 0)
//             {
//                 Console.WriteLine("No customers found.");
//                 return null;
//             }

//             Console.WriteLine("Select a customer:");
//             for (int i = 0; i < bank.Customers.Count; i++)
//             {
//                 Console.WriteLine($"{i + 1}) {bank.Customers[i]}");
//             }
//             Console.Write("Choice: ");
//             if (int.TryParse(Console.ReadLine(), out int choice)
//                 && choice > 0 && choice <= bank.Customers.Count)
//             {
//                 return bank.Customers[choice - 1];
//             }
//             Console.WriteLine("Invalid selection!");
//             return null;
//         }

//         private static Account? SelectAccount(Customer customer)
//         {
//             if (customer.Accounts.Count == 0)
//             {
//                 Console.WriteLine("No accounts found for this customer.");
//                 return null;
//             }

//             Console.WriteLine("Select an account:");
//             for (int i = 0; i < customer.Accounts.Count; i++)
//             {
//                 Console.WriteLine($"{i + 1}) {customer.Accounts[i]}");
//             }
//             Console.Write("Choice: ");
//             if (int.TryParse(Console.ReadLine(), out int choice)
//                 && choice > 0 && choice <= customer.Accounts.Count)
//             {
//                 return customer.Accounts[choice - 1];
//             }
//             Console.WriteLine("Invalid selection!");
//             return null;
//         }
//         /// ========== ChatGPT Code end ===================
//         #endregion
//     }
// }
#endregion

#region ChatGPT-Code
using BankSystem_Task3.Models;
using BankSystem_Task3.Services;

namespace BankSystem_Task3
{
    internal class Program
    {
        private static Bank? bank1 = null;
        static void Main(string[] args)
        {
            PrintHeader("   Welcome to Banking System");
            Console.WriteLine("Please create your first bank.");
            while (bank1 is null)
            {
                Console.Write("Enter Bank Name:");
                var bankName = Console.ReadLine();
                Console.Write("Enter Branch Code:");
                var branchCode = Console.ReadLine();
                bank1 = Bank.Create(bankName, branchCode);
            }

            while (true)
            {
                PrintHeader("          Main Menu");
                Console.WriteLine("1) Customer Management");
                Console.WriteLine("2) Open Account");
                Console.WriteLine("3) Account Operations");
                Console.WriteLine("4) Reports");
                Console.WriteLine("5) Exit");
                Console.WriteLine("-----------------------\n");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CustomerManagement(); break;
                    case "2": OpenAccount(); break;
                    case "3": AccountOperations(); break;
                    case "4": Reports(); break;
                    case "5":
                        PrintHeader("  Thanks for using our system");
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again!");
                        break;
                }
            }
        }

        private static void CustomerManagement()
        {
            while (true)
            {
                PrintHeader("    Customer Management");
                Console.WriteLine("1) Add customer");
                Console.WriteLine("2) update customer");
                Console.WriteLine("3) remove customer");
                Console.WriteLine("4) search customer");
                Console.WriteLine("5) Back");
                Console.WriteLine("-----------------------\n");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Full Name: ");
                        string name = Console.ReadLine();

                        Console.Write("National ID: ");
                        string nationalID = Console.ReadLine();

                        Console.Write("Date of Birth (yyyy-mm-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dob))
                            CustomerService.AddCustomer(bank1, name, nationalID, dob);
                        else
                            Console.WriteLine("Error: Invalid date format!");
                        break;

                    case "2":
                        var custToUpdate = SelectCustomer(bank1);
                        if (custToUpdate != null)
                        {
                            Console.Write("New Name (press enter to skip): ");
                            string newName = Console.ReadLine();

                            Console.Write("New DOB (yyyy-mm-dd or blank): ");
                            string dobInput = Console.ReadLine();
                            DateTime? newDob = null;
                            if (DateTime.TryParse(dobInput, out DateTime parsedDob))
                                newDob = parsedDob;

                            CustomerService.UpdateCustomer(bank1, custToUpdate, newName, newDob);
                        }
                        break;

                    case "3":
                        var custToRemove = SelectCustomer(bank1);
                        if (custToRemove != null)
                            CustomerService.RemoveCustomer(bank1, custToRemove);
                        break;

                    case "4":
                        Console.Write("Enter National ID: ");
                        string nid = Console.ReadLine();
                        CustomerService.SearchCustomer(bank1, nid);
                        break;

                    case "5": return;
                    default: Console.WriteLine("Invalid option, try again!"); break;
                }
            }
        }

        private static void OpenAccount()
        {
            while (true)
            {
                PrintHeader("       Open Account");
                Console.WriteLine("1) Savings account");
                Console.WriteLine("2) Current account");
                Console.WriteLine("3) Back");
                Console.WriteLine("-----------------------\n");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var cust1 = SelectCustomer(bank1);
                        if (cust1 != null)
                            CustomerService.CreateSavingsAccount(cust1);
                        break;

                    case "2":
                        var cust2 = SelectCustomer(bank1);
                        if (cust2 != null)
                            CustomerService.CreateCurrentAccount(cust2);
                        break;

                    case "3": return;
                    default: Console.WriteLine("Invalid option, try again!"); break;
                }
            }
        }

        private static void AccountOperations()
        {
            while (true)
            {
                PrintHeader("    Account Operations");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Transfer");
                Console.WriteLine("4) Back");
                Console.WriteLine("-----------------------\n");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var cust1 = SelectCustomer(bank1);
                        if (cust1 != null)
                        {
                            var acc = SelectAccount(cust1);
                            if (acc != null)
                            {
                                Console.Write("Enter amount: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                                    acc.Deposit(amount);
                            }
                        }
                        break;

                    case "2":
                        var cust2 = SelectCustomer(bank1);
                        if (cust2 != null)
                        {
                            var acc = SelectAccount(cust2);
                            if (acc != null)
                            {
                                Console.Write("Enter amount: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                                    acc.Withdraw(amount);
                            }
                        }
                        break;

                    case "3":
                        var sender = SelectCustomer(bank1);
                        if (sender != null)
                        {
                            var senderAcc = SelectAccount(sender);
                            if (senderAcc != null)
                            {
                                var receiver = SelectCustomer(bank1);
                                if (receiver != null)
                                {
                                    var receiverAcc = SelectAccount(receiver);
                                    if (receiverAcc != null)
                                    {
                                        Console.Write("Enter amount: ");
                                        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                                            senderAcc.TransferTo(receiverAcc, amount);
                                    }
                                }
                            }
                        }
                        break;

                    case "4": return;
                    default: Console.WriteLine("Invalid option, try again!"); break;
                }
            }
        }

        private static void Reports()
        {
            while (true)
            {
                PrintHeader("              Reports");
                Console.WriteLine("1) Total balance per customer");
                Console.WriteLine("2) Monthly interest report");
                Console.WriteLine("3) Bank report (all customers + accounts + balances)");
                Console.WriteLine("4) Transaction history per account");
                Console.WriteLine("5) Back");
                Console.WriteLine("-----------------------\n");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var cust1 = SelectCustomer(bank1);
                        if (cust1 != null)
                        {
                            decimal total = ReportingService.TotalBalancePerCustomer(cust1);
                            Console.WriteLine($"Total Balance for {cust1.FullName}: {total:C}");
                        }
                        break;

                    case "2":
                        var cust2 = SelectCustomer(bank1);
                        if (cust2 != null)
                        {
                            var acc = SelectAccount(cust2);
                            if (acc is SavingsAccount sa)
                            {
                                decimal interest = sa.CalculateMonthlyInterest();
                                Console.WriteLine($"Monthly Interest: {interest:C}");
                            }
                            else
                                Console.WriteLine("Error: Selected account is not a savings account.");
                        }
                        break;

                    case "3":
                        ReportingService.BankReport(bank1);
                        break;

                    case "4":
                        var cust3 = SelectCustomer(bank1);
                        if (cust3 != null)
                        {
                            var acc = SelectAccount(cust3);
                            if (acc != null)
                                ReportingService.DisplayTransactionHistory(acc);
                        }
                        break;

                    case "5": return;
                    default: Console.WriteLine("Invalid option, try again!"); break;
                }
            }
        }

        private static void PrintHeader(string message)
        {
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine($"{message}");
            Console.WriteLine("===============================");
            Console.WriteLine();
        }
        private static Customer? SelectCustomer(Bank bank)
        {
            if (bank.Customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return null;
            }

            Console.WriteLine("Select a customer:");
            for (int i = 0; i < bank.Customers.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {bank.Customers[i]}");
            }
            Console.Write("Choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice > 0 && choice <= bank.Customers.Count)
            {
                return bank.Customers[choice - 1];
            }
            Console.WriteLine("Invalid selection!");
            return null;
        }

        private static Account? SelectAccount(Customer customer)
        {
            if (customer.Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found for this customer.");
                return null;
            }

            Console.WriteLine("Select an account:");
            for (int i = 0; i < customer.Accounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {customer.Accounts[i]}");
            }
            Console.Write("Choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice > 0 && choice <= customer.Accounts.Count)
            {
                return customer.Accounts[choice - 1];
            }
            Console.WriteLine("Invalid selection!");
            return null;
        }
    }
}

#endregion
