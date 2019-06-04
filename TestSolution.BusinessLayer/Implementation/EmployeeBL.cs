using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.BusinessLayer.Implementation
{
    public class EmployeeBL : Interfase.IEmployeeBL
    {
        private Interfase.IEmployeeFactoryBL _employeeFactory;
        private IList<Model.Interfase.IEmployee> _employees;

        public EmployeeBL()
        {
            _employeeFactory = new EmployeeFactoryBL();
            _employees = new List<Model.Interfase.IEmployee>();
            
        }
        //IList<Model.Models.EmployeeApiModel> _employeeAPi
        private IList<Model.Models.EmployeeApiModel> GetEmployeeFromApi()
        {
            string url = "http://masglobaltestapi.azurewebsites.net/api/Employees";
            DataLayer.Interfase.IEmployeeDAO employeeDao = new DataLayer.Implementation.EmployeeDAO();
            return employeeDao.GetDataEmployees(url);
        }

        public IList<Model.Interfase.IEmployee> GetEmployees()
        {
            IList<Model.Interfase.IEmployee> resultado = new List<Model.Interfase.IEmployee>();
            IList<Model.Models.EmployeeApiModel> resultadoApi = GetEmployeeFromApi();
            if(resultadoApi != null)
            {
                foreach(var item in resultadoApi)
                {
                    resultado.Add(_employeeFactory.CreateEmployee(item));
                }
            }
            return resultado;
        }

         

    }
}
