int[] arrayOfNumbers = new int[6];

for (int i = 0; i < arrayOfNumbers.Length; i++)
{
    Console.WriteLine("Enter integer no: " + (i + 1));
    bool success = int.TryParse(Console.ReadLine(), out int number);


    if (success)
    {
        arrayOfNumbers[i] = number;
    }
    else
    {
        Console.WriteLine("Wrong input! Please enter a valid input!");
        break;
    }

}

int sum = 0;
for (int i=0; i < arrayOfNumbers.Length; i++)
{
    if (arrayOfNumbers[i] % 2 == 0)
    {
    sum += arrayOfNumbers[i];
    }
}
Console.WriteLine("The resault is: " + sum);
    



