using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSolution.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            BusinessLayer.Interfase.IEmployeeBL employeeBl = new BusinessLayer.Implementation.EmployeeBL();
            IList<Model.Interfase.IEmployee> result = employeeBl.GetEmployees();
            //Models.EmployeeViewModel employeeVM = new Models.EmployeeViewModel();
            return View("~/views/employee/list.cshtml",result);
        }

        private IList<Models.EmployeeViewModel> GetViewModel(IList<Model.Interfase.IEmployee> items)
        {
            IList<Models.EmployeeViewModel> result = new List<Models.EmployeeViewModel>();
            foreach (var item in items)
            {
                result.Add(new Models.EmployeeViewModel().{
                    
                });
            }
        }
    }
}