Console.Write("Enter your first number: ");
string input1 = Console.ReadLine();
bool success1= float.TryParse(input1, out float firstNumber);

Console.Write("Enter your second number: ");
string input2 = Console.ReadLine();
bool success2 = float.TryParse(input2, out float secondNumber);

Console.Write("Enter your operation: ");
string operation = Console.ReadLine();

float result;
if (success1 && success2)
{
    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine("The result is: " + result);
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine("The result is: " + result);
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine("The result is: " + result);
            break;
        case "/":
            result = firstNumber / secondNumber;
            Console.WriteLine("The result is: " + result);
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
} 
else
{
    Console.WriteLine("Invalid input! Please enter a valid number");
}
