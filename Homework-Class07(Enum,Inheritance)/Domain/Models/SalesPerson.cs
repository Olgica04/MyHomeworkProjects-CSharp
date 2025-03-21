using Domain.Enum;

namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue) : base (firstName, lastName, RoleEnum.Sales, 500)
        {
            _SuccessSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double number)
        {
            _SuccessSaleRevenue += number;
        }

        public override double GetSalary()
        {
            if(Salary <= 2000)
            {
                return Salary + 500;
            }
            else if(Salary > 2000 && Salary<= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }

        }
    }
}
