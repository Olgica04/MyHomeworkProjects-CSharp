using Domain.Enum;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName,double workHours, int payPerHour, Manager responsible) : base (firstName, lastName, RoleEnum.Contractor, 500)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            return Salary += WorkHours * PayPerHour;
        }

        public string CurrentPosition()
        {
            if(Responsible != null)
            {
                return Responsible.Department;
            }
            else
            {
                return "No assigned manager";
            }
        }
    }
}
