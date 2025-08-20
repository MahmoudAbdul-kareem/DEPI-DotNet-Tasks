namespace BankSystem_Task3.Models
{
    internal class Customer
    {
        private string _fullName;
        private string _nationalID;
        public string ID { get; } // (auto-generated)

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                // not null or empty
                if (!string.IsNullOrEmpty(value))
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
                if (value.ToString().Length == 14)
                {
                    _nationalID = value;
                }
                else
                {
                    Console.WriteLine("Eror: NationalID NOT Valid!");
                }
            }
        }

        public DateTime DateOfBirth { get; set; }

        public List<Account> Accounts { get; set; } // try make it private

        public Customer()
        {
            Accounts = new List<Account>();
            ID = Guid.NewGuid().ToString("N").Substring(0, 10);
        }

        public Customer(string fullName, string nationalID, DateTime dateOfBirth) : this()
        {
            FullName = fullName;
            NationalID = nationalID;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Customer ({FullName}) | ID: {ID}\n" +
                   $"Natioal ID: {NationalID}\n" +
                   $"Date Of Birth: {DateOfBirth}";
        }
    }
}
