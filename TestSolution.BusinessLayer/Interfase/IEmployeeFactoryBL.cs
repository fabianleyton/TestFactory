using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.BusinessLayer.Interfase
{
    public interface IEmployeeFactoryBL
    {
        Model.Interfase.IEmployee CreateEmployee(Model.Models.EmployeeApiModel employee);
    }
}
