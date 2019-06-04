using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.BusinessLayer.Interfase
{
    public interface IEmployeeBL
    {
        IList<Model.Interfase.IEmployee> GetEmployees();
    }
}
