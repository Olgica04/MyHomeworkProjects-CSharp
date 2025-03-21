using Domain.Enum;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Company { get; set; }

        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO() { }
        public CEO(Employee[] company, int shares, double sharesPrice, string firstName, string lastName) 
            : base(firstName, lastName, RoleEnum.CEO, 2000)
        {
            Company =company;
            Shares = shares;
            SharesPrice = sharesPrice;
        }
        
        public double AddSharesPrice(double amount)
        {
            return SharesPrice += amount;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees working in the company: ");
            foreach (var employee in Company)
            {
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}, Salary: {employee.GetSalary()} ");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }



    }
}
