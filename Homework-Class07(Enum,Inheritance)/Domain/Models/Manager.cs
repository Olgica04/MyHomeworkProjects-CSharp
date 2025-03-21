
using Domain.Enum;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _Bonus;

        public string Department{ get; set; }

        public Manager(string firstName, string lastName, double salary, string department) : base (firstName, lastName, RoleEnum.Manager, salary)
        {
            _Bonus = 0;
            Department = department;
        }

        public void AddBonus(double bonus)
        {
             _Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _Bonus;
        }
    }
}
