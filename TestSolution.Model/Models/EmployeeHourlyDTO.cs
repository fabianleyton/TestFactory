using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Model.Models
{
    public class EmployeeHourlyDTO : EmployeeDTO, Interfase.IEmployee
    {
        public EmployeeHourlyDTO(EmployeeApiModel item) : base(item)
        {
            GetAnualSalary();
        }
        public override decimal GetAnualSalary()
        {
            return AnualSalary = HourlySalary * 12 * 120;
        }
    }
}
