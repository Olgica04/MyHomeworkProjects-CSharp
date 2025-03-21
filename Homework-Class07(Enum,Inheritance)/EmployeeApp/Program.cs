using Domain.Enum;
using Domain.Models;

Employee employees = new Employee("Olgica", "Trpcevska", RoleEnum.Other, 700);
//employees.PrintInfo();
double salary = employees.GetSalary();

SalesPerson salesPerson = new SalesPerson("Ivan", "Ivanovski", 850);
salesPerson.AddSuccessRevenue(1700);
//salesPerson.PrintInfo();
//Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Risto", "Ristovski",500,"Software Developer");
Manager manager1 = new Manager("Ivan", "Najdovski",700,"Marketing");
manager.AddBonus(3400);
//manager.PrintInfo();
//Console.WriteLine(manager.GetSalary());

Contractor contractor = new Contractor("Dimo", "Dimovski", 8, 40, manager);
Contractor contractor1 = new Contractor("Ile", "Ilievski", 8, 25, manager1);
//contractor.PrintInfo();
//Console.WriteLine(contractor.GetSalary());
//Console.WriteLine(contractor.CurrentPosition());

Employee[] Company = { contractor, contractor1, manager, manager1, salesPerson };

//CEO ceo = new CEO()
//{
//    Company = Company
//};
//ceo.PrintEmployees();

CEO ceo1 = new CEO(Company, 33, 110, "John", "Doe");
Console.WriteLine("CEO:");
ceo1.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceo1.GetSalary()}");
Console.WriteLine("Employee");
ceo1.PrintEmployees();
