string[] studentsG1 = new string[] { "Ivana", "Dejan", "Jovana", "Goran", "Bojan" };
string[] studentsG2 = new string[] { "Kosta", "Marija", "Davor", "Eva", "Ena" };

Console.WriteLine("Enter student group:");
bool success = int.TryParse(Console.ReadLine(), out int number);

if (success)
{
    if (number == 1)
    {
        Console.WriteLine("The students in G1 are: ");
        foreach (string item in studentsG1)
        {
            Console.WriteLine(item);
        }
    }
    else if (number == 2)
    {
        Console.WriteLine("The students in G2 are: ");
        foreach (string item in studentsG2)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("Wrong input! Please enter a number between 1 and 2");
    }
}
else
{
    Console.WriteLine("Wrong input!");
}


