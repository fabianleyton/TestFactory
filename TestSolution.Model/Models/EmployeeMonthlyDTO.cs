using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Model.Models
{
    public class EmployeeMonthlyDTO : EmployeeDTO, Interfase.IEmployee
    {

        public EmployeeMonthlyDTO(EmployeeApiModel item): base(item)
        {
            GetAnualSalary();
        }

        public override decimal GetAnualSalary()
        {
            return AnualSalary = MonthlySalary * 12;
        }
    }
}
