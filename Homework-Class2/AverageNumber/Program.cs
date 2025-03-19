Console.Write("Enter your first number: ");
string input1 = Console.ReadLine();
bool success1 = double.TryParse(input1, out double firstNumber);

Console.Write("Enter your second number: ");
string input2 = Console.ReadLine();
bool success2 = double.TryParse(input2, out double secondNumber);

Console.Write("Enter your third number: ");
string input3 = Console.ReadLine();
bool success3 = double.TryParse(input3, out double thirdNumber);

Console.Write("Enter your fourth number: ");
string input4 = Console.ReadLine();
bool success4 = double.TryParse(input4, out double fourthNumber);

if (success1 && success2 && success3 && success4)
{

    double average;

    average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

    Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + average);
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number!");
}