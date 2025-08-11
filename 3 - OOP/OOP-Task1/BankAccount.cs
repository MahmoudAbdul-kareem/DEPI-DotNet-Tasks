namespace OOP_Task1
{
    internal class BankAccount
    {
        public const string BankCode = "BNK001";

        private static readonly Random _random = new Random(); // to generate _accountNumber

        private readonly DateTime CreatedDate;
        private int _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        private decimal _balance;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                // not null or empty
                if (!(value == null || value == ""))
                {
                    _fullName = value;
                }
                else
                {
                    Console.WriteLine("Eror: FullName NOT Valid!");
                }
            }
        }
        public string NationalID
        {
            get
            {
                return _nationalID;
            }
            set
            {
                // 14 digits
                if (IsValidNationalID(value))
                {
                    _nationalID = value;
                }
                else
                {
                    Console.WriteLine("Eror: NationalID NOT Valid!");
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                // start with "01" and be 11 digits long
                if (IsValidPhoneNumber(value))
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Eror: PhoneNumber NOT Valid!");
                }
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Eror: Balance NOT Valid!");
                }
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public BankAccount()
        {
            CreatedDate = DateTime.Now;
            _accountNumber = int.Parse(_random.Next(1000000000, int.MaxValue).ToString().Substring(0, 10));
        }
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance): this()
        {
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = balance;
        }
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address): this() 
        {
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = 0;
        }

        public virtual void ShowAccountDetails()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Bank Code: {BankCode}");
            Console.WriteLine($"Account Number: {_accountNumber}");
            Console.WriteLine($"Created At: {CreatedDate}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"National ID: {NationalID}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Balance: {Balance}");
        }
        public bool IsValidNationalID(string nationalID)
        {
            return nationalID.Length == 14;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return (phoneNumber.Length == 11 && phoneNumber.StartsWith("01"));
        }

        public virtual decimal CalculateInterest() => 0;
    }
}
