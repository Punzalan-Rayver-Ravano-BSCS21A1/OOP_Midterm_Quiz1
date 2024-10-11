namespace ClassLibrary1
{
    public class BankAccount
    {
        private decimal _balance;
        public string AccountName { get; set; }

        public BankAccount(string accountName, decimal initialBalance)
        {
            AccountName = accountName;
            _balance = initialBalance;
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative.");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                throw new ArgumentException("Withdrawal amount cannot be Overdraw");
            }
            _balance -= amount;
        }
    }

    public class Customer
    {
        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }

        public Customer(string name, int age)
        {
            _name = name;
            Age = age;
        }
        public string setName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get { return _age; }

            set
            {
                if (value > 0 && value <= 120)
                {
                    _age = value;
                }
            }
        }
        public string GetCustomerDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public class Employee
    {
        protected string _employeeId;
        public Employee(string employeeId)
        {
            _employeeId = employeeId;
        }
        public string setEmployee
        {
            get
            {
                return _employeeId;
            }
            set
            {
                _employeeId = value;
            }
        }
        public string GetEmployeeId()
        {
            return _employeeId;
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string employeeId, string department) : base(employeeId)
        {
            Department = department;
        }
    }
}