using ATMapplication;

Customer[] customers = new Customer[]
{
    new Customer("Mary","Marylin", 1111222233334444, 1234, 10500),
    new Customer("John","Doe", 5555666677778888, 0000, 64850),
    new Customer("Lana","Noel", 9999111122223333, 1122, 75236)
};

Customer FindCustomerByCard(long cardNumber)
{
    foreach (Customer customer in customers)
    {
        if (customer.CardNumber == cardNumber)
        {
            return customer;
        }
    }

    return null;
}

long GetCardNumber(string input)
{
    string[] cardParts = input.Split('-');
    string cardNumber = "";

    if (cardParts.Length != 4)
    {
        Console.WriteLine("Invalid format! Please enter in XXXX-XXXX-XXXX-XXXX format.");
        return -1;
    }

    foreach (string part in cardParts)
    {
        if (!long.TryParse(part, out long cardPart))
        {
            Console.WriteLine("Invalid card number! Please enter only numbers.");
            return -1;
        }

        cardNumber += cardPart.ToString();
    }

    long parsedCardNumber = long.Parse(cardNumber);
    return parsedCardNumber;
}

string GenerateCardNumber()
{
    string cardNumber = "";
    do
    {
        for (var i = 0; i < 4; i++)
        {
            int randomNumber = new Random().Next(1000, 9999);

            if (i != 3)
            {
                cardNumber += $"{randomNumber}-";
            }
            else
            {
                cardNumber += randomNumber;
            }
        }
    } while (FindCustomerByCard(GetCardNumber(cardNumber)) != null);

    return cardNumber;
}

bool Register()
{
    string newCustomerCardNumber = GenerateCardNumber();
    long cardNumber = GetCardNumber(newCustomerCardNumber);

    Console.WriteLine("Please enter your name:");
    var firstName = Console.ReadLine();
    if (firstName == "")
    {
        Console.WriteLine("Invalid input");
        return false;
    }
    Console.WriteLine("Please enter your last name:");
    var lastName = Console.ReadLine();
    if (lastName == "")
    {
        Console.WriteLine("Invalid input");
        return false;
    }
    Console.WriteLine("Please enter a four digit pin");
    var inputPin = Console.ReadLine();
    int pin;
    if (inputPin.Length != 4)
    {
        Console.WriteLine("Invalid input");
        return false;
    }
    else
    {
        bool validPin = int.TryParse(inputPin, out pin);
        if (!validPin)
        {
            Console.WriteLine("Invalid input");
            return false;
        }
    }

    Array.Resize(ref customers, customers.Length + 1);
    customers[customers.Length - 1] = new Customer(firstName, lastName, cardNumber, pin, 0);
    Console.WriteLine($"Successfully registered! Please save your card number and pin: \n Card Number: {newCustomerCardNumber} \n Pin: {pin}");

    return true;
}
void CashWithdrawl(long cardNumber, decimal amount)
{
    Customer customer = FindCustomerByCard(cardNumber);
    if (customer == null)
    {
        Console.WriteLine("Customer not found!");
        return;
    }

    var balance = customer.GetBalance();

    if (balance >= amount)
    {
        customer.Withdraw(amount);
        Console.WriteLine($"You withdrew {amount}den. You have {customer.GetBalance()}den left on your account.");
    }
    else
    {
        Console.WriteLine("You have not enough funds to withdraw!");
    }
}
void CashDeposition(Customer[] customers, long cardNumber, decimal deposit)
{
    Customer customer = FindCustomerByCard(cardNumber);
    if (customer == null)
    {
        Console.WriteLine("Customer not found!");
        return;
    }
    else
    {
        customer.Deposit(deposit);
        Console.WriteLine($"Your current account balance is: {customer.GetBalance()}");
    }
}

bool CustomerActions(Customer customer)
{
    Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName} ");
    Console.WriteLine("What would you like to do? \n a.Check Balance \n b.Cash Withdrawl \n c.Cash Deposit");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "a":
            Console.WriteLine($"Your current balance is: {customer.GetBalance()}");
            return true;
        case "b":
            Console.WriteLine("Please enter the amount you want to withdraw:");
            decimal amount = decimal.Parse(Console.ReadLine());
            CashWithdrawl(customer.CardNumber, amount);
            return true;
        case "c":
            Console.WriteLine("How much you want to deposit?");
            decimal deposit = decimal.Parse(Console.ReadLine());
            CashDeposition(customers, customer.CardNumber, deposit);
            return true;
        default: return false;
    }
}

bool CustomerUI()
{
    Console.WriteLine("Welcome to the ATM app. \n Please choose an option: \n a. Register \n b. Log In");
    var initialOption = Console.ReadLine();

    if (initialOption.ToUpper() == "A")
    {
        Register();
        return false;
    }
    else if (initialOption.ToUpper() == "B")
    {
        Console.WriteLine("Please enter your card number: ");
        string enteredCardNumber = Console.ReadLine().Trim();
        long cardNumber = GetCardNumber(enteredCardNumber);

        if (cardNumber == -1)
        {
            return false;
        }

        Customer customer = FindCustomerByCard(cardNumber);
        if (customer == null)
        {
            Console.WriteLine("Customer dosen't exist!");
            return false;
        }

        Console.WriteLine("Please enter your pin: ");

        for (int i = 3; i > 0; i--)
        {
            var input = Console.ReadLine();
            bool success = int.TryParse(input, out int attempt);

            if (!success || !customer.ValidatePin(attempt))
            {
                if (i != 1)
                {
                    Console.WriteLine($"You have entered a wrong pin, you have {i - 1} more attempts!");
                }
                else
                {
                    Console.WriteLine("Wrong input! You have no more attempts!");
                    return false;
                }
            }
            else
            {
                break;
            }
        }

        while (!CustomerActions(customer))
        {
            Console.WriteLine("Please select from the given options!");
        }

        Console.WriteLine("Thank you for using the ATM app!");

        while (true)
        {
            Console.WriteLine("Do you want to do another action? (YES/NO)");
            string input = Console.ReadLine().Trim().ToUpper();

            if (input == "YES")
            {
                bool anotherAction = CustomerActions(customer);
                if (!anotherAction)
                {
                    Console.WriteLine("Invalid action. Try again.");
                }
            }
            else if (input == "NO")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type YES or NO.");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid option");
        return false;
    }
}

while (!CustomerUI()) ;
