using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Model.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;

namespace TestSolution.DataLayer.Implementation
{
    public class EmployeeDAO : Interfase.IEmployeeDAO
    {
        static HttpClient client = new HttpClient();

        public IList<EmployeeApiModel> GetDataEmployees(string url)
        {
            IList<EmployeeApiModel> result = GetEmployeesAsync(url).GetAwaiter().GetResult();
            //return GetEmployeesApiToModel(result);
            return result;
        }

        static async Task<IList<EmployeeApiModel>> GetEmployeesAsync(string path)
        {
            IList<EmployeeApiModel> employee = null;
            HttpResponseMessage response = await client.GetAsync(path).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //employee = await response.Content.ReadAsAsync<EmployeeApiModel>();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                employee = JSserializer.Deserialize<List<EmployeeApiModel>>(response.Content.ReadAsStringAsync().Result.ToString());
            }
            return employee;
        }

        //public EmployeeDTO GetEmployeeApiToModel(EmployeeApiModel item)
        //{
        //    if (item != null)
        //    {
        //        return new EmployeeDTO()
        //        {
        //            Id = item.id,
        //            Name = item.name,
        //            ContractTypeName = item.contractTypeName,
        //            HourlySalary = item.hourlySalary,
        //            MonthlySalary = item.monthlySalary,
        //            RoleDescription = item.roleDescription,
        //            RoleId = item.roleId,
        //            RoleName = item.roleName
        //        };
        //    }
        //    return null;
        //}

        //public IList<Model.Models.EmployeeDTO> GetEmployeesApiToModel(IList<EmployeeApiModel> items)
        //{
        //    IList<Model.Models.EmployeeDTO> listEmployees = new List<Model.Models.EmployeeDTO>();
        //    if (items != null)
        //    {
        //        foreach (var item in items)
        //        {
        //            listEmployees.Add(GetEmployeeApiToModel(item));
        //        }

        //    }
        //    return listEmployees;
        //}
    }
}
