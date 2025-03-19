namespace ATMapplication
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int Pin { get; set; }
        private decimal Balance { get; set; }


        public Customer(string firstName, string lastName, long cardNumber, int pin, decimal balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
        public bool ValidatePin(int enteredPin)
        {
            return Pin == enteredPin;
        }
        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }


    }
}