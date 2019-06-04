using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestSolution.Controllers
{
    public class EmployeeApiController : ApiController
    {
        public BusinessLayer.Interfase.IEmployeeBL _employeeBl;

        public EmployeeApiController()
        {
            _employeeBl = new BusinessLayer.Implementation.EmployeeBL();
        }

        public IList<Model.Interfase.IEmployee> GetEmployees()
        {
            return _employeeBl.GetEmployees();
        }
    }
}
