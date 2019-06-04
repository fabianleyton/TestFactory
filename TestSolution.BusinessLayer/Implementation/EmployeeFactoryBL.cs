using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.BusinessLayer.Interfase;
using TestSolution.Model.Interfase;
using TestSolution.Model.Models;

namespace TestSolution.BusinessLayer.Implementation
{
    public class EmployeeFactoryBL : Interfase.IEmployeeFactoryBL
    {
        
        IEmployee IEmployeeFactoryBL.CreateEmployee(EmployeeApiModel employee)
        {
            switch (employee.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new EmployeeHourlyDTO(employee);
                case "MonthlySalaryEmployee":
                    return new EmployeeMonthlyDTO(employee);
                default:
                    return null;
            }
        }
    }
}
