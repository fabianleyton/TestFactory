using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Model.Models;

namespace TestSolution.DataLayer.Interfase
{
    public interface IEmployeeDAO
    {
        IList<EmployeeApiModel> GetDataEmployees(string url);
    }
}
