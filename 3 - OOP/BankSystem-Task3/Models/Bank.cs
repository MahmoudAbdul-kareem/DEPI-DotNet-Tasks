namespace BankSystem_Task3.Models
{
    internal class Bank
    {
        private string _name;
        private string _branchCode;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Error: Bank Name is NOT Valid!!");
                }
            }
        }
        public string BranchCode
        {
            get
            {
                return _branchCode;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _branchCode = value;
                }
                else
                {
                    Console.WriteLine("Error: Branch Code is NOT Valid!!");
                }
            }
        }
        public List<Customer> Customers { get; set; }

        private Bank(string bankName, string branchCode)
        {
            Name = bankName;
            BranchCode = branchCode;
            Customers = new List<Customer>();
        }
        public static Bank Create(string bankName, string branchCode)
        {
            if (string.IsNullOrWhiteSpace(bankName) || string.IsNullOrWhiteSpace(branchCode))
            {
                Console.WriteLine("Invalid bank details! CAN'T Create Bank Object.");
                return null;
            }

            return new Bank(bankName, branchCode);
        }
    }
}
