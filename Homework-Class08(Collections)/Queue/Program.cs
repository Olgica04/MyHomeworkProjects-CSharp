Queue<int> numbers = new Queue<int>();

string input;

do
{
    Console.WriteLine("Enter number: ");
    input = Console.ReadLine();
    bool success = int.TryParse(input, out int number);

    if (success)
    {
        numbers.Enqueue(number);
    }
    else
    {
        Console.WriteLine("Please enter a valid number!");
        continue;
    }

    Console.WriteLine("Do you want to enter another number? (YES/NO): ");

    input = Console.ReadLine().ToUpper();


} while (input == "YES");

Console.WriteLine("Numbers in queue: ");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
