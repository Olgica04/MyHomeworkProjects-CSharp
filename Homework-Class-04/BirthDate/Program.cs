int AgeCalculator(string dateOfBirth)
{
    if (dateOfBirth.Length != 10)
    {
        Console.WriteLine("Invalid input. Please use format dd/MM/yyyy.");
        return -1;
    }

    var extractDay = dateOfBirth.Substring(0, 2);
    var extractMonth = dateOfBirth.Substring(3, 2);
    var extractYear = dateOfBirth.Substring(6, 4);

    bool validateDay = int.TryParse(extractDay, out int day);
    bool validateMonth = int.TryParse(extractMonth, out int month);
    bool validateYear = int.TryParse(extractYear, out int year);

    if (validateDay && validateMonth && validateYear)
    {
        if (day < 0 || day > 31)
        {
            Console.WriteLine("Please provide correct day for your date of birth");
            return -1;
        }

        if (month < 0 || month > 12)
        {
            Console.WriteLine("Please provide correct month for your date of birth");
            return -1;
        }

        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (day > daysInMonth[month])
        {
            Console.WriteLine("Please provide correct day for the given month");
            return -1;
        }

        if (year < 0 || year > 2025)
        {
            Console.WriteLine("Please provide correct year for your date of birth");
            return -1;
        }

        var currentDate = DateTime.Now;
        var birthDate = new DateTime(year, month, day);

        int age = currentDate.Year - birthDate.Year;

        if (currentDate.Month <= birthDate.Month)
        {
            if (currentDate.Day < birthDate.Day)
            {
                age--;
            }
        }

        return age;
    }
    else
    {
        Console.WriteLine("You have provided invalid input");
        return -1;
    }
}

Console.WriteLine("Provide your date of birth in the following format: dd/MM/yyyy");

var input = Console.ReadLine();
var age = AgeCalculator(input);

if (age != -1 && age >= 0)
{
    Console.WriteLine($"Age is {age}");
}