using Homework_Task1;

Driver[] drivers = new Driver[]
{
    new Driver("Mark Verstappen",10),
    new Driver("Bobby Allison",5),
    new Driver("Tim Flock",7),
    new Driver("David Pearson",3),
};

Car[] cars = new Car[]
{
    new Car("Ferrari",default,200),
    new Car("Mercedes",default,280),
    new Car("Porche",default,320),
    new Car("Maserati",default,300),
};
void RaceCars(Car firstCar, Car secondCar)
{

    int speed1 = firstCar.CalculateSpeed();
    int speed2 = secondCar.CalculateSpeed();

    if (speed1 > speed2)
    {
        Console.WriteLine($"Car {firstCar.Model} was faster. It was going with {firstCar.Speed} km/h and it was driving {firstCar.Driver.Name}");
    }
    else if (speed1 < speed2)
    {
        Console.WriteLine($"Car {secondCar.Model} was faster. It was going with {secondCar.Speed} km/h and it was driving {firstCar.Driver.Name}");
    }
    else
    {
        Console.WriteLine($"Draw. Both cars were driving with {firstCar.Speed}.");
    }
}
void ChooseOptions()
{
    Car raceCar1 = new Car();
    Car raceCar2 = new Car();

    Console.WriteLine($"Choose the first car:");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}){cars[i].Model} {cars[i].Speed} km/h\"");
    }

    string chooseFirstCar = Console.ReadLine();
    bool success1 = int.TryParse(chooseFirstCar, out int firstCar);
    if (!success1)
    {
        Console.WriteLine("You have entered invalid input!");
        return;
    }

    switch (firstCar)
    {
        case 1:
            raceCar1 = cars[0];
            Console.WriteLine($"You have chosen: {cars[0].Model}");
            break;
        case 2:
            raceCar1 = cars[1];
            Console.WriteLine($"You have chosen: {cars[1].Model}");
            break;
        case 3:
            raceCar1 = cars[2];
            Console.WriteLine($"You have chosen: {cars[2].Model}");
            break;
        case 4:
            raceCar1 = cars[3];
            Console.WriteLine($"You have chosen: {cars[3].Model}");
            break;
        default:
            Console.WriteLine("Please enter a valid choice!");
            return;
    }

    Console.WriteLine($"Choose Driver: ");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}){drivers[i].Name}");
    }
    
    string chooseFirstDriver = Console.ReadLine();
    bool success2 = int.TryParse(chooseFirstDriver, out int firstDriver);
    if (!success2)
    {
        Console.WriteLine("You have entered invalid input!");
        return;
    }


    switch (firstDriver)
    {
        case 1:
            raceCar1.AssignDriver(drivers[0]);
            Console.WriteLine($"You have chosen: {drivers[0].Name}");
            break;
        case 2:
            raceCar1.AssignDriver(drivers[1]);
            Console.WriteLine($"You have chosen: {drivers[1].Name}");
            break;
        case 3:
            raceCar1.AssignDriver(drivers[2]);
            Console.WriteLine($"You have chosen: {drivers[2].Name}");
            break;
        case 4:
            raceCar1.AssignDriver(drivers[3]);
            Console.WriteLine($"You have chosen: {drivers[3].Name}");
            break;
        default:
            Console.WriteLine("Please enter a valid choice!");
            break;
    }

    Console.WriteLine($"Choose the second car:");
    for (int i = 0; i < cars.Length; i++)
    {
        if (i + 1 != firstCar)
        {
            Console.WriteLine($"{i + 1}){cars[i].Model} {cars[i].Speed} km/h");
        }
    }

    string chooseSecondCar = Console.ReadLine();
    bool success3 = int.TryParse(chooseSecondCar, out int secondCar);
    if (!success3)
    {
        Console.WriteLine("You have entered invalid input!");
        return;
    }

    if (secondCar == firstCar)
    {
        Console.WriteLine("You can't just choose the same car twice");
        return;
    }

    switch (secondCar)
    {
        case 1:
            raceCar2 = cars[0];
            Console.WriteLine($"You have chosen: {cars[0].Model}");
            break;
        case 2:
            raceCar2 = cars[1];
            Console.WriteLine($"You have chosen: {cars[1].Model}");
            break;
        case 3:
            raceCar2 = cars[2];
            Console.WriteLine($"You have chosen: {cars[2].Model}");
            break;
        case 4:
            raceCar2 = cars[3];
            Console.WriteLine($"You have chosen: {cars[3].Model}");
            break;
        default:
            Console.WriteLine("Please enter a valid choice!");
            break;
    }
    Console.WriteLine($"Choose Driver: ");
    for (int i = 0; i < drivers.Length; i++)
    {
        if (i + 1 != firstDriver)
        {
            Console.WriteLine($"{i + 1}){drivers[i].Name}");
        }
    }
   
    string chooseSecondDriver = Console.ReadLine();
    bool success4 = int.TryParse(chooseSecondDriver, out int secondDriver);
    if (secondDriver == firstDriver)
    {
        Console.WriteLine("You can't choose the same driver twice");
        return;
    }
    if (!success4)
    {
        Console.WriteLine("You have entered invalid input!");
        return;
    }

    switch (secondDriver)
    {
        case 1:
            raceCar2.AssignDriver(drivers[0]);
            Console.WriteLine($"You have chosen: {drivers[0].Name}");
            break;
        case 2:
            raceCar2.AssignDriver(drivers[1]);
            Console.WriteLine($"You have chosen: {drivers[1].Name}");
            break;
        case 3:
            raceCar2.AssignDriver(drivers[2]);
            Console.WriteLine($"You have chosen: {drivers[2].Name}");
            break;
        case 4:
            raceCar2.AssignDriver(drivers[3]);
            Console.WriteLine($"You have chosen: {drivers[3].Name}");
            break;
        default:
            Console.WriteLine("Please enter a valid choice!");
            break;
    }

    RaceCars(raceCar1, raceCar2);
}

while (true)
{
    ChooseOptions();

    Console.WriteLine("Would you like to race again? YES/NO");
    string racingAgain = Console.ReadLine();
    if (racingAgain.ToUpper() != "YES")
    {
        break;
    }
}